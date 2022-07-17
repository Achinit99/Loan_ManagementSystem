using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan
{
    class clsConnection
    {
        const String cs = @"server=localhost;userid=root;password=1234;database=loan";
        public static MySqlConnection con = new MySqlConnection(cs);

        public static void open_connection()
        {


            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            else
            {
                return;
            }

        }
        public static void close_connection()
        {


            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            else
            {
                return;
            }

        }
    }
}
