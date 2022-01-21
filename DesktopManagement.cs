// Oğuzcan "Neonebu" Şirolu

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NeonebuMain
{
    public class DesktopManagement
    {
        //bg
        private static readonly UInt32 SPI_SETDESKWALLPAPER = 0x14;
        private static readonly UInt32 SPIF_UPDATEINIFILE = 0x01;
        private static readonly UInt32 SPIF_SENDWININICHANGE = 0x02;
        private const UInt32 SPI_GETDESKWALLPAPER = 0x73;
        private const int MAX_PATH = 260;


        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SystemParametersInfo(UInt32 action, UInt32 uParam, String vParam, UInt32 winIni);
        public static void SetWallpaper(String path)
        {
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path,
                SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
        }
        
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SystemParametersInfo(UInt32 uAction, int uParam, string lpvParam, int fuWinIni);

        public string GetCurrentDesktopWallpaper()
        {
            string currentWallpaper = new string('\0', MAX_PATH);
            SystemParametersInfo(SPI_GETDESKWALLPAPER, currentWallpaper.Length, currentWallpaper, 0);
            return currentWallpaper.Substring(0, currentWallpaper.IndexOf('\0'));
        }

}
}
