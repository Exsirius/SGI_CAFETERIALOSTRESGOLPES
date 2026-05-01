using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGI_CAFETERIALOSTRESGOLPES
{
    public partial class SplashMenu : Form
    {
        public SplashMenu()
        {
            InitializeComponent();
        }

        private void SplashMenu_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Close();

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            timer1.Interval = 100;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Stop();
                frmMenuPrincipal menu = new frmMenuPrincipal();
                menu.Show();
                Hide();
                return;
            }
            progressBar1.Value += 5;
        }
    }
}
