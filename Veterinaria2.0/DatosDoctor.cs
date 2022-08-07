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
    internal class DatosDoctor
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT  idDoctor, Nombre, Apellido1, Apellido2, Colonia_idColonia, Especialidad_idEspecialidad, Telefono_Celular, Telefono_Fijo, Email FROM Doctor ORDER BY idDoctor ASC";

            }
            else
            {
                sql = "SELECT  idDoctor, Nombre, Apellido1, Apellido2, Colonia_idColonia, Especialidad_idEspecialidad, Telefono_Celular, Telefono_Fijo, Email FROM Doctor WHERE idCitas LIKE '%" + dato + "%' OR Nombre LIKE '%" + dato + "%' OR Apellido1 LIKE '%" + dato + "%' OR Apellido2 LIKE '%" + dato + "%' OR Colonia_idColonia LIKE '%" + dato + "%' OR Especialidad_idEspecialidad LIKE '%" + dato + "%' OR Telefono_Celular LIKE '%" + dato + "%' OR Telefono_Fijo LIKE '%" + dato + "%' OR Email LIKE '%" + dato + "%' ORDER BY idDoctor ASC";
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
                    DatDoctor _Doctor = new DatDoctor();
                    _Doctor.IdDoctor = int.Parse(reader.GetString(0));
                    _Doctor.Nombre1 = reader.GetString("Nombre");
                    _Doctor.Apellido11 = reader.GetString(2);
                    _Doctor.Apellido21 = reader.GetString(3);
                    _Doctor.IdColonia = int.Parse(reader.GetString(4));
                    _Doctor.IdEspecialidad = int.Parse(reader[5].ToString());
                    _Doctor.Telefono_Celular1 = reader.GetString(6);
                    _Doctor.Telefono_Fijo1 = reader.GetString(7);
                    _Doctor.Email1 = reader.GetString(8);



                    lista.Add(_Doctor);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return lista;
        }

        public bool insertar(DatDoctor datos)
        {
            bool bandera = false;

            string sql = "INSERT INTO Doctor(Nombre, Apellido1, Apellido2, Colonia_idColonia, Especialidad_idEspecialidad, Telefono_Celular, Telefono_Fijo, Email) VALUES('" + datos.Nombre1 + "', '" + datos.Apellido11 + "', '" + datos.Apellido21 + "', '" + datos.IdColonia + "', '" + datos.IdEspecialidad + "', '" + datos.Telefono_Celular1 + "', '" + datos.Telefono_Fijo1 + "', '" + datos.Email1 + "')";

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

        public bool modificar(DatDoctor datos)
        {
            bool bandera = false;

            string sql = "UPDATE  Doctor SET Nombre = '" + datos.Nombre1 + "', Apellido1 = '" + datos.Apellido11 + "', Apellido2 = '" + datos.Apellido21 + "', Colonia_idColonia = '" + datos.IdColonia + "', Especialidad_idEspecialidad = '" + datos.IdEspecialidad + "', Telefono_Celular = '" + datos.Telefono_Celular1 + "', Telefono_Fijo = '" + datos.Telefono_Fijo1 + "', Email = '" + datos.Email1 + "'WHERE idDoctor='" + datos.IdDoctor + "'";

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

            string sql = "DELETE FRom Doctor WHERE idDoctor = '" + id + "'";



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
