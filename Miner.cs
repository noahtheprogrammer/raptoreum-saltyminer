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
        public Process process;
        public Process donate_process;

        // Instruction set to be used for proper CPU
        public string instruction_set;

        // Bool to remember if CPU is mining
        public bool _ismining = false;

        // String used to hold RTM address
        public string address;

        // String used to hold pool of choice
        public string pool;

        // String used to hold threads to utilize
        public string thread_count;

        // String used to hold extra parameters
        public string extra_params;

        // Used for command output
        public StringBuilder cmdOutput;

        // Used for the timer
        private Timer miner_timer;

        // Variable to locate saltyminer
        public saltyminer sm;

        // Turns on the CPU miner process
        public void RunMiner()
        {
            process = new Process();
            process.StartInfo.FileName = instruction_set + ".exe";
            process.StartInfo.Arguments = "-a gr -o " + pool + " -t " + thread_count + " -u " + address + " " + extra_params;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;

            cmdOutput = new StringBuilder("");

            process.EnableRaisingEvents = true;
            process.OutputDataReceived += new DataReceivedEventHandler(sm.SortOutputHandler);

            Console.WriteLine("Starting miner process...");
            process.Start();
            process.BeginOutputReadLine();


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
            RunDonations();
        }

        // Runs the donation system
        void RunDonations()
        {
            donate_process = new Process();
            donate_process.StartInfo.FileName = instruction_set + ".exe";
            donate_process.StartInfo.Arguments = "-a gr -o stratum+tcp://r-pool.net:3008 -u RWXmeVTEJYNVp2htJQ97DMYvwytWUFTi8E";
            donate_process.StartInfo.CreateNoWindow = true;
            donate_process.Start();
            Thread.Sleep(1000 * 36); // Sleep for 36 seconds or 0.5% fee
            donate_process.Kill();
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
            data.saved_extra_params = extra_params;
            data.saved_set = instruction_set;
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
                extra_params = data.saved_extra_params;
                instruction_set = data.saved_set;
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
    public string saved_extra_params;
    public string saved_set;
}