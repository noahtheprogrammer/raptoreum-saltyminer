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

namespace Saltyminer
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Configs : Window
    {
        public Configs()
        {
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
    }
}
