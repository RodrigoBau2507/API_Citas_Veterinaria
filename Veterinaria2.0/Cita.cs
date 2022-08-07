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
    public partial class Cita : Form
    {
        public Cita()
        {
            InitializeComponent();
            cargarCombos();
        }
        private void Regresar_Click(object sender, EventArgs e)
        {
            Inicio cita = new Inicio();
            cita.Show();
            this.Hide();
            this.Close();
        }

        private void Agregar_Propietario_Click(object sender, EventArgs e)
        {
            int idServicio = int.Parse(Servicio.SelectedValue.ToString());
            int idMascota = int.Parse(comboMascota.SelectedValue.ToString());


            try
            {
             
                string descripcion = txtDescripcion.Text;
               
                
                
                if ( descripcion != "")
                {
                    string sql = "INSERT INTO Citas (Hora, Fecha, Decripcion, Mascota_idMascota, Servicio_idServicio) VALUES ('" + DateTime.Now.ToString(dateTimePicker1.Text) + "', '" + this.Fecha.Text + "', '" + descripcion + "', '" + idMascota + "', '" + idServicio +"')";

                    MySqlConnection conexionBD = Clases.Conexion.ObtenerConnection();

                    if (conexionBD.State != ConnectionState.Open)
                    {
                        conexionBD.Open();
                    }

                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                        
                        comando.ExecuteNonQuery();
               
                        MessageBox.Show("Registro guardado");

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error" + ex.Message);
                        Console.WriteLine("Holalalalalalala" + DateTime.Now.ToString(dateTimePicker1.Text));
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
            Principal propietario = new Principal();
            propietario.Show();
        }
        private void Descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validar.Letras(e);
        }

        private void cargarCombos()
        {
            Servicio.DataSource = null;
            Servicio.Items.Clear();

            comboMascota.DataSource = null;
            comboMascota.Items.Clear();
            string sql = "SELECT idServicio, Servicio, Precio FROM Servicio ORDER BY Servicio ASC ";
            string sql2 = "SELECT idMascota, Nombre_Mascota FROM Mascota ORDER BY Nombre_Mascota ASC ";

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

                Servicio.ValueMember = "idServicio";
                Servicio.DisplayMember = "Servicio";
                Servicio.DataSource = dt;


                comboMascota.ValueMember = "idMascota";
                comboMascota.DisplayMember = "Nombre_Mascota";
                comboMascota.DataSource = dt2;
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

        private void Fecha_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = Fecha.Value;

        }

        private void Cita_Load(object sender, EventArgs e)
        {

        }

        private void Ver_Citas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ver_citas citas = new Ver_citas();
            citas.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal citas = new Principal();
            citas.ShowDialog();
        }

        private void Servicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
