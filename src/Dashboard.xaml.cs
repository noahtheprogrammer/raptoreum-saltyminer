using System;
using System.Management;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Saltyminer.Mining;
using System.Net;

namespace Saltyminer
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        // Classes used to retrieve information on mining
        private mainControl mc;
        private downloadControl dc;

        // Dashboard initialization
        public Dashboard()
        {
            mc = new mainControl();
            dc = new downloadControl();

            InitializeComponent();
            UpdateInformation();
        }

        // Shuts down application when called
        private void exit_img_Click(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        // Minimizes application when called
        private void mini_img_Click(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        // Opens the configurations window
        private void config_img_Click(object sender, MouseButtonEventArgs e)
        {
            Configs configs = new Configs();
            configs.Show();
        }

        // Called whenever the main mining button is clicked
        private void main_btn_Click(object sender, MouseButtonEventArgs e)
        {
            main_btn.Source = new BitmapImage(new Uri("/Resources/light_stop.png", UriKind.Relative));
        }

        // Used to drag the window
        private void drag_window(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        // Changes to new devices menu
        private void devices_btn_Click(object sender, MouseButtonEventArgs e)
        {
            installations_grid.Visibility = Visibility.Collapsed;
            home_grid.Visibility = Visibility.Collapsed;
            devices_grid.Visibility = Visibility.Visible;
        }

        // Changes to new installations menu
        private void installations_btn_Click(object sender, MouseButtonEventArgs e)
        {
            home_grid.Visibility = Visibility.Collapsed;
            devices_grid.Visibility = Visibility.Collapsed;
            installations_grid.Visibility = Visibility.Visible;
        }

        // Changes to new home menu
        private void home_btn_Click(object sender, MouseButtonEventArgs e)
        {
            installations_grid.Visibility = Visibility.Collapsed;
            devices_grid.Visibility = Visibility.Collapsed;
            home_grid.Visibility = Visibility.Visible;
        }

        // Called on startup and used to identify model and load presets
        public void UpdateInformation()
        {
            cpu_type.Content = SendBackProcessorName();

            if (mc.iscpumining == true)
            {
                cpu_info.Content = "Currently mining using" + mc.cpusoftware;
                gpu_status.Source = new BitmapImage(new Uri("/Resources/check.png", UriKind.Relative));
            }

            else
            {
                cpu_info.Content = "Currently not mining";
                gpu_status.Source = new BitmapImage(new Uri("/Resources/x.png", UriKind.Relative));
            }

            gpu_type.Content = SendBackMainGraphicsName();

            if (mc.isgpumining == true)
            {
                gpu_info.Content = "Currently mining using" + mc.gpusoftware;
                gpu_status.Source = new BitmapImage(new Uri("/Resources/check.png", UriKind.Relative));
            }

            else
            {
                gpu_info.Content = "Currently not mining";
                gpu_status.Source = new BitmapImage(new Uri("/Resources/x.png", UriKind.Relative));
            }
        }


        // Uses System.Management to send back the current processor name
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

        // Sends back the main graphics card name
        public static string SendBackMainGraphicsName()
        {
            ManagementObjectSearcher mosGraphicsCard = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            string Gname = null;

            foreach (ManagementObject moGraphicsCard in mosGraphicsCard.Get())
            {
                if (moGraphicsCard["name"] != null)
                {
                    Gname = moGraphicsCard["name"].ToString();

                }

            }
            return Gname;
        }

        // Uses System.Management to send back GPU count
        private int GetGPUCount()
        {
            var searcher = new ManagementObjectSearcher("select * from Win32_VideoController");
            return searcher.Get().Count;
        }

        // Used to enable or disable the processor
        private void cpu_toggle_Click(object sender, MouseButtonEventArgs e)
        {
            if (mc.cpuenabled)
            {
                mc.cpuenabled = false;
                cpu_toggle.Source = new BitmapImage(new Uri("/Resources/light_off.png", UriKind.Relative));
            }

            else
            {
                mc.cpuenabled = true;
                cpu_toggle.Source = new BitmapImage(new Uri("/Resources/light_on.png", UriKind.Relative));
            }
        }

        // Used to enable or disable the GPU
        private void gpu_toggle_Click(object sender, MouseButtonEventArgs e)
        {
            if (mc.gpuenabled)
            {
                mc.gpuenabled = false;
                gpu_toggle.Source = new BitmapImage(new Uri("/Resources/light_off.png", UriKind.Relative));
            }

            else
            {
                mc.gpuenabled = true;
                gpu_toggle.Source = new BitmapImage(new Uri("/Resources/light_on.png", UriKind.Relative));
            }
        }

        // Button used to install XMRig to machine
        private async void installXMRig(object sender, MouseButtonEventArgs e)
        {
            try
            {
                await dc.downloadRelease("https://github.com/xmrig/xmrig/releases/download/" + (await dc.findLatest("xmrig", "xmrig")) + "/xmrig-" + (await dc.findLatest("xmrig", "xmrig")).Substring(1) + "-msvc-win64.zip", "xmrig.zip", null);
                xmrig_info_label.Content = "Installed";
            }

            catch (Exception)
            {
                MessageBox.Show("It appears have already installed this software or are experiencing connection issues. Please try again later.");
            }
        }

        // Button used to install Gminer to machine
        private async void installGminer(object sender, MouseButtonEventArgs e)
        {
            try
            {
                await dc.downloadRelease("https://github.com/develsoftware/GMinerRelease/releases/download/" + (await dc.findLatest("develsoftware", "GMinerRelease")) + "/gminer_" + (await dc.findLatest("develsoftware", "GMinerRelease")).Replace('.', '_') + "_windows64.zip", "gminer.zip", "gminer");
                gminer_info_label.Content = "Installed";
            }

            catch (Exception)
            {
                MessageBox.Show("It appears have already installed this software or are experiencing connection issues. Please try again later.");
            }
        }

        // Button used to install Trex to machine
        private async void installTrex(object sender, MouseButtonEventArgs e)
        {
            try
            {
                await dc.downloadRelease("https://github.com/trexminer/T-Rex/releases/download/" + (await dc.findLatest("trexminer", "T-Rex")) + "/t-rex-" + (await dc.findLatest("trexminer", "T-Rex")) + "-win.zip", "trex.zip", "trex");
                trex_info_label.Content = "Installed";
            }

            catch (Exception)
            {
                MessageBox.Show("It appears have already installed this software or are experiencing connection issues. Please try again later.");
            }
        }

        // Button used to install Wildrig to machine
        private async void installWildrig(object sender, MouseButtonEventArgs e)
        {
            try
            {
                await dc.downloadRelease("https://github.com/andru-kun/wildrig-multi/releases/download/" + (await dc.findLatest("andru-kun", "wildrig-multi")) + "/wildrig-multi-windows-" + (await dc.findLatest("andru-kun", "wildrig-multi")) + ".7z", "wildrig.7z", "wildrig");
                wildrig_info_label.Content = "Installed";
            }

            catch (Exception)
            {
                MessageBox.Show("It appears have already installed this software or are experiencing connection issues. Please try again later.");
            }
        }

        // Button used to install Nanominer to machine
        private async void installNano(object sender, MouseButtonEventArgs e)
        {
            try
            {
                await dc.downloadRelease("https://github.com/nanopool/nanominer/releases/download/" + (await dc.findLatest("nanopool", "nanominer")) + "/nanominer-windows-" + (await dc.findLatest("nanopool", "nanominer")).Substring(1) + ".zip", "nanominer.zip", null);
                nanominer_info_label.Content = "Installed";
            }

            catch (Exception)
            {
                MessageBox.Show("It appears have already installed this software or are experiencing connection issues. Please try again later.");
            }
        }

        private async void installCG(object sender, MouseButtonEventArgs e)
        {

            try
            {
                await dc.downloadRelease("http://files.npackd.org/cgminer/cgminer-4.9.2.7z", "cgminer.7z", "cgminer");
                cgminer_info_label.Content = "Installed";
            }

            catch (Exception ex)
            {
                MessageBox.Show("It appears have already installed this software or are experiencing connection issues. Please try again later." + ex);
            }
        }
    }
}
