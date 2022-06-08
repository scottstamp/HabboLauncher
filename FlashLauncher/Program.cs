﻿using System;
using System.Diagnostics;
using System.IO;
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
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrm(args));
        }

        static void CreateOriginalDirectories()
        {
            if (!Directory.Exists(AppDir)) Directory.CreateDirectory(AppDir);
            if (!Directory.Exists(AppCacheDir)) Directory.CreateDirectory(AppCacheDir);
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