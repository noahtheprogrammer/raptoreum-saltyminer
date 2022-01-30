using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Controls;

namespace Saltyminer.Mining
{
    public class mainControl
    {
        // Used to get configurations class
        public Configs configs;

        // Process for mining
        protected Process CPU_proc;
        protected Process GPU_proc;

        // Strings used to hold mining address
        public static string CPUADDRESS;
        public static string GPUADDRESS;

        // Used to determine what CPU or GPU software is currently being used
        public static string CPUPOOL;
        public static string GPUPOOL;

        // Strings used to display what algorithm to use
        public static string CPUALGO;
        public static string GPUALGO;

        // Bools used to determine whether the CPU and GPU are actually mining
        public bool iscpumining = false;
        public bool isgpumining = false;

        // Bools used to determine whether the CPU and GPU can mine
        public bool cpuenabled = false;
        public bool gpuenabled = false;

        // Used to evaluate proper pool and algorithm to use
        public void poolCheck()
        {
            string cpu = (configs.cpu_coin.SelectedItem as ListBoxItem).Content.ToString();
            string gpu = (configs.gpu_coin.SelectedItem as ListBoxItem).Content.ToString();

            if (cpu == "XMR")
            {
                CPUPOOL = "xmr.2miners.com:2222";
                CPUALGO = "randomx";
            }

            else if (cpu == "RTM")
            {
                CPUPOOL = "us.flockpool.com:5555";
                CPUALGO = "gr";
            }

            else if (gpu == "ETH")
            {
                GPUPOOL = "us-eth.2miners.com:2020";
                GPUALGO = "ethash";
            }

            else if (gpu == "RVN")
            {
                GPUPOOL = "us-rvn.2miners.com:6060";
                GPUALGO = "kawpow";
            }

            else if (gpu == "ERG")
            {
                GPUPOOL = "us-erg.2miners.com:8888";
                GPUALGO = "autolykos";
            }

            else if (gpu == "UBQ")
            {
                GPUPOOL = "us.ubiqpool.io:8008";
                GPUALGO = "ubqhash";
            }
        }

        // Used to run the CPU miners using custom parameters
        public void runCPUMiner()
        {
            poolCheck();
            CPU_proc = new Process();
            CPU_proc.StartInfo.FileName = @"xmrig-6.16.2\xmrig.exe";
            CPU_proc.StartInfo.Arguments = "-algo " + CPUALGO + " --url=" + CPUPOOL + " -u " + CPUADDRESS;
            CPU_proc.StartInfo.CreateNoWindow = false;
            CPU_proc.StartInfo.UseShellExecute = false;
            CPU_proc.Start();
        }
		
		// Used to run the GPU miners using custom parameters
        public void runGPUMiner()
        {
            poolCheck();
            GPU_proc = new Process();
            GPU_proc.StartInfo.FileName = @"nanominer-windows-3.5.2\nanominer.exe";
            GPU_proc.StartInfo.Arguments = "-a " + GPUALGO + " -pool1 " + GPUPOOL + " -wallet " + GPUADDRESS;
            GPU_proc.StartInfo.CreateNoWindow = false;
            GPU_proc.StartInfo.UseShellExecute = false;
            GPU_proc.Start();
        }
    }
}
