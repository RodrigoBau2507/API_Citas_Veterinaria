using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria2._0.Clases
{
    internal class Conexion
    {
        public static MySqlConnection ObtenerConnection()
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost; DataBase=Veterinaria3; Uid=root; Pwd=Rodrigo90$;");

            try
            {
                conn.Open();
                MessageBox.Show("Conexion Exitosa");
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            return conn;
        }
    }
}
