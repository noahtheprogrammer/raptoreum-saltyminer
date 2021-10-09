using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace salty_namespace
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
            miner.sm = this;
            monitor.sm = this;
            design.sm = this;

            // Rounds the form edges
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));

            // Changes text displays
            change_text_saved();
            set_box.DrawItem += new DrawItemEventHandler(design.set_box_DrawItem);

            // Checks what to change the thread text to
            core_count.Text = threads_text.Text;
            if (miner.thread_count == "")
            {
                core_count.Text = "NA";
            }

            arch_count.Text = RuntimeInformation.ProcessArchitecture.ToString();
        }

        // Starts or stops the mining whenever the button is clicked
        private void mining_button_Click_1(object sender, EventArgs e)
        {
            if (miner._ismining == false)
            {
                miner.RunMiner();
                ButtonChange();
                miner._ismining = true;
            }

            else if (miner._ismining == true)
            {
                miner.process.Kill();
                cmd_output.Text = "Saltyminer has been shut down successfully.";
                ButtonChange();
                miner._ismining = false;
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
        private void extra_params_TextChanged(object sender, EventArgs e)
        {
            miner.extra_params = extra_params_text.Text;
        }

        // Gets the proper instruction set chosen to mine
        private void set_box_SelectedIndexChanged(object sender, EventArgs e)
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

        // Outputs the mining process
        public void SortOutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (cmd_output.InvokeRequired)
            {
                cmd_output.BeginInvoke(new DataReceivedEventHandler(SortOutputHandler), new[] { sendingProcess, outLine });
            }
            else
            {
                miner.cmdOutput.Append(Environment.NewLine + outLine.Data);
                cmd_output.AppendText(miner.cmdOutput.ToString());
            }
        }

        // Saves the changed text
        private void change_text_saved()
        {
            address_text.Text = miner.address;
            pool_text.Text = miner.pool;
            threads_text.Text = miner.thread_count;
            extra_params_text.Text = miner.extra_params;
            set_box.Text = miner.instruction_set;
        }

        // Changes button color
        private void ButtonChange()
        {
            if (miner._ismining == false)
            {
                mining_button.Image = Properties.Resources.mine_stop;
            }

            if (miner._ismining == true)
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
            if (miner.process == null)
            {
                Application.Exit();
            }

            else
            {
                miner.process.Close();
                Application.Exit();
            }
        }

        // Hides the program on click
        private void min_button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
