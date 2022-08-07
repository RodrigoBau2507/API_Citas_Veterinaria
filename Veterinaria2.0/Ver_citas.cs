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
    public partial class Ver_citas : Form
    {
        public Ver_citas()
        {
            InitializeComponent();
            cargarTabla(null);
            cargarCombos();
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal prin = new Principal();
            prin.ShowDialog();
        }

        private void Regresar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Cita principal = new Cita();
            principal.ShowDialog();
        }

        private void cargarTabla(string dato)
        {
            List<DatMedi> lista = new List<DatMedi>();
            DatosCitas _ctrDatos = new DatosCitas();
            dataGridView1.DataSource = _ctrDatos.consulta(dato);
        }

        private void Ver_citas_Load(object sender, EventArgs e)
        {

        }

        private void Agregar_Propietario_Click(object sender, EventArgs e)
        {
            bool bandera = false;

            DatCitas _Citas = new DatCitas();




            _Citas.Fecha1 = DateTime.Parse(Fecha.Value.Year +"/" + Fecha.Value.Month +"/" + Fecha.Value.Day);
            _Citas.Decripcion1 = txtDescripcion.Text;
            _Citas.Servicio_idServicio1 = int.Parse(Servicio.SelectedValue.ToString());
            _Citas.Mascota_idMascota1 = int.Parse(comboMascota.SelectedValue.ToString());
           // _Citas.Hora1 = DateTime.Parse(dateTimePicker1.Value.Hour +":"+ dateTimePicker1.Value.Minute +":"+ dateTimePicker1.Value.Second);
        


            DatosCitas ctrDatos = new DatosCitas();

            if (textId.Text != "")
            {
                _Citas.IdCitas = int.Parse(textId.Text);
                bandera = ctrDatos.modificar(_Citas);
            }
            else
            {
                bandera = ctrDatos.insertar(_Citas);
            }


            if (bandera)
            {
                MessageBox.Show("Medicamento guardado");
                limpiar();
                cargarTabla(null);
            }
        }

        private void limpiar()
        {

            textId.Text = "";
            dateTimePicker1.Text = "";
            txtDescripcion.Text = "";
            Servicio.Text = "";
            Fecha.Text = "";
            comboMascota.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No es posible cambiar la fecha y hora");
            textId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //dateTimePicker1.MaxDate = dataGridView1.CurrentRow.Cells[1].Value.Equals(dateTimePicker1.Value.Hour + ":" + dateTimePicker1.Value.Minute + ":" + dateTimePicker1.Value.Second);
            Fecha.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDescripcion.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboMascota.SelectedValue = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            Servicio.SelectedValue = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que desea eliminar el registro?", "Salir",
                MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                DatosCitas _ctrdatos = new DatosCitas();
                _ctrdatos.eliminar(id);
                cargarTabla(null);
            }
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
    }
}
