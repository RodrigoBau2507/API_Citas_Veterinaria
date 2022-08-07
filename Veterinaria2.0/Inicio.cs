using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria2._0
{
    public partial class Inicio : Form
    {
        private String Usuari = "Administrador";
        private String constra = "12345";
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (Usuario.Text != Usuari || Contrasena.Text != constra)
            {
                if (Usuario.Text != Usuari)
                {
                    MessageBox.Show("Usuario incorrecto");
                    Usuario.Clear();
                    Usuario.Focus();
                    return;
                }
                if (Contrasena.Text != constra)
                {
                    MessageBox.Show("Contraseña incorrecto");
                    Contrasena.Clear();
                    Contrasena.Focus();
                    return;
                }
            }
            else
            {
                Clases.Conexion.ObtenerConnection();
                Usuario.Clear();
                Contrasena.Clear();
                this.Hide();
                Principal Form = new Principal();
                Form.ShowDialog();

            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
