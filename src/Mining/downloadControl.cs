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
                d_client.DownloadFileCompleted += new AsyncCompletedEventHandler(DecompressInstall);
                d_client.DownloadFileAsync(new Uri(link), AppDomain.CurrentDomain.BaseDirectory + file);
            }

            // Method used to decompress files
            void DecompressInstall(object sender, AsyncCompletedEventArgs e)
            {
                // Used to decompress all file folders
                Process decom = new Process();
                decom.StartInfo.FileName = "7za.exe";
                decom.StartInfo.Arguments = "e " + file + " -o" + folder;
                decom.StartInfo.CreateNoWindow = true;
                decom.Start();
                decom.WaitForExit();

                // Removes leftover download
                File.Delete(file);
            }

            return Task.CompletedTask;
        }

        // Used to determine whether to display installed status or not
        public string checkInstalls(string folder)
        {
            if (Directory.Exists(folder))
            {
                return "Installed";
            }

            else
            {
                return "Not installed";
            }
        }
    }
}
