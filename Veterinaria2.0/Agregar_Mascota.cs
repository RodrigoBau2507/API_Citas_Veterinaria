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
    public partial class Agregar_Mascota : Form
    {
        public Agregar_Mascota()
        {
            InitializeComponent();
            cargarCombos();
        }
        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal prin = new Principal();
            prin.ShowDialog();
        }

        private void Agregar_Mascota_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Principal cita = new Principal();
            cita.Show();
            this.Hide();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idEspecie = int.Parse(comboEspecie.SelectedValue.ToString());
            int idraza = int.Parse(comboRaza.SelectedValue.ToString());
            int iddueno = int.Parse(comboDueno.SelectedValue.ToString());


            try
            {
                string nombre = textNombreMas.Text;
                string sexo = textSexo.Text;
                if (nombre != "" && sexo != "")
                {
                    string sql = "INSERT INTO Mascota (Nombre_Mascota, Sexo, Fecha_Nacimiento, Dueno_idDueno, Raza_idRaza, Especie_idEspecie) VALUES " +
                        "('" + nombre + "', '" + sexo + "','" + this.dateTimeFecha_Naci.Text + "','" + iddueno + "','" + idraza + "','" + idEspecie + "')";
                    MySqlConnection conexionBD = Clases.Conexion.ObtenerConnection();

                    if (conexionBD.State != ConnectionState.Open)
                    {
                        conexionBD.Open();
                    }
                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Registro guardado...");
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

            MessageBox.Show("Se a agregado la mascota");

            this.Hide();
            Cita principal = new Cita();
            principal.ShowDialog();
        }


        private void cargarCombos()
        {
            comboEspecie.DataSource = null;
            comboRaza.DataSource = null;
            comboDueno.DataSource = null;

            comboEspecie.Items.Clear();
            comboRaza.Items.Clear();
            comboDueno.Items.Clear();




            string sql = "SELECT idEspecie, Especie FROM Especie ORDER BY Especie ASC ";
            string sql2 = "SELECT idRaza, Raza FROM Raza ORDER BY Raza ASC ";
            string sql3 = "SELECT idDueno, Nombre FROM Dueno ORDER BY idDueno ASC ";

            MySqlConnection conexionBD = Clases.Conexion.ObtenerConnection();


            if (conexionBD.State != ConnectionState.Open)
            {
                conexionBD.Open();
            }

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                MySqlDataAdapter data = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                data.Fill(dt);

                MySqlCommand comando2 = new MySqlCommand(sql2, conexionBD);
                MySqlDataAdapter data2 = new MySqlDataAdapter(comando2);
                DataTable dt2 = new DataTable();
                data2.Fill(dt2);

                MySqlCommand comando3 = new MySqlCommand(sql3, conexionBD);
                MySqlDataAdapter data3 = new MySqlDataAdapter(comando3);
                DataTable dt3 = new DataTable();
                data3.Fill(dt3);

                comboEspecie.ValueMember = "idEspecie";
                comboEspecie.DisplayMember = "Especie";
                comboEspecie.DataSource = dt;

                comboRaza.ValueMember = "idRaza";
                comboRaza.DisplayMember = "Raza";
                comboRaza.DataSource = dt2;

                comboDueno.ValueMember = "idDueno";
                comboDueno.DisplayMember = "Nombre";
                comboDueno.DataSource = dt3;




            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar datos" + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void comboDueno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
