// Oğuzcan "Neonebu" Şirolu

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace NeonebuMain
{
    public static class Beginning
    {

        private const UInt32 SPI_GETDESKWALLPAPER = 0x73;
        private const int MAX_PATH = 260;


        public static void MaximizeFromSystemTray()
        {
        }
        public static void MinimizeToSystemTray()
        {

        }
        public static void RegisterInStartup()
        {
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (registryKey.GetValue("NeonebuMain") == null)
                {
                    registryKey.SetValue("NeonebuMain", Application.ExecutablePath);
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }



    }
}
