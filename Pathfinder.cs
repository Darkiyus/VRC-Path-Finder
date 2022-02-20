using Microsoft.Win32;
namespace VRCPathFinder
{
    public class VRCPath
    {
        public static string Search()
        {
            string result = "";

            try
            {
                object vrchatInstallPath = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 438100").GetValue("InstallLocation");
                result = vrchatInstallPath.ToString();
            }

            catch 
            {
                result = "Error";
            }
            
            return result;
        }
    }
}
