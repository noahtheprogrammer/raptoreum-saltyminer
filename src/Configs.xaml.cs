﻿using System;
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
            mc.configs = this;
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

        // Updates the static CPUADDRESS variable
        private void cpu_address_TextChanged(object sender, TextChangedEventArgs e)
        {
            mc.CPUADDRESS = cpu_address.Text;
        }

        // Updates the static GPUADDRESS variable
        private void gpu_address_TextChanged(object sender, TextChangedEventArgs e)
        {
            mc.GPUADDRESS = gpu_address.Text;
        }

        private void cpu_test_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            mc.runCPUMiner();
        }

        private void gpu_test_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            mc.runGPUMiner();
        }
    }
}
