using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Saltyminer.Mining
{
    public class mainControl
    {
        // Used for checking software folders
        private downloadControl dc = new downloadControl();

        // Process for mining
        protected Process CPU_proc;
        protected Process GPU_proc;

        // Strings used to hold mining address
        public static string CPUADDRESS;
        public static string GPUADDRESS;

        // Used to determine what CPU or GPU software is currently being used
        public static string CPUSOFTWARE;
        public static string GPUSOFTWARE;

        // Used to determine what CPU or GPU software is currently being used
        public static string CPUPOOL;
        public static string GPUPOOL;

        // Strings used to display what algorithm to use
        public static string CPUALGO;
        public static string GPUALGO;

        // Strings used to contain custom parameters
        public static string CPUPARAMS;
        public static string GPUPARAMS;

        // Strings used to contain custom parameters
        public string CPUPATH;
        public string GPUPATH;

        // Bools used to determine whether the CPU and GPU are actually mining
        public bool iscpumining = false;
        public bool isgpumining = false;

        // Bools used to determine whether the CPU and GPU can mine
        public bool cpuenabled = false;
        public bool gpuenabled = false;

        // Strings used for finding proper arguments to use
        public string currentcpuargs;
        public string currentgpuargs;

        // Determines whether to enable optional dev fee
        public bool devfee;
		
		public string[] ARGS = 
		{
			// Used for XMRig/cpuminer-multi
			"-a " + CPUALGO + " --url=" + CPUPOOL + " -u " + CPUADDRESS + " " + CPUPARAMS,
			
			// Used for Wildrig
			"-a " + GPUALGO + " --url=" + GPUPOOL + " -u " + GPUADDRESS + " " + GPUPARAMS,
			
			// Used for Nanominer
			"-algo " + GPUALGO + " -pool1 " + GPUPOOL + " -wallet " + GPUADDRESS + " " + GPUPARAMS,
			
			// Used for Trex/Redminer/NBminer
			"-a " + GPUALGO + " -o " + GPUPOOL + " -u " + GPUADDRESS + " " + GPUPARAMS,
			
			// Used for Gminer
			"--algo " + GPUALGO + " --server " + GPUPOOL + " --user " + GPUADDRESS + " " + GPUPARAMS,
			
			// Used for lolMiner
			"--algo " + GPUALGO + " --pool " + GPUPOOL + " --user " + GPUADDRESS + " " + GPUPARAMS
		};

        // Loads up the proper configurations for the computer to mine with
        public async void checkCPUproccess()
        {
            if (CPUSOFTWARE == "XMRig")
            {
                CPUPATH = "xmrig-" + (await dc.findLatest("xmrig", "xmrig")).Substring(1) + @"\xmrig.exe";
                currentcpuargs = ARGS[0];
            }

            if (CPUSOFTWARE == "cpuminer-multi")
            {
                CPUPATH = @"cpuminer-multi\minerd.exe";
                currentcpuargs = ARGS[0];
            }
        }

        // Used to run the CPU miners using custom parameters
        public void runCPUMiner()
        {
            checkCPUproccess();
            CPU_proc = new Process();
            CPU_proc.StartInfo.FileName = CPUPATH;
            CPU_proc.StartInfo.Arguments = currentcpuargs;
            CPU_proc.StartInfo.CreateNoWindow = false;
            CPU_proc.StartInfo.UseShellExecute = false;
            CPU_proc.Start();
        }
		
		// Used to run the GPU miners using custom parameters
        public void runGPUMiner()
        {
            GPU_proc = new Process();
            GPU_proc.StartInfo.FileName = GPUPATH;
            GPU_proc.StartInfo.Arguments = ARGS[1];
            GPU_proc.StartInfo.CreateNoWindow = false;
            GPU_proc.StartInfo.UseShellExecute = false;
            GPU_proc.Start();
        }
    }
}
