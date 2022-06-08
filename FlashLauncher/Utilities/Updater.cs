using HabboLauncher.Json;
using Newtonsoft.Json;
using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;

namespace HabboLauncher
{
    public class Updater
    {
        private Versions versionCache;
        private ClientUrls lastCheckData;
        private readonly WebClient webClient = new();

        public Installation FlashInstall =>
            versionCache.Installations.FirstOrDefault(i => i.Client == "air" && i.Version == versionCache.LastCheck.Air.Version);
        public Installation UnityInstall => 
            versionCache.Installations.FirstOrDefault(i => i.Client == "unity" && i.Version == versionCache.LastCheck.Unity.Version);

        public string LastCheckFlashUrl => 
            new Uri(lastCheckData.FlashWindows).Segments[5].TrimEnd('/');
        public string LastCheckUnityUrl => 
            new Uri(lastCheckData.UnityWindows).Segments[5].TrimEnd('/');

        public Updater()
        {
            webClient.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/90.0.4430.85 Safari/537.36";
            LoadVersionCache();
        }

        public UpdateResult CheckForUpdate()
        {
            try {
                var data = webClient.DownloadString("https://www.habbo.com/gamedata/clienturls");
                lastCheckData = JsonConvert.DeserializeObject<ClientUrls>(data);

                if (FlashInstall == null || UnityInstall == null)
                    return new UpdateResult(FlashInstall == null, UnityInstall == null, true);

                if (!Directory.Exists(FlashInstall.Path) || !Directory.Exists(UnityInstall.Path))
                {
                    return new UpdateResult(!Directory.Exists(FlashInstall.Path), !Directory.Exists(UnityInstall.Path), true);
                }

                return new UpdateResult(lastCheckData.FlashWindowsVersion != versionCache.LastCheck.Air.Version,
                    lastCheckData.UnityWindowsVersion != versionCache.LastCheck.Unity.Version);
            } catch (Exception ex) {
                return new UpdateResult(false, false);
            }
        }

        public void DownloadAirClient()
        {
            var extractedPath = Path.Combine(Program.AppCacheDir, "downloads", "air", lastCheckData.FlashWindowsVersion);

            DownloadClient(lastCheckData.FlashWindows,
                Path.Combine(Program.AppCacheDir, "downloads", "air", "HabboWin.zip"),
                extractedPath);

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
