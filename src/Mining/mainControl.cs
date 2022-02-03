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
        public bool cpuenabled = false;
        public bool gpuenabled = false;

        // Used to run the CPU miners using custom parameters
        public void runCPUMiner()
        {
            string cpu = (configs.cpu_coin.SelectedItem as ListBoxItem).Content.ToString();

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
            CPU_proc.StartInfo.Arguments = "-a " + CPUALGO + " -o " + CPUPOOL + " -u " + CPUADDRESS + " -p saltyminer";
            CPU_proc.StartInfo.CreateNoWindow = false;
            CPU_proc.StartInfo.UseShellExecute = false;
            CPU_proc.Start();
        }

        // Used to run the GPU miners using custom parameters
        public void runGPUMiner()
        {
            string gpu = (configs.gpu_coin.SelectedItem as ListBoxItem).Content.ToString();

            if (gpu == "ETH")
            {
                GPUPOOL = "us-eth.2miners.com:2020";
                GPUALGO = "ethash";
            }

            if (gpu == "RVN")
            {
                GPUPOOL = "us-rvn.2miners.com:6060";
                GPUALGO = "kawpow";
            }

            if (gpu == "ERG")
            {
                GPUPOOL = "us-erg.2miners.com:8888";
                GPUALGO = "autolykos";
            }

            if (gpu == "UBQ")
            {
                GPUPOOL = "us.ubiqpool.io:8008";
                GPUALGO = "ubqhash";
            }

            GPU_proc = new Process();
            GPU_proc.StartInfo.FileName = @"nanominer-windows-3.5.2\nanominer.exe";
            GPU_proc.StartInfo.Arguments = "-algo " + GPUALGO + " -wallet " + GPUADDRESS + " -pool1 " + GPUPOOL + " -email SALTYRIG";
            GPU_proc.StartInfo.CreateNoWindow = false;
            GPU_proc.StartInfo.UseShellExecute = false;
            GPU_proc.Start();
        }
    }
}
