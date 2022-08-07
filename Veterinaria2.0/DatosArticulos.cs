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
    internal class DatosArticulos
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT  idArticulos, Articulos, Precio, Piezas FROM Articulos ORDER BY idArticulos ASC";

            }
            else
            {
                sql = "SELECT  idArticulos, Articulos, Precio, Piezas FROM Articulos WHERE idArticulos LIKE '%" + dato + "%' OR Articulos LIKE '%" + dato + "%' OR Precio LIKE '%" + dato + "%' OR Piezas LIKE '%" + dato + "%' ORDER BY idArticulos ASC";
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
                    DatArticulos _Articulos = new DatArticulos();
                    _Articulos.IdArticulos = int.Parse(reader.GetString(0));
                    _Articulos.Articulo1 = reader.GetString(1);
                    _Articulos.Precio1 = double.Parse(reader[2].ToString());
                    _Articulos.Piezas1 = int.Parse(reader.GetString(3));

                    lista.Add(_Articulos);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return lista;
        }

        public bool insertar(DatArticulos datos)
        {
            bool bandera = false;

            string sql = "INSERT INTO Articulos(Articulos, Precio, Piezas) VALUES('" + datos.Articulo1 + "', '" + datos.Precio1 + "', '" + datos.Piezas1 + "')";

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
                    MessageBox.Show("Articulo guardado");
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

        public bool modificar(DatArticulos datos)
        {
            bool bandera = false;

            string sql = "UPDATE  Articulos SET Articulos = '" + datos.Articulo1 + "' , Precio =  '" + datos.Precio1 + "', Piezas = '" + datos.Piezas1 + "'WHERE idArticulos='" + datos.IdArticulos + "'";

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
                    MessageBox.Show("Articulo guardado");
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

            string sql = "DELETE FRom Articulos WHERE idArticulos = '" + id + "'";



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
                    MessageBox.Show("Articulo guardado");
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
