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
        // Process for mining
        protected Process m_proc;

        // Bools used to determine whether the CPU or GPU are able to mine
        public bool cpuenabled = false;
        public bool gpuenabled = false;

        // Bools used to determine whether the CPU and GPU are actually mining
        public bool iscpumining = false;
        public bool isgpumining = false;

        // Used to determine what CPU or GPU software is currently being used
        public string cpusoftware;
        public string gpusoftware;

        // Used to determine what CPU or GPU software is currently being used
        public string cpupool;
        public string gpupool;

        // Strings used to display what coin to mine
        public string cpu_symbol;
        public string gpu_symbol;

        // Strings used to contain custom parameters
        public string cpu_params;
        public string gpu_params;

        // Strings used to contain custom parameters
        public string cpu_path;
        public string gpu_path;

        // Integers used to display current hashrate for device
        public int cpu_hashrate;
        public int gpu_hashrate;

        // Strings used to hold mining address
        public string cpu_address;
        public string gpu_address;

        // Determines whether to enable optional dev fee
        public bool devfee;

        // Determines whether to enable output windows
        public bool output_en;

        // Used to run the miner using custom parameters
        public void runMiner(string path, string software, string arguments, string address)
        {
            m_proc = new Process();
            m_proc.StartInfo.FileName = path + software;
            m_proc.StartInfo.Arguments = address + arguments;
            m_proc.StartInfo.CreateNoWindow = output_en;
            m_proc.StartInfo.UseShellExecute = false;
            m_proc.Start();
        }
    }
}
