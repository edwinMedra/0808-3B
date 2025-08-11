using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace _0808_3B
{
    internal class conexionDB
    {

        private string conexion = "host=localhost;user=root;password=;database=miniBank;";

        public MySqlConnection ObtenerConexion()
        {
            MySqlConnection conn = new MySqlConnection(conexion);
            conn.Open();
            return conn;
        }

        

    }
}
