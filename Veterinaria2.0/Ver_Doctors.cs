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
    public partial class Ver_Doctors : Form
    {
        public Ver_Doctors()
        {
            InitializeComponent();
            cargarCombos();
            cargarTabla(null);
        }
        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal prin = new Principal();
            prin.ShowDialog();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Principal cita = new Principal();
            cita.Show();
            this.Hide();
            this.Close();
        }

        private void cargarCombos()
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

        private void buttonAgregar_Doc_Click(object sender, EventArgs e)
        {
            bool bandera = false;

            DatDoctor _Doctor = new DatDoctor();


            _Doctor.Nombre1 = textNombre.Text;
            _Doctor.Apellido11 = textApellido1.Text;
            _Doctor.Apellido21 = textApellido2.Text;
            _Doctor.IdColonia = int.Parse(comboColonia.SelectedValue.ToString());
            _Doctor.IdEspecialidad = int.Parse(comboEspecialidad.SelectedValue.ToString());
            _Doctor.Telefono_Celular1 = textTelefono.Text;
            _Doctor.Telefono_Fijo1 = textTelefono_Fijo.Text;
            _Doctor.Email1 = textEmail.Text;



            DatosDoctor ctrDatos = new DatosDoctor();

            if (textId.Text != "")
            {
                _Doctor.IdDoctor = int.Parse(textId.Text);
                bandera = ctrDatos.modificar(_Doctor);
            }
            else
            {
                bandera = ctrDatos.insertar(_Doctor);
            }


            if (bandera)
            {
                MessageBox.Show("Articulo guardado");
                limpiar();
                cargarTabla(null);
            }

        }
        private void cargarTabla(string dato)
        {
            List<DatMedi> lista = new List<DatMedi>();
            DatosDoctor _ctrDatos = new DatosDoctor();
            dataGridView1.DataSource = _ctrDatos.consulta(dato);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textApellido1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textApellido2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboColonia.SelectedValue = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboEspecialidad.SelectedValue = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textTelefono.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textTelefono_Fijo.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textEmail.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

        }
        private void limpiar()
        {

            textId.Text = "";
            textNombre.Text = "";
            textApellido1.Text = "";
            textApellido2.Text = "";
            textTelefono.Text = "";
            textEmail.Text = "";
            textTelefono_Fijo.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que desea eliminar el registro?", "Salir",
                MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                DatosDoctor _ctrdatos = new DatosDoctor();
                _ctrdatos.eliminar(id);
                cargarTabla(null);
            }
        }
    }
}
