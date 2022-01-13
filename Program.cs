// Oğuzcan "Neonebu" Şirolu


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeonebuMain
{
    static class Program
    {
        static Form1 form1;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form1 = new Form1();
            Beginning beginning = new Beginning();
            beginning.RegisterInStartup();
            Application.Run(form1);
        }
    }
}
