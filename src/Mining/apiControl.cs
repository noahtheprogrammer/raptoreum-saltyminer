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
        public dynamic msinfo;

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
        
        // Call this to return the estimated reward of a coin with a specific hashrate
        public float findHashrateReward(string symbol, dynamic hashrate) 
        {
            float total = 0;
            string minerstat = wc.DownloadString("https://api.minerstat.com/v2/coins?list=" + symbol);
            msinfo = JsonConvert.DeserializeObject(minerstat);
            total = msinfo.reward * hashrate;
            return total;
        }
    }
}
