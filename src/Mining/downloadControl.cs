using System;
using System.Net;
using System.Threading.Tasks;
using Octokit;
using System.Diagnostics;

namespace Saltyminer.Mining
{
    public class downloadControl
    {
        // Used to download latest release of miners
        public void downloadRelease(string link, string file)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile(link, AppDomain.CurrentDomain.BaseDirectory + file);
            }
        }

        // This currently is unable to find the test repo releases and convert them into strings
        // We need it to be called in order to apply the value to a string variable
        // It just gives off compiler errors right now and is worthless
        public string findLatest()
        {
            var client = new GitHubClient(new ProductHeaderValue("saltyminer-bot"));
            var releases = client.Repository.Release.GetAll("octokit", "octokit.net");
            var latest = releases[0];
            Debug.Write(latest.Name);
        }
    }
}