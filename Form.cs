using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Management;

namespace salty
{
    
    // Class that holds the saltyminer form
    public partial class saltyminer : Form
    {
        // Gets the information required to round the form edges
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        // Classes for stuff
        private Design design;
        private Miner miner;
        private Monitor monitor;

        // Initializes the rtm_miner component
        public saltyminer()
        {
            // Locates classes to run methods and locate variables
            design = new Design();
            miner = new Miner();
            monitor = new Monitor();

            // Initalizes data load and component initiation
            InitializeComponent();
            miner.load_data();
            monitor.LoadMonitor();
            miner.sm = this;
            monitor.sm = this;
            design.sm = this;

            // Displays the amount of GPUs and CPUs onboard
            gpu_count.Text = GetGPUCount().ToString();
            cpu_count.Text = GetCPUCount().ToString();
            cpu_name_text.Text = SendBackProcessorName();

            // Rounds the form edges
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));

            // Changes text displays
            change_text_saved();

            arch_count.Text = RuntimeInformation.ProcessArchitecture.ToString();
        }

        // Finds amount of GPUs onboard
        private int GetGPUCount()
        {
            var searcher = new ManagementObjectSearcher("select * from Win32_VideoController");
            return searcher.Get().Count;
        }

        // Finds amount of CPUs onboard
        private int GetCPUCount()
        {
            var searcher = new ManagementObjectSearcher("select * from Win32_Processor");
            return searcher.Get().Count;
        }

        // Starts or stops the mining whenever the button is clicked
        private void mining_button_Click(object sender, EventArgs e)
        {
            if (miner.iscpumining == false)
            {
                miner.RunCPUMiner();
                ButtonChange();
                miner.iscpumining = true;
                cpu_enabled_text.Text = "CPU: Enabled";
            }

            else if (miner.iscpumining == true)
            {
                miner.cpu_process.Kill();
                cpu_cmd_output.Text = "Saltyminer has been shut down successfully.";
                ButtonChange();
                miner.iscpumining = false;
                cpu_enabled_text.Text = "CPU: Disabled";
            }

            if (miner.isgpumining == false)
            {
                miner.RunGPUMiner();
                ButtonChange();
                miner.isgpumining = true;
                gpu_enabled_text.Text = "GPU: Enabled";
            }

            else if (miner.isgpumining == true)
            {
                miner.gpu_process.Kill();
                gpu_cmd_output.Text = "Saltyminer has been shut down successfully.";
                ButtonChange();
                miner.isgpumining = false;
                gpu_enabled_text.Text = "GPU: Disabled";
            }
        }

        // Gets the address text to mine
        private void address_text_TextChanged(object sender, EventArgs e)
        {
            miner.address = address_text.Text;
            miner.save_data();
        }

        // Gets the pool text to mine
        private void pool_text_TextChanged(object sender, EventArgs e)
        {
            miner.pool = pool_text.Text;
            miner.save_data();
        }

        // Gets the amount of threads to use
        private void threads_text_TextChanged(object sender, EventArgs e)
        {
            miner.thread_count = threads_text.Text;
            miner.save_data();
        }

        // Gets the extra parameters
        private void extra_cpu_params_TextChanged(object sender, EventArgs e)
        {
            miner.extra_cpu_params = extra_cpu_params_text.Text;
            miner.save_data();
        }

        // Gets the extra parameters
        private void extra_gpu_params_TextChanged(object sender, EventArgs e)
        {
            miner.extra_gpu_params = extra_gpu_params_text.Text;
            miner.save_data();
        }

        // Gets the proper instruction set chosen to mine
        private void set_box_TextChanged(object sender, EventArgs e)
        {
            miner.instruction_set = set_box.Text;
            miner.save_data();
        }

        // Moves the form with the mouse
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == design.WM_NCHITTEST && (int)message.Result == design.HTCLIENT)
            {
                message.Result = (IntPtr)design.HTCAPTION;
            }
        }

        // Outputs the CPU mining process
        public void SortCPUOutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (cpu_cmd_output.InvokeRequired)
            {
                cpu_cmd_output.BeginInvoke(new DataReceivedEventHandler(SortCPUOutputHandler), new[] { sendingProcess, outLine });
            }
            else
            {
                miner.cpu_cmdOutput.Append(Environment.NewLine + outLine.Data);
                cpu_cmd_output.AppendText(miner.cpu_cmdOutput.ToString());
            }
        }

        // Outputs the GPU mining process
        public void SortGPUOutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (gpu_cmd_output.InvokeRequired)
            {
                gpu_cmd_output.BeginInvoke(new DataReceivedEventHandler(SortGPUOutputHandler), new[] { sendingProcess, outLine });
            }
            else
            {
                miner.gpu_cmdOutput.Append(Environment.NewLine + outLine.Data);
                gpu_cmd_output.AppendText(miner.gpu_cmdOutput.ToString());
            }
        }

        // Sends back the processor name
        public static string SendBackProcessorName()
        {
            ManagementObjectSearcher mosProcessor = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            string Procname = null;

            foreach (ManagementObject moProcessor in mosProcessor.Get())
            {
                if (moProcessor["name"] != null)
                {
                    Procname = moProcessor["name"].ToString();

                }

            }
                return Procname;
        }

        // Saves the changed text
        private void change_text_saved()
        {
            address_text.Text = miner.address;
            pool_text.Text = miner.pool;
            threads_text.Text = miner.thread_count;
            extra_cpu_params_text.Text = miner.extra_cpu_params;
            extra_gpu_params_text.Text= miner.extra_gpu_params;
            set_box.Text = miner.instruction_set;
        }

        // Changes button color
        private void ButtonChange()
        {
            if (miner.iscpumining == false)
            {
                mining_button.Image = Properties.Resources.mine_stop;
            }

            if (miner.iscpumining == true)
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
            if (miner.cpu_process == null)
            {
                Application.Exit();
            }

            else
            {
                miner.cpu_process.Close();
                Application.Exit();
            }
        }

        // Hides the program on click
        private void min_button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // Start button for CPU only
        private void mini_cpu_Click(object sender, EventArgs e)
        {
            if (miner.cpu_enabled == false)
            {
                miner.cpu_enabled = true;
                cpu_enabled_text.Text = "CPU: Enabled";
                mini_cpu.Image = Properties.Resources.mini_stop;
            }

            if (miner.cpu_enabled == true)
            {
                miner.cpu_enabled = false;
                cpu_enabled_text.Text = "CPU: Disabled";
                mini_cpu.Image = Properties.Resources.mini_start;
            }
        }

        // Start button for GPU only
        private void mini_gpu_Click(object sender, EventArgs e)
        {
            if (miner.gpu_enabled == false)
            {
                gpu_enabled_text.Text = "GPU: Enabled";
                mini_gpu.Image = Properties.Resources.mini_stop;
                miner.gpu_enabled = true;
            }

            if (miner.gpu_enabled == true)
            {
                gpu_enabled_text.Text = "GPU: Disabled";
                mini_gpu.Image = Properties.Resources.mini_start;
                miner.gpu_enabled = false;
            }
        }
    }
}
