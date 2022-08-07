using MySql.Data.MySqlClient;
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
    public partial class Medicamentos : Form
    {
        public Medicamentos()
        {
            InitializeComponent();
        }
        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal prin = new Principal();
            prin.ShowDialog();
        }

        private void Agregar_Medicamento_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sea agregado el medicamento");
        }

        private void Agregar_Medicamento_Click_1(object sender, EventArgs e)
        {
            try
            {
                string nombre = textNombre.Text;
                decimal precio = decimal.Parse(textPrecio.Text);
                int piezas = int.Parse(textPiezas.Text);

                if (nombre != "" && precio >= 0 && piezas >= 0)
                {
                    string sql = "INSERT INTO Medicamentos (Medicamentos, Precio, Piezas) VALUES ('" + nombre + "', '" + precio + "','" + piezas + "')";
                    MySqlConnection conexionBD = Clases.Conexion.ObtenerConnection();

                    if (conexionBD.State != ConnectionState.Open)
                    {
                        conexionBD.Open();
                    }
                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Medicamento guardado");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error" + ex.Message);
                    }
                    finally
                    {
                        conexionBD.Close();
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Datos incorectos" + ex.Message);
            }

            this.Hide();
            Principal mascota = new Principal();
            mascota.Show();
            MessageBox.Show("Sea agregado el medicamento");
        }

        private void textPiezas_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Regresar_Click_1(object sender, EventArgs e)
        {

        }

        private void textPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
