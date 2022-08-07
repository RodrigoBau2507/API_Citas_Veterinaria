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
    public partial class Ver_Usuarios : Form
    {
        public Ver_Usuarios()
        {
            InitializeComponent();
            cargarTabla(null);
            cargarColonias();
        }
        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal prin = new Principal();
            prin.ShowDialog();
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
                MessageBox.Show("Error al cargar datos" + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal prin = new Principal();
            prin.ShowDialog();
        }


        private void cargarTabla(string dato)
        {
            List<DatMedi> lista = new List<DatMedi>();
            DatosPropietario _ctrDatos = new DatosPropietario();
            dataGridView1.DataSource = _ctrDatos.consulta(dato);
        }

        private void Ver_Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool bandera = false;

            DatPropietarios _Propietario = new DatPropietarios();


            _Propietario.Nombre1 = textNombre.Text;
            _Propietario.Apellido11 = textApellido1.Text;
            _Propietario.Apellido21 = textApellido2.Text;
            _Propietario.Telefono_Celular1 = textTelefono_Celular.Text;
            _Propietario.Telefono_Fijo1 = textTelefonoFijo.Text;
            _Propietario.Email1 = textEmail.Text;
            _Propietario.IdColonia = int.Parse(comboColonia.SelectedValue.ToString());


            DatosPropietario ctrDatos = new DatosPropietario();

            if (textBox4.Text != "")
            {
                _Propietario.idPropietario1 = int.Parse(textBox4.Text);
                bandera = ctrDatos.modificar(_Propietario);
            }
            else
            {
                bandera = ctrDatos.insertar(_Propietario);
            }


            if (bandera)
            {
                MessageBox.Show("Articulo guardado");
                limpiar();
                cargarTabla(null);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textApellido1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textApellido2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboColonia.SelectedValue = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textTelefono_Celular.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textTelefonoFijo.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textEmail.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        


        private void limpiar()
        {

            textBox4.Text = "";
            textNombre.Text = "";
            textApellido1.Text = "";
            textApellido2.Text = "";
            textTelefono_Celular.Text = "";
            textEmail.Text = "";
            textTelefonoFijo.Text = "";
        }


       
        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que desea eliminar el registro?", "Salir",
                MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                DatosPropietario _ctrdatos = new DatosPropietario();
                _ctrdatos.eliminar(id);
                cargarTabla(null);
            }
        }
    }
}
