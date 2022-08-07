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
    public partial class Ver_Articulos : Form
    {
        public Ver_Articulos()
        {
            InitializeComponent();
            cargarTabla(null);

        }
        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal prin = new Principal();
            prin.ShowDialog();
        }

        private void Agregar_Articulo_Click(object sender, EventArgs e)
        {
            bool bandera = false;

            DatArticulos _Articulos = new DatArticulos();


            _Articulos.Articulo1 = textNombre.Text;
            _Articulos.Precio1 = double.Parse(textPrecio.Text);
            _Articulos.Piezas1 = int.Parse(textPiezas.Text);


            DatosArticulos ctrDatos = new DatosArticulos();

            if (textId.Text != "")
            {
                _Articulos.IdArticulos = int.Parse(textId.Text);
                bandera = ctrDatos.modificar(_Articulos);
            }
            else
            {
                bandera = ctrDatos.insertar(_Articulos);
            }


            if (bandera)
            {
                MessageBox.Show("Articulo guardado");
                limpiar();
                cargarTabla(null);
            }
        }

        private void limpiar()
        {

            textId.Text = "";
            textNombre.Text = "";
            textPiezas.Text = "";
            textPrecio.Text = "";
        }

        private void Regresar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Principal mascota = new Principal();
            mascota.Show();
        }
        private void cargarTabla(string dato)
        {
            List<DatMedi> lista = new List<DatMedi>();
            DatosArticulos _ctrDatos = new DatosArticulos();
            dataGridView1.DataSource = _ctrDatos.consulta(dato);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textPrecio.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textPiezas.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que desea eliminar el registro?", "Salir",
                MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                DatosArticulos _ctrdatos = new DatosArticulos();
                _ctrdatos.eliminar(id);
                cargarTabla(null);
            }
        }
    }
}
