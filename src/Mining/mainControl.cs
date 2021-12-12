using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saltyminer.Mining
{
    public class mainControl
    {
        // Bools used to determine whether the CPU or GPU are able to mine
        public bool cancpumine = false;
        public bool cangpumine = false;

        // Bools used to determine whether the CPU and GPU are actually mining
        public bool iscpumining = false;
        public bool isgpuming = false;

        // Used to determine what CPU or GPU software is currently being used
        public string cpusoftware;
        public string gpusoftware;
    }
}
