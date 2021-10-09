using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace salty_namespace
{
    public partial class Monitor
    {
        // Used for cpu counter
        PerformanceCounter cpuCounter;

        // Used for timer
        System.Windows.Forms.Timer cpu_timer = new System.Windows.Forms.Timer();

        // Variable to locate saltyminer
        public saltyminer sm;

        public void LoadMonitor()
        {
            // Loads the CPU monitor
            cpuCounter = new PerformanceCounter();
            cpuCounter.CategoryName = "Processor";
            cpuCounter.CounterName = "% Processor Time";
            cpuCounter.InstanceName = "_Total";
            InitTimer();
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
            sm.cpu_usage.Text = await cpu_task;
        }

        // Method to find the CPU resources
        public string getCurrentCpuUsage()
        {
            string value1 = (int)cpuCounter.NextValue() + "%";
            Thread.Sleep(500);
            string value2 = (int)cpuCounter.NextValue() + "%";
            return value2.ToString();
        }
    }
}
