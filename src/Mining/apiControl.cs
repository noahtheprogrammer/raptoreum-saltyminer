using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Saltyminer.Mining
{
    public class apiControl
    {
        private WebClient wc = new WebClient();
        public dynamic trexinfo;
        public dynamic xmriginfo;

        // Used to connect to the Trex API
        public void LoadTrexAPI()
        {
            string trexjson = wc.DownloadString("http://127.0.0.1:4067/summary");
            trexinfo = JsonConvert.DeserializeObject(trexjson);
        }

        // Used to connect to the XMRig API
        public void LoadXMRigAPI()
        {
            string xmrigjson = wc.DownloadString("http://127.0.0.1:4066/2/summary");
            xmriginfo = JsonConvert.DeserializeObject(xmrigjson);
        }
    }
}
