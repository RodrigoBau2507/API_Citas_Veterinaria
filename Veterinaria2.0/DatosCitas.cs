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
    internal class DatosCitas
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT idCitas, Hora, Fecha, Decripcion, Mascota_idMascota, Servicio_idServicio FROM Citas  ORDER BY idCitas ASC";

            }
            else
            {
                sql = "SELECT  idCitas, Hora, Fecha, Decripcion, Mascota_idMascota, Servicio_idServicio FROM Citas WHERE idCitas LIKE '%" + dato + "%' OR Cita LIKE '%" + dato + "%' OR Hora LIKE '%" + dato + "%' OR Fecha LIKE '%" + dato + "%' OR Descripcion LIKE '%" + dato + "%' OR Mascota LIKE '%" + dato + "%' OR Servicio LIKE '%" + "%' ORDER BY idCitas ASC";
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
                    DatCitas _Citas = new DatCitas();
                    _Citas.IdCitas = int.Parse(reader.GetString(0));
                    _Citas.Hora1 = DateTime.Parse( reader.GetString("Hora"));
                    _Citas.Fecha1 = DateTime.Parse(reader[2].ToString());
                    _Citas.Decripcion1 = reader.GetString(3);
                    _Citas.Mascota_idMascota1 = int.Parse(reader.GetString(4));
                    _Citas.Servicio_idServicio1 = int.Parse(reader[5].ToString());
                   

                    lista.Add(_Citas);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return lista;
        }

        public bool insertar(DatCitas datos)
        {
            bool bandera = false;

            string sql = "INSERT INTO Citas (Hora, Fecha, Decripcion, Mascota_idMascota, Servicio_idServicio) VALUES ('" + datos.Hora1 + "', '" + datos.Fecha1 + "', '" + datos.Decripcion1 + "', '" + datos.Mascota_idMascota1+ "', '" + datos.Servicio_idServicio1 + "')";

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


        public bool modificar(DatCitas datos)
        {
            bool bandera = false;

            string sql = "UPDATE  Citas SET  Decripcion = '" + datos.Decripcion1 + "', Mascota_idMascota = '" + datos.Mascota_idMascota1 + "', Servicio_idServicio = '" + datos.Servicio_idServicio1 + "'WHERE idCitas='" + datos.IdCitas + "'";

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

            string sql = "DELETE FRom  Citas  WHERE idCitas = '" + id + "'";
             


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
