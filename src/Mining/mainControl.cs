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
        public Dashboard db;

        // Process for mining
        protected Process CPU_proc;
        protected Process GPU_proc;

        // Strings used to hold mining address
        public string CPUADDRESS;
        public string GPUADDRESS;

        // Used to determine what CPU or GPU software is currently being used
        public string CPUPOOL;
        public string GPUPOOL;

        // Strings used to display what algorithm to use
        public string CPUALGO;
        public string GPUALGO;

        // Bools used to determine whether the CPU and GPU are actually mining
        public bool iscpumining = false;
        public bool isgpumining = false;

        // Bools used to determine whether the CPU and GPU can mine
        public bool cpuenabled = true;
        public bool gpuenabled = true;

        // Used to run the CPU miners using custom parameters
        public void runCPUMiner()
        {

            string cpu = "NULL";

            if (cpu == "XMR")
            {
                CPUPOOL = "xmr.2miners.com:2222";
                CPUALGO = "randomx";
            }

            if (cpu == "RTM")
            {
                CPUPOOL = "us.flockpool.com:5555";
                CPUALGO = "gr";
            }

            CPU_proc = new Process();
            CPU_proc.StartInfo.FileName = @"xmrig-6.16.2\xmrig.exe";
            CPU_proc.StartInfo.Arguments = "-a " + CPUALGO + " -o " + CPUPOOL + " -u " + CPUADDRESS + " -p saltyminer --http-port 4066";
            CPU_proc.StartInfo.CreateNoWindow = false;
            CPU_proc.StartInfo.UseShellExecute = false;
            CPU_proc.Start();
        }

        // Used to run the GPU miners using custom parameters
        public void runGPUMiner()
        {
            string gpu = "NULL";

            if (gpu == "ETH")
            {
                GPUPOOL = "stratum+tcp://eth.2miners.com:2020";
                GPUALGO = "ethash";
            }

            if (gpu == "ETC")
            {
                GPUPOOL = "stratum+tcp://etc.2miners.com:1010";
                GPUALGO = "ethash";
            }

            if (gpu == "RVN")
            {
                GPUPOOL = "stratum+tcp://rvn.2miners.com:6060";
                GPUALGO = "kawpow";
            }

            if (gpu == "CFX")
            {
                GPUPOOL = "stratum+tcp://cfx-eu1.nanopool.org:17777";
                GPUALGO = "octopus";
            }

            if (gpu == "ERG")
            {
                GPUPOOL = "stratum+tcp://erg.2miners.com:8888";
                GPUALGO = "autolykos2";
            }

            GPU_proc = new Process();
            GPU_proc.StartInfo.FileName = @"trex\t-rex.exe";
            GPU_proc.StartInfo.Arguments = "-a " + GPUALGO + " -o " + GPUPOOL + " -u " + GPUADDRESS + " -p saltyminer";
            GPU_proc.StartInfo.CreateNoWindow = false;
            GPU_proc.StartInfo.UseShellExecute = false;
            GPU_proc.Start();
        }
        
        // Saves the values into "info.dat" whenever a variable is changed or toggled
        public void saveValues() 
        {
            using (var stream = File.Open("info.dat", FileMode.Create)) 
            {
                using (var writer = new BinaryWriter(stream, Encoding.UTF8, false)) 
                {
                    writer.Write(CPUADDRESS);
                    writer.Write(GPUADDRESS);
                    writer.Write(CPUPOOL);
                    writer.Write(GPUPOOL);
                    writer.Write(CPUALGO);
                    writer.Write(GPUALGO);
                    writer.Write(cpuenabled);
                    writer.Write(gpuenabled);
                }
            }
        }
        
        // Loads the saved values in "info.dat" on startup if they exist
        public void loadValues() 
        {
            if (File.Exists("info.dat")) 
            {
                using (var stream = File.Open("info.dat", FileMode.Open)) 
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        CPUADDRESS = reader.ReadString();
                        GPUADDRESS = reader.ReadString();
                        CPUPOOL = reader.ReadString();
                        GPUPOOL = reader.ReadString();
                        CPUALGO = reader.ReadString();
                        GPUALGO = reader.ReadString();
                        cpuenabled = reader.ReadBoolean();
                        gpuenabled = reader.ReadBoolean();
                    }
                }
            }
        }
    }
}
