using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Timers;
using System.Threading;
using System.Threading.Tasks;
using System.Text;
using Timer = System.Timers.Timer;

namespace salty_namespace
{

    // Class that holds the saltyminer form
    public partial class saltyminer : Form
    {
        // Gets the information required to move the form with the mouse
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        // Process and info to be used for mining
        Process process;
        Process donate_process;

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

        // Used for cpu counter
        PerformanceCounter cpuCounter;

        public PrivateFontCollection pfc = new PrivateFontCollection();


        // Used for timer
        private Timer miner_timer;
        System.Windows.Forms.Timer cpu_timer = new System.Windows.Forms.Timer();
        private StringBuilder cmdOutput;

        // Gets the information required to round the form edges
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);


        // Initializes the rtm_miner component
        public saltyminer()
        {
            // Initalizes data load
            
            InitializeComponent();
            load_data();

            
            int fontLength = Properties.Resources.roboto_medium.Length;
            byte[] fontdata = Properties.Resources.roboto_medium;
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);

            // Rounds the form edges
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));


            // Loads the CPU monitor
            cpuCounter = new PerformanceCounter();
            cpuCounter.CategoryName = "Processor";
            cpuCounter.CounterName = "% Processor Time";
            cpuCounter.InstanceName = "_Total";
            InitTimer();

            // Changes text displays
            change_text_saved();
            set_box.DrawItem += new DrawItemEventHandler(set_box_DrawItem);

            // Checks what to change the thread text to
            core_count.Text = threads_text.Text;
            if (thread_count == "")
            {
                core_count.Text = "NA";
            }

            arch_count.Text = RuntimeInformation.ProcessArchitecture.ToString();
        }

        // Timer for the CPU percentage check routine
        public void InitTimer()
        {
            cpu_timer.Tick += new EventHandler(cpu_timer_Tick);
            cpu_timer.Interval = 2000; // in miliseconds
            cpu_timer.Start();
        }

        // Initates the checking routine
        private async void cpu_timer_Tick(object sender, EventArgs e)
        {
            Task<string> cpu_task = new Task<string>(getCurrentCpuUsage);
            cpu_task.Start();
            cpu_usage.Text = await cpu_task;
        }

        // Method to find the CPU resources
        public string getCurrentCpuUsage()
        {
            string value1 = (int)cpuCounter.NextValue() + "%";
            Thread.Sleep(500);
            string value2 = (int)cpuCounter.NextValue() + "%";
            return value2.ToString();
        }

        // Timer used for donations
        void donation_timer(object sender, ElapsedEventArgs e)
        {
            RunDonations();
        }

        // Starts or stops the mining whenever the button is clicked
        private void mining_button_Click_1(object sender, EventArgs e)
        {
            if (_ismining == false)
            {
                RunMiner();
                ButtonChange();
                _ismining = true;
            }

            else if (_ismining == true)
            {
                process.Kill();
                cmd_output.Text = "Saltyminer has been shut down successfully.";
                ButtonChange();
                _ismining = false;
            }
        }

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
            process.OutputDataReceived += new DataReceivedEventHandler(SortOutputHandler);

            Console.WriteLine("Starting Miner Process");
            process.Start();
            process.BeginOutputReadLine();

            // Sets the timer
            miner_timer = new Timer
                {
                    Interval = 1000 * 60 * 60
                };

            miner_timer.Elapsed += new ElapsedEventHandler(donation_timer);
            miner_timer.Start();
        }

        // Outputs the mining process
        private void SortOutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if(cmd_output.InvokeRequired)
            {
                cmd_output.BeginInvoke(new DataReceivedEventHandler(SortOutputHandler), new[] { sendingProcess, outLine });
            }
            else
            {
                cmdOutput.Append(Environment.NewLine + outLine.Data);
                cmd_output.AppendText(cmdOutput.ToString());
            }
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

        // Gets the address text to mine
        private void address_text_TextChanged(object sender, EventArgs e)
        {
            address = address_text.Text;
            save_data();
        }

        // Gets the pool text to mine
        private void pool_text_TextChanged(object sender, EventArgs e)
        {
            pool = pool_text.Text;
            save_data();
        }

        // Gets the amount of threads to use
        private void threads_text_TextChanged(object sender, EventArgs e)
        {
            thread_count = threads_text.Text;
            save_data();
        }

        // Gets the extra parameters
        private void extra_params_TextChanged(object sender, EventArgs e)
        {
            extra_params = extra_params_text.Text;
        }

        // Gets the proper instruction set chosen to mine
        private void set_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            instruction_set = set_box.Text;
            save_data();
        }

        // Moves the form with the mouse
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
            {
                message.Result = (IntPtr)HTCAPTION;
            }
        }

        // Saves the changed text
        private void change_text_saved()
        {
            address_text.Text = address;
            pool_text.Text = pool;
            threads_text.Text = thread_count;
            extra_params_text.Text = extra_params;
            set_box.Text = instruction_set;
        }

        // Changes button color
        private void ButtonChange()
        {
            if (_ismining == false)
            {
                mining_button.Image = Properties.Resources.mine_stop;
            }

            if (_ismining == true)
            {
                mining_button.Image = Properties.Resources.mine_start;
            }
        }

        // Brings the mining panel to the front
        private void dash_button_Click(object sender, EventArgs e)
        {
            panel_2.BringToFront();
        }

        // Brings the configuration panel to the front
        private void config_button_Click(object sender, EventArgs e)
        {
            panel_1.BringToFront();
        }

        // Quits the program on click
        private void quit_button_Click(object sender, EventArgs e)
        {
            if (process == null)
            {
                Application.Exit();
            }

            else
            {
                process.Close();
                Application.Exit();
            }
        }

        // Hides the program on click
        private void min_button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // Saves mining information
        void save_data()
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
        void load_data()
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


        // Changes the set box color
        private void set_box_DrawItem(object sender, DrawItemEventArgs e)
        {
            var brush = new SolidBrush(Color.FromKnownColor(KnownColor.ControlDarkDark));

            if (e.Index < 0) return;

            //if the item state is selected them change the back color 
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds, e.Index, e.State ^ DrawItemState.Selected, e.ForeColor, Color.FromArgb(50, 50, 50));

            // Draw the background of the ListBox control for each item.
            e.DrawBackground();

            // Draw the current item text
            e.Graphics.DrawString(set_box.Items[e.Index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);

            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }
    }
}

[Serializable]
class miner_data
{
    public string saved_address;
    public string saved_pool;
    public string saved_threads;
    public string saved_extra_params;
    public string saved_set;
}
