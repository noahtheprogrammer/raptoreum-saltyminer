using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Timers;
using System.Threading;
using System.Text;
using Timer = System.Timers.Timer;

namespace salty
{
    class Miner
    {
        // Process and info to be used for mining
        public Process cpu_process;
        public Process cpu_donate_process;
        public Process gpu_process;
        public Process gpu_donate_process;

        // Instruction set to be used for proper CPU
        public string instruction_set;

        // Bool to remember if CPU is mining
        public bool iscpumining = false;
        public bool isgpumining = false;

        // Bool to enable miners
        public bool cpu_enabled = false;
        public bool gpu_enabled = false;
        public int enabled_count;

        // String used to hold RTM address and username
        public string address;
        public string username;

        // String used to hold pool of choice
        public string pool;

        // String used to hold threads to utilize
        public string thread_count;

        // String used to hold extra parameters
        public string extra_cpu_params;
        public string extra_gpu_params;

        // Used for command output
        public StringBuilder cpu_cmdOutput;
        public StringBuilder gpu_cmdOutput;

        // Used for the timer
        private Timer miner_timer;

        // Variable to locate saltyminer
        public saltyminer sm;

        // Turns on the CPU miner process
        public void RunCPUMiner()
        {
            cpu_process = new Process();
            cpu_process.StartInfo.FileName = instruction_set + ".exe";
            cpu_process.StartInfo.Arguments = "-a gr -o " + pool + " -t " + thread_count + " -u " + address + " --pass " + username + " " + extra_cpu_params;
            cpu_process.StartInfo.CreateNoWindow = true;
            cpu_process.StartInfo.UseShellExecute = false;
            cpu_process.StartInfo.RedirectStandardOutput = true;
            cpu_process.StartInfo.RedirectStandardError = true;

            cpu_cmdOutput = new StringBuilder("");

            cpu_process.EnableRaisingEvents = true;
            cpu_process.OutputDataReceived += new DataReceivedEventHandler(sm.SortCPUOutputHandler);

            Console.WriteLine("Starting CPU miner...");
            cpu_process.Start();
            cpu_process.BeginOutputReadLine();


            if (!pool.Contains("loudmining.com"))
            {
                // Sets the timer
                miner_timer = new Timer
                {
                    Interval = 1000 * 60 * 60
                };

                miner_timer.Elapsed += new ElapsedEventHandler(donation_timer);
                miner_timer.Start();
            }
        }

        // Turns on the GPU miner process
        public void RunGPUMiner()
        {
            gpu_process = new Process();
            gpu_process.StartInfo.FileName = "wildrig.exe";
            gpu_process.StartInfo.Arguments = "--print-full --algo ghostrider --url " + pool + " --user " + address + " --pass " + username + " " + extra_gpu_params;
            gpu_process.StartInfo.CreateNoWindow = true;
            gpu_process.StartInfo.UseShellExecute = false;
            gpu_process.StartInfo.RedirectStandardOutput = true;
            gpu_process.StartInfo.RedirectStandardError = true;

            gpu_cmdOutput = new StringBuilder("");

            gpu_process.EnableRaisingEvents = true;
            gpu_process.OutputDataReceived += new DataReceivedEventHandler(sm.SortGPUOutputHandler);

            Console.WriteLine("Starting GPU miner...");
            gpu_process.Start();
            gpu_process.BeginOutputReadLine();


            if (!pool.Contains("loudmining.com"))
            {
                // Sets the timer
                miner_timer = new Timer
                {
                    Interval = 1000 * 60 * 60
                };

                miner_timer.Elapsed += new ElapsedEventHandler(donation_timer);
                miner_timer.Start();
            }
        }

        // Timer used for donations
        void donation_timer(object sender, ElapsedEventArgs e)
        {
            RunCPUDonations();
            RunGPUDonations();
        }

        // Runs the donation system
        void RunCPUDonations()
        {
            cpu_donate_process = new Process();
            cpu_donate_process.StartInfo.FileName = instruction_set + ".exe";
            cpu_donate_process.StartInfo.Arguments = "-a gr -o stratum+tcp://r-pool.net:3008 -u RWXmeVTEJYNVp2htJQ97DMYvwytWUFTi8E --pass " + username;
            cpu_donate_process.StartInfo.CreateNoWindow = true;
            cpu_donate_process.Start();
            Thread.Sleep(1000 * 36); // Sleep for 36 seconds or 0.5% fee
            cpu_donate_process.Kill();
        }

        // Runs the donation system
        void RunGPUDonations()
        {
            gpu_donate_process = new Process();
            gpu_donate_process.StartInfo.FileName = "wildrig.exe";
            gpu_donate_process.StartInfo.Arguments = "--print-full --algo ghostrider --url stratum+tcp://r-pool.net:3008 --u RWXmeVTEJYNVp2htJQ97DMYvwytWUFTi8E --pass " + username;
            gpu_donate_process.StartInfo.CreateNoWindow = true;
            gpu_donate_process.Start();
            Thread.Sleep(1000 * 36); // Sleep for 36 seconds or 0.5% fee
            gpu_donate_process.Kill();
        }

        // Saves mining information
        public void save_data()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create(Application.StartupPath + "miner_data.dat");
            miner_data data = new miner_data();
            data.saved_address = address;
            data.saved_pool = pool;
            data.saved_threads = thread_count;
            data.saved_extra_cpu_params = extra_cpu_params;
            data.saved_extra_gpu_params = extra_gpu_params;
            data.saved_set = instruction_set;
            data.saved_username = username;
            bf.Serialize(file, data);
            file.Close();
        }

        // Loads mining information
        public void load_data()
        {
            if (File.Exists(Application.StartupPath + "miner_data.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Open(Application.StartupPath + "miner_data.dat", FileMode.Open);
                miner_data data = (miner_data)bf.Deserialize(file);
                file.Close();
                address = data.saved_address;
                pool = data.saved_pool;
                thread_count = data.saved_threads;
                extra_cpu_params = data.saved_extra_cpu_params;
                extra_gpu_params = data.saved_extra_gpu_params;
                instruction_set = data.saved_set;
                username = data.saved_username;
            }
        }
    }
}

// Holds serializable miner information
[Serializable]
class miner_data
{
    public string saved_address;
    public string saved_pool;
    public string saved_threads;
    public string saved_extra_cpu_params;
    public string saved_extra_gpu_params;
    public string saved_set;
    public string saved_username;
}