using System;
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
using System.Windows.Shapes;
using Saltyminer.Mining;

namespace Saltyminer
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Configs : Window
    {

        // Classes used to retrieve information on mining
        private mainControl mc;

        public Configs()
        {
            mc = new mainControl();
            InitializeComponent();
        }

        // Hides the window when called
        private void exit_img_Click(object sender, MouseButtonEventArgs e)
        {
            Hide();
        }

        // Used to drag the window
        private void drag_window(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        // Updates the static CPUPARAMS variable
        private void cpu_extraparams_TextChanged(object sender, TextChangedEventArgs e)
        {
            mainControl.CPUPARAMS = cpu_extraparams.Text;
        }

        // Updates the static CPUADDRESS variable
        private void cpu_address_TextChanged(object sender, TextChangedEventArgs e)
        {
            mainControl.CPUADDRESS = cpu_address.Text;
        }

        // Updates the static CPUALGO variable
        private void cpu_algo_TextChanged(object sender, TextChangedEventArgs e)
        {
            mainControl.CPUALGO = cpu_algo.Text;
        }

        // Updates the static CPUSOFTWARE variable and converts input into readable string
        private void cpu_software_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mainControl.CPUSOFTWARE = (cpu_software.SelectedItem as ListBoxItem).Content.ToString();
        }

        // Updates the static CPUPOOL variable and converts input into a readable string
        private void cpu_pool_TextChanged(object sender, TextChangedEventArgs e)
        {
            mainControl.CPUPOOL = cpu_pool.Text;
        }

        private void test_handler(object sender, MouseButtonEventArgs e)
        {
            mc.runCPUMiner();
        }
    }
}
