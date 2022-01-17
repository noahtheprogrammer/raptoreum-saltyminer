using System;
using System.Net;
using System.Threading.Tasks;
using Octokit;
using System.Diagnostics;
using System.Linq;
using System.IO;
using System.ComponentModel;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Saltyminer.Mining
{
    public class downloadControl
    {
        // WebClient used to download new releases
        WebClient d_client = new WebClient();

        // Array used to hold info loaded on machine
        // Below display what spot in the array each miner must specify
        // XMRig[0] cpuminer-multi[1] Wildrig[2] Nanominer[3] Trex[4] Redminer[5] NBMiner[6] Gminer[7] lolMiner[8]
        public string[] currentInstalls;

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

                // Unzips using System.IO
                if (file.Contains(".zip"))
                {
                    System.IO.Compression.ZipFile.ExtractToDirectory(AppDomain.CurrentDomain.BaseDirectory + file, AppDomain.CurrentDomain.BaseDirectory + folder);
                }

                // Used for unique extensions that only 7z can understand
                else
                {
                    Process decom = new Process();
                    decom.StartInfo.FileName = "7za.exe";
                    decom.StartInfo.Arguments = "e " + file + " -o" + folder;
                    decom.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    decom.Start();
                    decom.WaitForExit();
                }

                // Removes leftover download
                File.Delete(file);
            }

            return Task.CompletedTask;
        }

        // Task that is used to determine latest release for miners
        public async Task<string> findLatest(string owner, string repository)
        {
            var client = new GitHubClient(new ProductHeaderValue("saltyminer-bot" + generateString()));
            var releases = await client.Repository.Release.GetAll(owner, repository);
            var latest = releases[0];
            Debug.Write(latest.Name);
            return latest.TagName;
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
                return "Latest version not installed";
            }
        }

        // Returns a random string for user agents
        public static string generateString(int length = 16)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            var random = new Random();
            var randomString = new string(Enumerable.Repeat(chars, length)
                                                    .Select(s => s[random.Next(s.Length)]).ToArray());
            return randomString;
        }

        // Saves string array of installs into file
        public void saveCurrentinstall()
        {
            File.WriteAllLines("currentVersions.txt", currentInstalls);
        }

        // Loads string array of installs into application
        public void loadCurrentinstall()
        {
            using (StreamReader sr = new StreamReader("currentVersions.txt"))
            {
                currentInstalls = new[] { sr.ReadToEnd() };
            }
        }
    }
}


// Serializable class used to save miner versions currently stored on the machine
[Serializable]
public class savedDownload
{
    public string[] savedInstalls;
}
