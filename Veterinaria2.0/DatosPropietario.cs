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
    internal class DatosPropietario
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT  idDueno, Nombre, Apellido1, Apellido2, Telefono_Celular, Telefono_Fijo, Email, Colonia_idColonia FROM Dueno ORDER BY idDueno ASC";

            }
            else
            {
                sql = "SELECT  idDueno, Nombre, Apellido1, Apellido2, Telefono_Celular, Telefono_Fijo, Email, Colonia_idColonia FROM Dueno WHERE idCitas LIKE '%" + dato + "%' OR Nombre LIKE '%" + dato + "%' OR Apellido1 LIKE '%" + dato + "%' OR Apellido2 LIKE '%" + dato + "%' OR Telefono_Celular LIKE '%" + dato + "%' OR Telefono_Fijo LIKE '%" + dato + "%' OR Email LIKE '%" + dato + "%' OR Colonia_idColonia LIKE '%" + dato + "%' ORDER BY idDueno ASC";
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
                    DatPropietarios _Propietario = new DatPropietarios();
                    _Propietario.idPropietario1 = int.Parse(reader.GetString(0));
                    _Propietario.Nombre1 = reader.GetString("Nombre");
                    _Propietario.Apellido11 = reader.GetString(2);
                    _Propietario.Apellido21 = reader.GetString(3);
                    _Propietario.Telefono_Celular1 = reader.GetString(4);
                    _Propietario.Telefono_Fijo1 = reader.GetString(5);
                    _Propietario.Email1 = reader.GetString(6);
                    _Propietario.IdColonia = int.Parse(reader.GetString(7));



                    lista.Add(_Propietario);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return lista;
        }

        public bool insertar(DatPropietarios datos)
        {
            bool bandera = false;

            string sql = "INSERT INTO Dueno(Nombre, Apellido1, Apellido2, Telefono_Celular, Telefono_Fijo, Email, Colonia_idColonia) VALUES('" + datos.Nombre1 + "', '" + datos.Apellido11 + "', '" + datos.Apellido21 + "','" + datos.Telefono_Celular1 + "', '" + datos.Telefono_Fijo1 + "', '" + datos.Email1 + "',  '" + datos.IdColonia + "')";

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
                    MessageBox.Show("Doctor guardado");
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

        public bool modificar(DatPropietarios datos)
        {
            bool bandera = false;

            string sql = "UPDATE  Dueno SET Nombre = '" + datos.Nombre1 + "', Apellido1 = '" + datos.Apellido11 + "', Apellido2 = '" + datos.Apellido21 + "', Telefono_Celular = '" + datos.Telefono_Celular1 + "', Telefono_Fijo = '" + datos.Telefono_Fijo1 + "', Email = '" + datos.Email1 + "', Colonia_idColonia = '" + datos.IdColonia + "' WHERE idDueno='" + datos.idPropietario1 + "'";

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

            string sql = "DELETE FRom Dueno WHERE idDueno = '" + id + "'";



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
