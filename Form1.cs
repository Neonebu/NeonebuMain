using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeonebuMain
{
    public partial class Form1 : Form
    {
        private DesktopManagement mgnt = new DesktopManagement();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBgImage_Click(object sender, EventArgs e)
        {
            //Beginning.SetWallpaper("C:\\Users\\Oguzcan\\Pictures\\pp.png");
            pictureBox1.Image = Image.FromFile(mgnt.GetCurrentDesktopWallpaper());

        }
    }
}
