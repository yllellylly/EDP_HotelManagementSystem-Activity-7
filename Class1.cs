using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Hotel_System
{
    internal class DB
    {
    }

    public class DBConnection
    {
        public static string connStr = "server=localhost;user=admin1;password=admin123;database=hotel;";
        public static MySqlConnection connection = new MySqlConnection(connStr);
    }
}
