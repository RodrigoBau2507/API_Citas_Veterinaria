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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
            cargarCombox();
        }
        private void buttonAgregar_Doc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se a agregado el doctor");
            this.Hide();
            Principal prin = new Principal();
            prin.ShowDialog();
        }
        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal prin = new Principal();
            prin.ShowDialog();
        }

        private void buttonAgregar_Doc_Click_1(object sender, EventArgs e)
        {
            int idColonia = int.Parse(comboColonia.SelectedValue.ToString());
            int idEspecialidad = int.Parse(comboEspecialidad.SelectedValue.ToString());

            try
            {
                string nombre = textNombre.Text;
                string apellido_paterno = textApellido1.Text;
                string apellido_materno = textApellido2.Text;

                string telefono_Celular = textTelefono.Text;
                string telefon_Fijo = textTelefono_Fijo.Text;
                string email = textEmail.Text;

                if (nombre != "" && apellido_paterno != "" && apellido_materno != "" && telefono_Celular != "" && telefon_Fijo != "" && email != "")
                {
                    string sql = "INSERT INTO Doctor (Nombre, Apellido1, Apellido2, Colonia_idColonia, Especialidad_idEspecialidad,Telefono_Celular, Telefono_Fijo, Email) VALUES ('" + nombre + "', '" + apellido_paterno + "','" + apellido_materno + "','" + idColonia + "','"+ idEspecialidad+ "','" + telefono_Celular + "','" + telefon_Fijo + "','" + email + "')";
                    MySqlConnection conexionBD = Clases.Conexion.ObtenerConnection();

                    if (conexionBD.State != ConnectionState.Open)
                    {
                        conexionBD.Open();
                    }
                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Registro guardad");
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
        }

        private void cargarCombox()
        {
            
            comboColonia.DataSource = null;
            comboEspecialidad.DataSource = null;

            comboColonia.Items.Clear();
            comboEspecialidad.Items.Clear();





            string sql = "SELECT idColonia, Colonia FROM Colonia ORDER BY Colonia ASC ";
            string sql2 = "SELECT idEspecialidad, Especialidad FROM Especialidad ORDER BY idEspecialidad ASC ";


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

                comboColonia.ValueMember = "idColonia";
                comboColonia.DisplayMember = "Colonia";
                comboColonia.DataSource = dt;

                comboEspecialidad.ValueMember = "idEspecialidad";
                comboEspecialidad.DisplayMember = "Especialidad";
                comboEspecialidad.DataSource = dt2;


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
    }

}
