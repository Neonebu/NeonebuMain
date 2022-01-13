// Oğuzcan "Neonebu" Şirolu

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace NeonebuMain
{
    public class Beginning
    {
        public void MaximizeFromSystemTray()
        {
        }
        public void MinimizeToSystemTray()
        {

        }
        public void RegisterInStartup()
        {
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (registryKey.GetValue("NeonebuWindows") == null)
                {
                    registryKey.SetValue("NeonebuWindows", System.Reflection.Assembly.GetExecutingAssembly().Location);
                }
                else
                {

                }
            }
            catch (Exception ex)
            {

            }

        }
    }
}
