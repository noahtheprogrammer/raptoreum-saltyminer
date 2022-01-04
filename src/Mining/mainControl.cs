using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saltyminer.Mining
{
    public class mainControl
    {
        // Bools used to determine whether the CPU or GPU are able to mine
        public bool cpuenabled = false;
        public bool gpuenabled = false;

        // Bools used to determine whether the CPU and GPU are actually mining
        public bool iscpumining = false;
        public bool isgpumining = false;

        // Used to determine what CPU or GPU software is currently being used
        public string cpusoftware;
        public string gpusoftware;

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
        
        // Runs the CPU miner
        public void RunCPUMiner()
        {
            cpu_process = new Process();
            cpu_process.StartInfo.FileName = cpu_path + cpu_software;
            cpu_process.StartInfo.Arguments = cpu_address + cpu_params;
            cpu_process.StartInfo.CreateNoWindow = output_en;
            cpu_process.StartInfo.UseShellExecute = false;
            cpu_process.Start();
        }
    }
}

// Holds serializable information to be saved/loaded by Saltyminer
[Serializable]
class miner_data
{
    public string saved_cpu_symbol;
    public string saved_gpu_symbol;
    public string saved_cpu_software;
    public string saved_gpu_software;
    public string saved_cpu_params;
    public string saved_gpu_params;
    public string saved_cpu_address;
    public string saved_gpu_address;
    public bool saved_devfee;
}
