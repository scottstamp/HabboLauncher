using Newtonsoft.Json;
using System.IO;

namespace HabboLauncher
{
    public class Settings
    {
        public string Lang { get; set; } = "en";
        public string LastLaunched { get; set; } = "air";
        public bool AutoLaunch { get; set; } = false;
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
