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
    public partial class Agendar_Cita : Form
    {
        public Agendar_Cita()
        {
            InitializeComponent();
        }

        private void AgendarCita_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Agendando cita");

            this.Hide();
            Cita principal = new Cita();
            principal.ShowDialog();
        }
        private void Regresar_Click(object sender, EventArgs e)
        {

            Propietario regresar = new Propietario();
            regresar.Show();
            this.Hide();
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
