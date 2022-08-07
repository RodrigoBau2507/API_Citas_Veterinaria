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
    public partial class Propietario : Form
    {
        public Propietario()
        {
            InitializeComponent();
            cargarColonias();
        }

        private void Agregar_Mascota_Click(object sender, EventArgs e)
        {
            int idColonia = int.Parse(comboColonia.SelectedValue.ToString());

            try
            {
                string nombre = textNombre.Text;
                string apellido_paterno = textApellido1.Text;
                string apellido_materno = textApellido2.Text;

                string telefono_Celular = textTelefono_Celular.Text;
                string telefon_Fijo = textTelefonoFijo.Text;
                string email = textEmail.Text;

                if(nombre != "" && apellido_paterno != "" && apellido_materno != "" && telefono_Celular != "" && telefon_Fijo != "" && email != "")
                {
                    string sql = "INSERT INTO Dueno (Nombre, Apellido1, Apellido2,Telefono_Celular, Telefono_Fijo, Email, Colonia_idColonia) VALUES ('" + nombre+ "', '" + apellido_paterno + "','" + apellido_materno + "','" + telefono_Celular + "','" + telefon_Fijo + "','" + email + "','" + idColonia + "')";
                    MySqlConnection conexionBD = Clases.Conexion.ObtenerConnection();

                    if (conexionBD.State != ConnectionState.Open)
                    {
                        conexionBD.Open();
                    }
                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("REgistro guardad");
                    }
                    catch(MySqlException ex)
                    {
                        MessageBox.Show("Error"+ex.Message);
                    }
                    finally
                    {
                        conexionBD.Close();
                    }
                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Datos incorectos"+ ex.Message);
            }

            this.Hide();
            Agregar_Mascota mascota = new Agregar_Mascota();
            mascota.Show();
        }

        private void cargarColonias()
        {
            comboColonia.DataSource = null;
            comboColonia.Items.Clear();

            string sql = "SELECT idColonia, Colonia FROM Colonia ORDER BY Colonia ASC ";
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

                comboColonia.ValueMember = "idColonia";
                comboColonia.DisplayMember = "Colonia";
                comboColonia.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar datos"+ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Principal mascota = new Principal();
            mascota.Show();
            this.Hide();
            this.Close();
        }
    }
}
