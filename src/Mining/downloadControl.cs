using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;

namespace Saltyminer.Mining
{
    public class downloadControl
    {
        public void downloadRelease(string link, string file)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile(link, AppDomain.CurrentDomain.BaseDirectory + file);
            }
        }
    }
}