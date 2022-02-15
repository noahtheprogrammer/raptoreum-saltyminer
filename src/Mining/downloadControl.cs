using System;
using System.Net;
using System.Threading.Tasks;
using Octokit;
using System.Diagnostics;
using System.Linq;
using System.IO;
using System.ComponentModel;

namespace Saltyminer.Mining
{
    public class downloadControl
    {
        // WebClient used to download new releases
        WebClient d_client = new WebClient();

        // Used to download latest release of miners
        public Task DownloadRelease(string link, string file, string folder)
        {
            using (d_client)
            {
                d_client.DownloadFileAsync(new Uri(link), AppDomain.CurrentDomain.BaseDirectory + file);
                d_client.DownloadFileCompleted += new AsyncCompletedEventHandler(DecompressInstall);
            }

            // Method used to decompress files
            void DecompressInstall(object sender, AsyncCompletedEventArgs e)
            {
                // Extracts file
                System.IO.Compression.ZipFile.ExtractToDirectory(AppDomain.CurrentDomain.BaseDirectory + file, AppDomain.CurrentDomain.BaseDirectory + folder);

                // Removes leftover download
                File.Delete(file);
            }

            return Task.CompletedTask;
        }
    }
}
