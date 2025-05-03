using HabboLauncher.Json;
using Newtonsoft.Json;
using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HabboLauncher
{
    public class Updater
    {
        private Versions versionCache;
        public ClientUrls lastCheckData;
        private ClientUrls lastCheckDataHabbox;
        private ClientUrls lastCheckDataShockwave;
        private readonly WebClient webClient = new();

        public Installation FlashInstall =>
            versionCache.Installations.FirstOrDefault(i => i.Client == "air" && i.Version == versionCache.LastCheck.Air.Version);
        public Installation UnityInstall => 
            versionCache.Installations.FirstOrDefault(i => i.Client == "unity" && i.Version == versionCache.LastCheck.Unity.Version);
        public Installation HabboxInstall =>
            versionCache.Installations.FirstOrDefault(i => i.Client == "habbox" && i.Version == versionCache.LastCheck.Habbox.Version);
        public Installation ShockwaveInstall =>
            versionCache.Installations.FirstOrDefault(i => i.Client == "shockwave" && i.Version == versionCache.LastCheck.Shockwave.Version);

        public string LastCheckFlashUrl => 
            new Uri(lastCheckData.FlashWindows).Segments[5].TrimEnd('/');
        public string LastCheckUnityUrl => 
            new Uri(lastCheckData.UnityWindows).Segments[5].TrimEnd('/');
        public string LastCheckHabboxUrl =>
            new Uri(lastCheckDataHabbox.UnityWindows).Segments[5].TrimEnd('/');
        public string LastCheckShockwaveUrl =>
            new Uri(lastCheckDataShockwave.ShockwaveWindows).Segments[5].TrimEnd('/');

        public Updater()
        {
            webClient.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36";
            //webClient.Proxy = new WebProxy("localhost:8888");
            LoadVersionCache();
        }

        public UpdateResult CheckForUpdate()
        {
            try {
                var data = webClient.DownloadString("https://www.habbo.com/gamedata/clienturls");
                lastCheckData = JsonConvert.DeserializeObject<ClientUrls>(data);

                webClient.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36";
                var habboxData = webClient.DownloadString("https://www.habbox.game/gamedata/clienturls");
                lastCheckDataHabbox = JsonConvert.DeserializeObject<ClientUrls>(habboxData);

                webClient.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/135.0.0.0 Safari/537.36";
                var ohabboData = webClient.DownloadString("https://origins.habbo.com/gamedata/clienturls");
                lastCheckDataShockwave = JsonConvert.DeserializeObject<ClientUrls>(ohabboData);

                if (FlashInstall == null || UnityInstall == null || HabboxInstall == null || ShockwaveInstall == null)
                    return new UpdateResult(FlashInstall == null, UnityInstall == null, HabboxInstall == null, ShockwaveInstall == null, true);


                if (!Directory.Exists(FlashInstall.Path) || !Directory.Exists(UnityInstall.Path) || !Directory.Exists(HabboxInstall.Path) || !Directory.Exists(ShockwaveInstall.Path))
                {
                    return new UpdateResult(!Directory.Exists(FlashInstall.Path), !Directory.Exists(UnityInstall.Path), !Directory.Exists(HabboxInstall.Path), !Directory.Exists(ShockwaveInstall.Path), true);
                }


                return new UpdateResult(lastCheckData.FlashWindowsVersion != versionCache.LastCheck.Air.Version,
                    lastCheckData.UnityWindowsVersion != versionCache.LastCheck.Unity.Version, lastCheckDataHabbox.UnityWindowsVersion != versionCache.LastCheck.Habbox.Version, lastCheckDataShockwave.ShockwaveWindowsVersion != versionCache.LastCheck.Shockwave.Version);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return new UpdateResult(false, false, false, false, true);
            }
        }

        public void DownloadAirClient()
        {
            var extractedPath = Path.Combine(Program.AppCacheDir, "downloads", "air", lastCheckData.FlashWindowsVersion);

            DownloadClient(lastCheckData.FlashWindows,
                Path.Combine(Program.AppCacheDir, "downloads", "air", "HabboWin.zip"),
                extractedPath);

            var swfPath = Path.Combine(extractedPath, "HabboAir.swf");
            var backupSwfFile = Path.Combine(extractedPath, "HabboAir.original.swf");

            if (File.Exists(swfPath))
            {
                File.Copy(swfPath, backupSwfFile);
            }

            versionCache.Installations.Add(new Installation
            {
                Version = lastCheckData.FlashWindowsVersion,
                Path = extractedPath,
                Client = "air",
                LastModified = DateTimeOffset.Now.ToUnixTimeSeconds()
            });

            versionCache.LastCheck.Air = new CheckInfo
            {
                Version = lastCheckData.FlashWindowsVersion,
                Path = extractedPath
            };

            if(!string.IsNullOrWhiteSpace(Program.Settings.CustomSWFLink))
            {
                var customSwfPath = Path.Combine(Program.AppCacheDir, "HabboAir.custom.swf");
                var newInstallationPath = Path.Combine(extractedPath, "HabboAir.custom.swf");
                if (File.Exists(customSwfPath))
                {
                    File.Copy(customSwfPath, newInstallationPath);
                }
            }

            SaveVersionCache();


        }

        public void DownloadUnityClient()
        {
            var extractedPath = Path.Combine(Program.AppCacheDir, "downloads", "unity", lastCheckData.UnityWindowsVersion);

            DownloadClient(lastCheckData.UnityWindows,
                Path.Combine(Program.AppCacheDir, "downloads", "unity", "StandaloneWindowshabbo2020-global-prod.app.zip"),
                extractedPath);

            versionCache.Installations.Add(new Installation
            {
                Version = lastCheckData.UnityWindowsVersion,
                Path = extractedPath,
                Client = "unity",
                LastModified = DateTimeOffset.Now.ToUnixTimeSeconds()
            });

            versionCache.LastCheck.Unity = new CheckInfo
            {
                Version = lastCheckData.UnityWindowsVersion,
                Path = extractedPath
            };

            SaveVersionCache();
        }

        public void DownloadHabboxClient()
        {
            var extractedPath = Path.Combine(Program.AppCacheDir, "downloads", "habbox", lastCheckDataHabbox.UnityWindowsVersion);

            DownloadClient(lastCheckDataHabbox.UnityWindows,
                Path.Combine(Program.AppCacheDir, "downloads", "habbox", "StandaloneWindowshabbo2020-global-prod.app.zip"),
                extractedPath);

            versionCache.Installations.Add(new Installation
            {
                Version = lastCheckDataHabbox.UnityWindowsVersion,
                Path = extractedPath,
                Client = "habbox",
                LastModified = DateTimeOffset.Now.ToUnixTimeMilliseconds()
            });

            versionCache.LastCheck.Habbox = new CheckInfo
            {
                Version = lastCheckDataHabbox.UnityWindowsVersion,
                Path = extractedPath
            };

            SaveVersionCache();
        }

        public void DownloadShockwaveClient()
        {
            var extractedPath = Path.Combine(Program.AppCacheDir, "downloads", "shockwave", lastCheckDataShockwave.ShockwaveWindowsVersion);

            DownloadClient(lastCheckDataShockwave.ShockwaveWindows,
                Path.Combine(Program.AppCacheDir, "downloads", "shockwave", "Origins-latest.zip"),
                extractedPath);

            versionCache.Installations.Add(new Installation
            {
                Version = lastCheckDataShockwave.ShockwaveWindowsVersion,
                Path = extractedPath,
                Client = "shockwave",
                LastModified = DateTimeOffset.Now.ToUnixTimeMilliseconds()
            });

            versionCache.LastCheck.Shockwave = new CheckInfo
            {
                Version = lastCheckDataShockwave.ShockwaveWindowsVersion,
                Path = extractedPath
            };

            SaveVersionCache();
        }
        private void DownloadClient(string url, string outputFile, string extractedPath)
        {
            Directory.CreateDirectory(extractedPath);

            webClient.DownloadFile(url, outputFile);

            if (Directory.Exists(extractedPath))
                Directory.Delete(extractedPath, true);

            Directory.CreateDirectory(extractedPath);
            ZipFile.ExtractToDirectory(outputFile, extractedPath);
            File.Delete(outputFile);
        }

        public async Task DownloadCustomSWF(string swfLink)
        {
            var latestInstallationPath = Path.Combine(Program.AppCacheDir, "downloads", "air", lastCheckData.FlashWindowsVersion);
            var swfFilePath = Path.Combine(Program.AppCacheDir, "HabboAir.custom.swf");

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    await webClient.DownloadFileTaskAsync(swfLink, swfFilePath);
                }

                if(File.Exists(swfFilePath)) 
                    File.Copy(swfFilePath, Path.Combine(latestInstallationPath, "HabboAir.custom.swf"));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Downloading SWF: {ex.Message}");
            }
        }

        public async Task CheckForSwfUpdates()
        {
            var swfLink = Program.Settings.CustomSWFLink;
            var customSwfFile = Path.Combine(Program.AppCacheDir, "HabboAir.custom.swf");

            try
            {
                string localFileHash = ComputeFileHash(customSwfFile);

                string remoteFileHash = await GetFileHashFromUrl(swfLink);

                if (localFileHash != remoteFileHash)
                {
                    DialogResult result = MessageBox.Show(
                        $"A new update was found for your Custom SWF \n\n{Program.Settings.CustomSWFLink}\n\nDo you want to download it? (AT YOUR OWN RISK)",
                        "SWF Update",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        await DownloadCustomSWF(swfLink);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while checking for SWF updates: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string ComputeFileHash(string filePath)
        {
            if (!File.Exists(filePath))
                return null;

            using (var sha256 = SHA256.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    byte[] hash = sha256.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant(); 
                }
            }
        }

        public async Task<string> GetFileHashFromUrl(string url)
        {
            using (var httpClient = new HttpClient())
            {
                byte[] fileBytes = await httpClient.GetByteArrayAsync(url);
                using (var sha256 = SHA256.Create())
                {
                    byte[] hash = sha256.ComputeHash(fileBytes);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        private string versionsPath = Path.Combine(Program.AppCacheDir, "versions.json");

        private void LoadVersionCache()
        {
            if (File.Exists(versionsPath))
            {
                versionCache = JsonConvert.DeserializeObject<Versions>(File.ReadAllText(versionsPath));
            }
            else
            {
                versionCache = new Versions();
            }
        }

        private void SaveVersionCache()
        {
            versionCache.LastCheck.Time = DateTimeOffset.Now.ToUnixTimeSeconds();
            File.WriteAllText(Path.Combine(Program.AppCacheDir, "versions.json"), JsonConvert.SerializeObject(versionCache, Formatting.Indented));
        }

    }
}
