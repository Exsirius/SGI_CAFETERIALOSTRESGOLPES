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
    public partial class frmLogin : Form
    {
        List<string> Usuarios = new List<string>()
        {
            "Propietario", "Gerente", "Cocinero"
        };

        frmMenuPrincipal MP = new frmMenuPrincipal();

        public frmLogin()
        {
            InitializeComponent();
        }

        public bool ValidacionCasillaVacia()
        {
            if (txtNombre.Text != "" && txtContrasena.Text != "")
            {
                return true;
            }

            return false;
        }

        public bool ValidacionNombreContrasena()
        {
            if ((txtNombre.Text != Usuarios[0] && txtNombre.Text != Usuarios[1] && txtNombre.Text != Usuarios[2]) && txtContrasena.Text != txtNombre.Text)
            {
                return true;
            }

            return false;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!ValidacionCasillaVacia())
            {
                MessageBox.Show("No puedes dejar campos vacios");
                return;
            }

            if (ValidacionNombreContrasena())
            {
                MessageBox.Show("Usuario y contraseña incorrectos");
                return;
            }

            if (txtNombre.Text != Usuarios[0] && txtNombre.Text != Usuarios[1] && txtNombre.Text != Usuarios[2])
            {
                MessageBox.Show("El Usuario no existe");
                return;
            }

            if (txtContrasena.Text != txtNombre.Text)
            {
                MessageBox.Show("La contraseña es incorrecta");
                return;
            }

            MP.Show();
        }
    }
}
