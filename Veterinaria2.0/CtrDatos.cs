using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria2._0
{
    internal class CtrDatos
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;

            if(dato == null)
            {
                sql = "SELECT  idMedicamentos, Medicamentos, Precio, Piezas FROM Medicamentos ORDER BY idMedicamentos ASC";

            }else
            {
                sql = "SELECT  idMedicamentos, Medicamentos, Precio, Piezas FROM Medicamentos WHERE idMedicamentos LIKE '%" + dato+ "%' OR Medicamento LIKE '%" + dato + "%' OR Precio LIKE '%" + dato + "%' OR Piezas LIKE '%" + dato + "%' ORDER BY idMedicamento ASC";
            }
            try
            {
                MySqlConnection conexionBD = Clases.Conexion.ObtenerConnection();

                if (conexionBD.State != ConnectionState.Open)
                {
                    conexionBD.Open();
                }
                MySqlCommand cmd = new MySqlCommand(sql, conexionBD);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DatMedi _medicamentos = new DatMedi();
                    _medicamentos.IdMedicamentos = int.Parse(reader.GetString(0));
                    _medicamentos.Medicamentos1 = reader.GetString("Medicamentos");
                    _medicamentos.Precio1 = double.Parse(reader[2].ToString());
                    _medicamentos.Piezas1 = int.Parse(reader.GetString(3));

                    lista.Add(_medicamentos);
                }
            }catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return lista;
        }


        public bool insertar(DatMedi datos)
        {
            bool bandera = false;

            string sql = "INSERT INTO Medicamentos(Medicamentos, Precio, Piezas) VALUES('" + datos.Medicamentos1 + "', '" + datos.Precio1 + "', '" + datos.Piezas1 + "')";

            try
            { 
                MySqlConnection conexionBD = Clases.Conexion.ObtenerConnection();

                if (conexionBD.State != ConnectionState.Open)
                {
                    conexionBD.Open();
                }
                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    comando.ExecuteNonQuery();
                    bandera = true;
                    MessageBox.Show("Medicamento guardado");
                }
                catch (MySqlException ex)
                {
                    bandera = false;
                    MessageBox.Show("Error" + ex.Message);
                }
                finally
                {
                    conexionBD.Close();
                }
            }
      
            catch (FormatException ex)
            {
                MessageBox.Show("Datos incorectos" + ex.Message);
            }
            return bandera;
        }

        public bool modificar(DatMedi datos)
        {
            bool bandera = false;

            string sql = "UPDATE  Medicamentos SET Medicamentos = '" + datos.Medicamentos1 + "' , Precio =  '" + datos.Precio1 + "', Piezas = '" + datos.Piezas1 + "'WHERE idMedicamentos='" + datos.IdMedicamentos + "'";

            try
            {
                MySqlConnection conexionBD = Clases.Conexion.ObtenerConnection();

                if (conexionBD.State != ConnectionState.Open)
                {
                    conexionBD.Open();
                }
                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    comando.ExecuteNonQuery();
                    bandera = true;
                    MessageBox.Show("Medicamento guardado");
                }
                catch (MySqlException ex)
                {
                    bandera = false;
                    MessageBox.Show("Error" + ex.Message);
                }
                finally
                {
                    conexionBD.Close();
                }
            }

            catch (FormatException ex)
            {
                MessageBox.Show("Datos incorectos" + ex.Message);
            }
            return bandera;
        }

        public bool eliminar(int id)
        {
            bool bandera = false;

            string sql = "DELETE  FRom Medicamentos WHERE idMedicamentos='" + id + "'";

            try
            {
                MySqlConnection conexionBD = Clases.Conexion.ObtenerConnection();

                if (conexionBD.State != ConnectionState.Open)
                {
                    conexionBD.Open();
                }
                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    comando.ExecuteNonQuery();
                    bandera = true;
                    MessageBox.Show("Medicamento guardado");
                }
                catch (MySqlException ex)
                {
                    bandera = false;
                    MessageBox.Show("Error" + ex.Message);
                }
                finally
                {
                    conexionBD.Close();
                }
            }

            catch (FormatException ex)
            {
                MessageBox.Show("Datos incorectos" + ex.Message);
            }
            return bandera;
        }
    }
}
