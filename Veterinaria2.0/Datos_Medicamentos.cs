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
    public partial class Datos_Medicamentos : Form
    {
        public Datos_Medicamentos()
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

        private void button1_Click(object sender, EventArgs e)
        {
            textId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textPrecio.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textPiezas.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();


        }

        private void cargarTabla(string dato)
        {
            List<DatMedi> lista = new List<DatMedi>();
            CtrDatos _ctrDatos = new CtrDatos();
            dataGridView1.DataSource = _ctrDatos.consulta(dato);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Agregar_Medicamento_Click(object sender, EventArgs e)
        {

            bool bandera = false;

            DatMedi _Medicamentos = new DatMedi();


            _Medicamentos.Medicamentos1 = textNombre.Text;
            _Medicamentos.Precio1 = double.Parse(textPrecio.Text);
            _Medicamentos.Piezas1 = int.Parse(textPiezas.Text);


            CtrDatos ctrDatos = new CtrDatos(); 

            if(textId.Text!= "")
            {
                _Medicamentos.IdMedicamentos = int.Parse(textId.Text);
                bandera = ctrDatos.modificar(_Medicamentos);
            }
            else
            {
                bandera = ctrDatos.insertar(_Medicamentos);
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

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que desea eliminar el registro?", "Salir", 
                MessageBoxButtons.YesNoCancel);
            if(resultado == DialogResult.Yes)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                CtrDatos _ctrdatos = new CtrDatos();
                _ctrdatos.eliminar(id);
                cargarTabla(null);
            }   
        }
    }
}
