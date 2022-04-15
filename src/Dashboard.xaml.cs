using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Saltyminer.Mining;

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
        private apiControl api;

        // Dashboard initialization
        public Dashboard()
        {
            mc = new mainControl();
            dc = new downloadControl();
            api = new apiControl();

            InitializeComponent();
            UpdateInformation();
        }

        // Shuts down application when called
        private void quitApp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        // Minimizes application when called
        private void minimizeApp(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        // Used to drag the window
        private void drag_window(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
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

        // Method used to install latest XMRig version when app first installed
        private async void installXMRig()
        {
            try
            {
                await dc.DownloadRelease("https://github.com/xmrig/xmrig/releases/download/v6.16.2/xmrig-6.16.2-msvc-win64.zip", "xmrig.zip", null);
            }

            catch (Exception)
            {
                Debug.WriteLine("It appears have already installed this software or are experiencing connection issues. Please try again later.");
            }
        }

        // Method used to install latest TRex version when app first installed
        private async void installRex()
        {
            try
            {
                await dc.DownloadRelease("https://github.com/trexminer/T-Rex/releases/download/0.25.2/t-rex-0.25.2-win.zip", "trex.zip", "trex");
            }

            catch (Exception)
            {
                Debug.WriteLine("It appears have already installed this software or are experiencing connection issues. Please try again later.");
            }
        }

        // Called on startup and used to identify model and load presets
        public void UpdateInformation()
        {
            if (!Directory.Exists("trex"))
            {
                installRex();
            }

            if (!Directory.Exists("xmrig-6.16.2"))
            {
                installXMRig();
            }

            detdevice_list.Content = SendBackProcessorName() + "\n" + SendBackMainGraphicsName();
            gpu_num.Content = GetGPUCount();
        }
    }
}