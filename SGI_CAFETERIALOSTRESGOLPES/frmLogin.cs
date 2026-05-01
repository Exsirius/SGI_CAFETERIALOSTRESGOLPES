using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGI_CAFETERIALOSTRESGOLPES
{
    public partial class frmLogin : Form
    {
        SplashMenu splash = new SplashMenu();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtNombre.Text = "admin";
            txtContrasena.Text = "HASH_SHA256_AQUI";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if ((txtNombre.Text == "") || (txtContrasena.Text == ""))
            {
                MessageBox.Show("No debe dejar Campos o Casillas Vacias");
                txtNombre.Focus();
                return;
            }

            SqlConexionManager.conexion = new SqlConnection();
            SqlConexionManager.conexion.ConnectionString = SqlConexionManager.cnn;
            SqlConexionManager.Sql = $"SELECT * FROM Usuarios WHERE NombreUsuario = '{txtNombre.Text}' AND Contrasena = '{txtContrasena.Text}'";
            SqlConexionManager.conexion.Open();
            SqlConexionManager.Adaptar = new SqlDataAdapter(SqlConexionManager.Sql, SqlConexionManager.conexion);
            SqlConexionManager.Almacen = new DataSet();
            SqlConexionManager.conexion.Close();
            SqlConexionManager.Adaptar.Fill(SqlConexionManager.Almacen, "Usuarios");
            SqlConexionManager.Resultado = SqlConexionManager.Almacen.Tables[0].Rows.Count;

            if (SqlConexionManager.Resultado <= 0)
            {
                MessageBox.Show("Usuario/contraseña incorrectos :(");
                txtNombre.Clear();
                txtContrasena.Clear();
                txtNombre.Select();
                txtNombre.Focus();
                return;
            }

            splash.Show();
            Hide();
        }
    }
}
