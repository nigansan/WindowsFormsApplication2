using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApplication2
{
    class dbConnection
    {
        public static MySqlConnection getDBCon()
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=;persistsecurityinfo=True;database=mplibrary");
            return con;
        }


    }
}
