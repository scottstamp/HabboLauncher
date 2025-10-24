using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace HabboLauncher.Utilities
{
    public static class IntegerScalerManager
    {
        private static readonly string IntegerScalerDir = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "Habbo Launcher",
            "IntegerScaler"
        );

        private static string GetIntegerScalerExecutableName()
        {
            return Environment.Is64BitOperatingSystem ? "IntegerScaler_x64.exe" : "IntegerScaler_x86.exe";
        }

        private static string GetIntegerScalerPath()
        {
            return Path.Combine(IntegerScalerDir, GetIntegerScalerExecutableName());
        }

        /// <summary>
        /// Gets optimal IntegerScaler arguments based on screen resolution
        /// </summary>
        private static string GetOptimalArguments()
        {
            var primaryScreen = Screen.PrimaryScreen;
            var screenWidth = primaryScreen.Bounds.Width;
            var screenHeight = primaryScreen.Bounds.Height;

            // Configuration for fullscreen integer scaling with auto-enable:
            // -fractional: allows fractional scales to better fill the screen
            // -clipcursor: keeps mouse cursor within game window for immersive experience
            // -bg 0,0,0: black background for proper fullscreen feel
            // -scale 3000: automatically enables scaling after 3 seconds
            var args = "-fractional -clipcursor -bg 0,0,0 -scale 3000";

            return args;
        }

        /// <summary>
        /// Ensures IntegerScaler is extracted to the AppData directory
        /// </summary>
        public static void EnsureIntegerScalerExtracted()
        {
            try
            {
                Directory.CreateDirectory(IntegerScalerDir);

                string targetPath = GetIntegerScalerPath();
                string resourceName = GetIntegerScalerExecutableName();

                // Always extract to ensure we have the latest version
                ExtractEmbeddedResource(resourceName, targetPath);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error extracting IntegerScaler: {ex.Message}");
            }
        }

        /// <summary>
        /// Extracts an embedded resource to a file
        /// </summary>
        private static void ExtractEmbeddedResource(string resourceName, string targetPath)
        {
            var assembly = Assembly.GetExecutingAssembly();
            string fullResourceName = $"HabboLauncher.Resources.{resourceName}";

            using (Stream resourceStream = assembly.GetManifestResourceStream(fullResourceName))
            {
                if (resourceStream == null)
                {
                    throw new Exception($"Could not find embedded resource: {fullResourceName}");
                }

                using (FileStream fileStream = new FileStream(targetPath, FileMode.Create, FileAccess.Write))
                {
                    resourceStream.CopyTo(fileStream);
                }
            }
        }

        /// <summary>
        /// Launches IntegerScaler with optimized arguments for user's resolution
        /// </summary>
        public static void LaunchIntegerScaler()
        {
            try
            {
                EnsureIntegerScalerExtracted();

                string integerScalerPath = GetIntegerScalerPath();

                if (!File.Exists(integerScalerPath))
                {
                    throw new Exception("IntegerScaler executable not found after extraction.");
                }

                string arguments = GetOptimalArguments();

                Process.Start(new ProcessStartInfo(integerScalerPath)
                {
                    WorkingDirectory = IntegerScalerDir,
                    Arguments = arguments
                });
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error launching IntegerScaler: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Checks if IntegerScaler process is already running
        /// </summary>
        public static bool IsIntegerScalerRunning()
        {
            try
            {
                string exeName = Path.GetFileNameWithoutExtension(GetIntegerScalerExecutableName());
                var processes = Process.GetProcessesByName(exeName);
                return processes.Length > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
