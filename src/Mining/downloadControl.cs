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
        public async Task downloadRelease(string link, string file)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile(link, AppDomain.CurrentDomain.BaseDirectory + file);
                System.IO.Compression.ZipFile.ExtractToDirectory(AppDomain.CurrentDomain.BaseDirectory + file, AppDomain.CurrentDomain.BaseDirectory);
            }
        }

        // Task that is used to determine latest release for miners
        public async Task<string> findLatest(string owner, string repository)
        {
            var client = new GitHubClient(new ProductHeaderValue("saltyminer-bot"));
            var releases = await client.Repository.Release.GetAll(owner, repository);
            var latest = releases[0];
            Debug.Write(latest.Name);
            return latest.TagName;
        }
    }
}