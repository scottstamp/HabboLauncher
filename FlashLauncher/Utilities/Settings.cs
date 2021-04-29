using Newtonsoft.Json;
using System.IO;

namespace HabboLauncher
{
    public class Settings
    {
        public string Lang { get; set; } = "en";

        public bool LaunchGEarth { get; set; } = false;
        public string GEarthPath { get; set; } = @"C:\Users\scott\Downloads\G-Earth-1.4.1-Windows_64bit";

        public string LastLaunched { get; set; } = "air";
        public bool AutoLaunch { get; set; } = false;
        public int AutoLaunchDelay { get; set; } = 5;

        public bool PromptSelfUpdate { get; set; } = true;

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
