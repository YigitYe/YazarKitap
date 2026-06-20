using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DBOpsLayeredArch.Facade
{
    internal class Connection
    {
        public static SqlConnection con = new SqlConnection();

        public static void connect()
        {
         string cs = ConfigurationManager.ConnectionStrings["conStr1"].ConnectionString;   
            con.ConnectionString = cs;
            if (con.State == ConnectionState.Open) return;
            con.Open();
        }

        public static void disconnect()
        {
            if (con.State == ConnectionState.Closed) return;
            con.Close();
        }

    }
}
