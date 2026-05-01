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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        frmLogin login = new frmLogin();
        frmUsuarios fU = new frmUsuarios();
        frmIngredientes fI = new frmIngredientes();
        frmProductos fP = new frmProductos();
        frmRecetas fR = new frmRecetas();
        frmVentas fV = new frmVentas();
        frmReporteInventario fRI = new frmReporteInventario();

        public void salirToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            login.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            fU.Show();
        }

        private void ingredientesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            fI.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            fP.Show();
        }

        private void recetasToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            fR.Show();
        }

        private void ventasProcesoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            fV.Show();
        }

        private void reporteInventarioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            fRI.Show();
        }
    }
}
