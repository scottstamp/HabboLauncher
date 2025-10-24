using HabboLauncher.Utilities;
using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace HabboLauncher
{
    public class Launcher
    {
        private static readonly string appXmlPath = Path.Combine(Program.Updater.FlashInstall.Path, "META-INF", "AIR", "application.xml");

        private static void SetFlashApplicationId(string ticket)
        {
            string avatarId;
            var m = Regex.Match(ticket, @"[a-z0-9\-]+-([0-9]+)", RegexOptions.IgnoreCase);
            if (m.Success)
                avatarId = m.Groups[1].Value;
            else
                avatarId = Guid.NewGuid().ToString("N");

            var doc = new XmlDocument();
            doc.Load(appXmlPath);
            doc["application"]["id"].InnerText = $"com.sulake.habboair.{avatarId}";
            doc["application"]["initialWindow"]["title"].InnerText = $"Habbo";
            doc.Save(appXmlPath);
        }

        public static void ChangeFlashSwf()
        {
            var extractedPath = Path.Combine(Program.AppCacheDir, "downloads", "air", Program.Updater.lastCheckData.FlashWindowsVersion);
            var swfPath = Path.Combine(extractedPath, "HabboAir.swf");
            var backupSwfFile = Path.Combine(extractedPath, "HabboAir.original.swf");
            var customSwfFile = Path.Combine(extractedPath, "HabboAir.custom.swf");

            if (!Program.Settings.UseCustomSwf)
            {
                if (File.Exists(backupSwfFile))
                {
                    File.Copy(backupSwfFile, swfPath, true);
                }
                return;
            }

            if (File.Exists(customSwfFile))
            {
                File.Copy(customSwfFile, swfPath, true);
            }
            
        }

        public static void LaunchFlashClient(string server, string ticket, bool withGEarth = true)
        {
            SetFlashApplicationId(ticket);

            if (withGEarth && File.Exists(Program.Settings.GEarthPath))
            {
                Process.Start(new ProcessStartInfo(Path.GetFileName(Program.Settings.GEarthPath))
                {
                    WorkingDirectory = Path.GetDirectoryName(Program.Settings.GEarthPath),
                    Arguments = "-c flash"
                });

                Task.Delay(1000).Wait();
            }

            Process.Start(new ProcessStartInfo("Habbo.exe")
            {
                WorkingDirectory = Program.Updater.FlashInstall.Path,
                Arguments = $"-server {server} -ticket \"{ticket}\""
            });
        }

        public static void LaunchUnityClient(string server, string ticket)
        {
            Process.Start(new ProcessStartInfo("habbo2020-global-prod.exe")
            {
                WorkingDirectory = Path.Combine(Program.Updater.UnityInstall.Path, "StandaloneWindows"),
                Arguments = $"-server {server} -ticket \"{ticket}\""
            });
        }

        public static void LaunchHabboxClient(string server, string ticket)
        {
            Process.Start(new ProcessStartInfo("habbo2020-global-prod.exe")
            {
                WorkingDirectory = Path.Combine(Program.Updater.HabboxInstall.Path, "StandaloneWindows"),
                Arguments = $"-server {server} -ticket \"{ticket}\""
            });
        }

        public static void LaunchOriginsClient(string server, bool withGEarth = true, bool isXl = false, bool withIntegerScaler = false)
        {
            if (withIntegerScaler)
            {
                try
                {
                    // Only launch if not already running
                    if (!IntegerScalerManager.IsIntegerScalerRunning())
                    {
                        IntegerScalerManager.LaunchIntegerScaler();
                        Task.Delay(1000).Wait();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to launch IntegerScaler: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (withGEarth && File.Exists(Program.Settings.GEarthOriginsPath))
            {
                Process.Start(new ProcessStartInfo(Path.GetFileName(Program.Settings.GEarthOriginsPath))
                {
                    WorkingDirectory = Path.GetDirectoryName(Program.Settings.GEarthOriginsPath),
                    Arguments = "-c origins"
                });

                Task.Delay(1000).Wait();
            }else if (withGEarth && File.Exists(Program.Settings.GEarthPath))
            {
                Process.Start(new ProcessStartInfo(Path.GetFileName(Program.Settings.GEarthPath))
                {
                    WorkingDirectory = Path.GetDirectoryName(Program.Settings.GEarthPath),
                    Arguments = "-c origins"
                });

                Task.Delay(1000).Wait();
            }

            string tempDir = Path.Combine(Path.GetTempPath(), "shockwave-habbo-" + Guid.NewGuid().ToString("N"));
            Directory.CreateDirectory(tempDir);

            string sourceDir = Program.Updater.ShockwaveInstall.Path;
            Program.CopyDirectory(sourceDir, tempDir);

            string xlString = isXl ? "-xl" : "";

            string exePath = Path.Combine(tempDir, $"HabboHotel-o{server}{xlString}.exe");
            if (File.Exists(exePath))
            {
                Process.Start(new ProcessStartInfo(exePath)
                {
                    WorkingDirectory = tempDir,
                    Arguments = ""
                });
            }
            else
            {
                MessageBox.Show($"Executable not found in temp folder: {exePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
