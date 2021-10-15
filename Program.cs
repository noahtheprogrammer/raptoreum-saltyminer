using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace salty
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        // Used to import gdi32.dll for font installation
        [DllImport("gdi32.dll", EntryPoint = "AddFontResourceW", SetLastError = true)]
        public static extern int AddFontResource([In][MarshalAs(UnmanagedType.LPWStr)] string lpFileName);

        [STAThread]
        static void Main()
        {
            AddFontResource(Application.StartupPath + "roboto_medium.ttf");
            Thread.Sleep(2000);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new saltyminer());
        }
    }
}
