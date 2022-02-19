using Microsoft.Win32;
namespace VRCPathFinder
{
    public class VRCPath
    {
        public static string Search()
        {
            string result = "";
            object steamInstallPath = Registry.CurrentUser.OpenSubKey(@"Software\VRChat").GetValue("");
            result = steamInstallPath.ToString();
            
            return result;
        }

    }
}
