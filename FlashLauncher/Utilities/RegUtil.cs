using Microsoft.Win32;

namespace HabboLauncher
{
    public static class RegUtil
    {
        public static void RegisterProtocol(string path)
        {
            var key = Registry.ClassesRoot.OpenSubKey("habbo");
            if (key == null)
            {
                key = Registry.ClassesRoot.CreateSubKey("habbo");
                key.SetValue(string.Empty, "URL:habbo");
                key.SetValue("URL Protocol", string.Empty);

                key = key.CreateSubKey(@"shell\open\command");
                key.SetValue(string.Empty, $"\"{path}\" \"%1\"");
            }
            else
            {
                key.SetValue(string.Empty, "URL:habbo");
                key.SetValue("URL Protocol", string.Empty);
            }

            var subKey = key.OpenSubKey(@"shell\open\command");
            if (subKey == null)
                subKey = key.CreateSubKey(@"shell\open\command");

            subKey.SetValue(string.Empty, $"\"{path}\" \"%1\"");
            subKey.Dispose();
        }
    }
}
