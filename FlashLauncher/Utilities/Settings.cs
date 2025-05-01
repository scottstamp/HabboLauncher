using Newtonsoft.Json;
using System.IO;

namespace HabboLauncher
{
    public class Settings
    {
        public string Lang { get; set; } = "en";

        public bool LaunchGEarth { get; set; } = false;
        public string GEarthPath { get; set; } = @"C:\Users\scott\Downloads\G-Earth-1.4.1-Windows_64bit\G-Earth.exe";
        public string GEarthOriginsPath { get; set; } = @"C:\Users\Thauan\Downloads\G-Earth-1.5.4-beta-15\G-Earth.exe";
        public bool IgnoreClientUpdates { get; set; } = false;
        public string LastLaunched { get; set; } = "air";
        public bool AutoLaunch { get; set; } = false;
        public int AutoLaunchDelay { get; set; } = 5;
        public int DefaultOriginsServer { get; set; } = 0;
        public bool PromptSelfUpdate { get; set; } = true;
        public bool OriginsXL { get; set; } = false;
        public bool IgnoreClientUpdatesOrigins { get; set; } = false;
        public bool IgnoreClientUpdatesHabbox { get; set; } = false;
        public bool IgnoreClientUpdatesFlash { get; set; } = false;
        public bool IgnoreClientUpdatesUnity { get; set; } = false;

        public static Settings LoadSettings()
        {
            var path = Path.Combine(Program.AppCacheDir, "settings.json");
            if (File.Exists(path))
            {
                var json = File.ReadAllText(Path.Combine(Program.AppCacheDir, "settings.json"));
                var settings = JsonConvert.DeserializeObject<Settings>(json);
                settings.Lang ??= "en";
                settings.LastLaunched ??= "air";

                return settings;
            }
            else
            {
                var settings = new Settings();
                settings.SaveSettings();
                return settings;
            }
        }

        public void SaveSettings()
        {
            File.WriteAllText(Path.Combine(Program.AppCacheDir, "settings.json"), JsonConvert.SerializeObject(this));
        }
    }
}
