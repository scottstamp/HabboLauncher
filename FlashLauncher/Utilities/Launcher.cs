using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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

    }
}
