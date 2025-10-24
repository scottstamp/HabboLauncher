using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HabboLauncher
{
    class Program
    {
        public static readonly string AppDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Programs", "habbo-electron-launcher");
        public static readonly string AppCacheDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Habbo Launcher");

        //public static readonly string AppDir = Path.Combine("D:\\", "Programs", "habbo-electron-launcher");
        //public static readonly string AppCacheDir = Path.Combine("D:\\", "Programs", "habbo-electron-launcher", "Habbo Launcher");

        public static Updater Updater;
        public static Settings Settings;

        [STAThread]
        static void Main(string[] args)
        {

            CreateOriginalDirectories();
            
            Updater = new();
            Settings = Settings.LoadSettings();

            if (!CheckExecutingDirectory()) return;
            if (!Settings.IgnoreClientUpdates)
                ShowUpdatePrompt(Updater.CheckForUpdate());

            if(Settings.UseCustomSwf && !string.IsNullOrWhiteSpace(Settings.CustomSWFLink))
            {
                Task.Run(async () =>
                {
                   await Updater.CheckForSwfUpdates();
                });
            }
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrm(args));
        }

        static void CreateOriginalDirectories()
        {
            if (!Directory.Exists(AppDir)) Directory.CreateDirectory(AppDir);
            if (!Directory.Exists(AppCacheDir)) Directory.CreateDirectory(AppCacheDir);
        }

        public static void CopyDirectory(string sourceDir, string targetDir)
        {
            foreach (var dir in Directory.GetDirectories(sourceDir, "*", SearchOption.AllDirectories))
            {
                string relPath = dir.Substring(sourceDir.Length).TrimStart(Path.DirectorySeparatorChar);
                Directory.CreateDirectory(Path.Combine(targetDir, relPath));
            }

            foreach (var file in Directory.GetFiles(sourceDir, "*.*", SearchOption.AllDirectories))
            {
                string relPath = file.Substring(sourceDir.Length).TrimStart(Path.DirectorySeparatorChar);
                string destFile = Path.Combine(targetDir, relPath);
                File.Copy(file, destFile, true);
            }
        }

        static bool CheckExecutingDirectory()
        {
            if (Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) == AppDir)
            {
                RegUtil.RegisterProtocol(Process.GetCurrentProcess().MainModule.FileName);
            }
            else
            {
                var result = MessageBox.Show($"HabboLauncher was executed outside of \"{AppDir}\", copy to this folder?", "HabboLauncher ~ Info", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var currentPath = Process.GetCurrentProcess().MainModule.FileName;
                    var installPath = Path.Combine(AppDir, "Habbo Launcher.exe");

                    if (!File.Exists(Path.Combine(AppDir, "Habbo Launcher.exe.old")) && File.Exists(installPath))
                        File.Move(Path.Combine(AppDir, "Habbo Launcher.exe"), Path.Combine(AppDir, "Habbo Launcher.exe.old"));
                    
                    File.Copy(currentPath, installPath, File.Exists(installPath));

                    RegUtil.RegisterProtocol(Path.Combine(AppDir, "Habbo Launcher.exe"));
                    MessageBox.Show("Copied successfully. You may now launch Habbo from the website as normal.", "HabboLauncher ~ Info", MessageBoxButtons.OK);
                    return false;
                }
            }

            return true;
        }

        static void ShowUpdatePrompt(UpdateResult result)
        {
            if (Settings.IgnoreClientUpdates && !result.Required) return;

            bool needFlash = result.FlashUpdate && (!Settings.IgnoreClientUpdatesFlash || result.Required);
            bool needUnity = result.UnityUpdate && (!Settings.IgnoreClientUpdatesUnity || result.Required);
            bool needHabbox = result.HabboxUpdate && (!Settings.IgnoreClientUpdatesHabbox || result.Required);
            bool needShockwave = result.ShockwaveUpdate && (!Settings.IgnoreClientUpdatesOrigins || result.Required);

            if (!needFlash && !needUnity && !needHabbox && !needShockwave)
                return;

            var message = result.Required 
                ? "Existing client files were not found, please click yes to download client files and continue."
                : "Updates are available for the following clients. Would you like to download them?";

            var details = "";
            if (needFlash) details += $"\r\n\r\nFlash (AIR): {Updater.LastCheckFlashUrl}";
            if (needUnity) details += $"\r\n\r\nUnity: {Updater.LastCheckUnityUrl}";
            if (needHabbox) details += $"\r\n\r\nHabbox: {Updater.LastCheckHabboxUrl}";
            if (needShockwave) details += $"\r\n\r\nOrigins: {Updater.LastCheckShockwaveUrl}";

            if (MessageBox.Show(message + details, "HabboLauncher ~ Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (needFlash) Updater.DownloadAirClient();
                if (needUnity) Updater.DownloadUnityClient();
                if (needHabbox) Updater.DownloadHabboxClient();
                if (needShockwave) Updater.DownloadShockwaveClient();
            }
        }
    }
}