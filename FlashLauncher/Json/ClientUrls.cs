using Newtonsoft.Json;

namespace HabboLauncher.Json
{
    public class ClientUrls
    {
        [JsonProperty(PropertyName = "windows-version")] public string WindowsVersion { get; set; }
        [JsonProperty(PropertyName = "flash-windows-version")] public string FlashWindowsVersion { get; set; }
        [JsonProperty(PropertyName = "unity-windows")] public string UnityWindows { get; set; }
        [JsonProperty(PropertyName = "flash-osx-version")] public string FlashOsxVersion { get; set; }
        [JsonProperty(PropertyName = "osx-version")] public string OsxVersion { get; set; }
        [JsonProperty(PropertyName = "flash-windows")] public string FlashWindows { get; set; }
        [JsonProperty(PropertyName = "flash-osx")] public string FlashOsx { get; set; }
        [JsonProperty(PropertyName = "unity-osx-version")] public string UnityOsxVersion { get; set; }
        [JsonProperty(PropertyName = "unity-windows-version")] public string UnityWindowsVersion { get; set; }
        [JsonProperty(PropertyName = "shockwave-windows")] public string ShockwaveWindows { get; set; }
        [JsonProperty(PropertyName = "shockwave-osx")] public string ShockwaveOsx { get; set; }
        [JsonProperty(PropertyName = "shockwave-windows-version")] public string ShockwaveWindowsVersion { get; set; }
        [JsonProperty(PropertyName = "shockwave-osx-version")] public string ShockwaveOsxVersion { get; set; }
    }
}
