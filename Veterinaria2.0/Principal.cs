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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void AgendarCita_Click(object sender, EventArgs e)
        {
            this.Hide();
            Propietario cita = new Propietario();
            cita.ShowDialog();
        }

        private void butSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Mascota_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Agregar_Mascota mascota = new Agregar_Mascota();
            mascota.ShowDialog();
        }

        private void Citas_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Ver_citas citas = new Ver_citas();
            citas.ShowDialog();
        }

        private void buttonVer_Articulos_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Ver_Articulos articu = new Ver_Articulos();
            articu.ShowDialog();
        }

        private void button_Ver_Medi_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Datos_Medicamentos ver = new Datos_Medicamentos();
            ver.ShowDialog();
        }

        private void Articulos_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Ver_Articulos articulos = new Ver_Articulos();
            articulos.ShowDialog();
        }

        private void Medicamentos_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Datos_Medicamentos medi = new Datos_Medicamentos();
            medi.ShowDialog();
        }

        private void Recibo_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Recibo ticket = new Recibo();
            ticket.ShowDialog();
        }

        private void Datos_Doctor_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Ver_Doctors datos = new Ver_Doctors();
            datos.ShowDialog();
        }

        private void Agregar_Doc_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Doctor doctor = new Doctor();
            doctor.ShowDialog();
        }

        private void Datos_Pro_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Ver_Usuarios datos = new Ver_Usuarios();
            datos.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
