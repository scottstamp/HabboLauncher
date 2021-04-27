﻿using System;
using System.Diagnostics;
using System.IO;
using System.Web;
using System.Windows.Forms;

namespace HabboLauncher
{
    class Program
    {
        public static readonly string AppDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Programs", "habbo-electron-launcher");
        public static readonly string AppCacheDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Habbo Launcher");
        
        public static Updater Updater = new();
        public static Settings Settings = Settings.LoadSettings();

        [STAThread]
        static void Main(string[] args)
        {
            if (!CheckOriginalDirectories()) return;
            if (!CheckExecutingDirectory()) return;
            ShowUpdatePrompt(Updater.CheckForUpdate());
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrm(args));
        }

        static bool CheckOriginalDirectories()
        {
            if (!Directory.Exists(AppDir) || !Directory.Exists(AppCacheDir))
            {
                MessageBox.Show("Original Habbo Launcher installation directory was not found. Please reinstall the launcher from Habbo or our GitHub page." +
                    "\r\n\r\nhttps://github.com/scottstamp/HabboLauncher/releases/latest");
                return false;
            }

            return true;
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
                    if (!File.Exists(Path.Combine(AppDir, "Habbo Launcher.exe.old")))
                        File.Move(Path.Combine(AppDir, "Habbo Launcher.exe"), Path.Combine(AppDir, "Habbo Launcher.exe.old"));

                    File.Copy(Process.GetCurrentProcess().MainModule.FileName, Path.Combine(AppDir, "Habbo Launcher.exe"), true);
                    MessageBox.Show("Copied successfully.", "HabboLauncher ~ Info", MessageBoxButtons.YesNo);
                    return false;
                }
            }

            return true;
        }

        static void ShowUpdatePrompt(UpdateResult result)
        {
            if (result.FlashUpdate && result.UnityUpdate)
            {
                var message = "Updates for the both client versions are available. Would you like to download them?";

                if (result.Required)
                    message = "Existing client files were not found, please click yes to download client files and continue.";

                if (MessageBox.Show(message +
                    $"\r\n\r\nUnity: {Updater.LastCheckUnityUrl}" +
                    $"\r\nFlash: {Updater.LastCheckFlashUrl}",
                    "HabboLauncher ~ Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Updater.DownloadAirClient();
                    Updater.DownloadUnityClient();
                }
            }
            else if (result.FlashUpdate)
            {
                var message = "An update for the AIR (Classic) client is available. Would you like to download it?";

                if (result.Required)
                    message = "Existing client files were not found, please click yes to download client files and continue.";

                if (MessageBox.Show(message +
                    $"\r\n\r\nFlash: {Updater.LastCheckFlashUrl}",
                    "HabboLauncher ~ Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Updater.DownloadAirClient();
                }
            }
            else if (result.UnityUpdate)
            {
                var message = "An update for the Unity (Modern) client is available. Would you like to download it?";

                if (result.Required)
                    message = "Existing client files were not found, please click yes to download client files and continue.";

                if (MessageBox.Show(message +
                    $"\r\n\r\nUnity: {Updater.LastCheckUnityUrl}",
                    "HabboLauncher ~ Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Updater.DownloadUnityClient();
                }
            }
        }
    }
}