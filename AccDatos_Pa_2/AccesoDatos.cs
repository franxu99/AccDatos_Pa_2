using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;

namespace AccDatos_Pa_2
{
    internal class AccesoDatos
    {
        String myConnectionString = "server=localhost;" +
            "port=3306;" +
            "user=root;" +
            "database=sakila;" +
            "password=1234;"
            ;
        MySqlConnection _conn;
        MySqlCommand _cmd;
        public AccesoDatos() {
            try
            {
                _conn = new MySqlConnection(myConnectionString);
                _conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
