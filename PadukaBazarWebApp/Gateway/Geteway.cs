using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PadukaBazarWebApp.Gateway
{
    public class Geteway
    {
        public class Gatway
        {
            public string connectionString = ConfigurationManager.ConnectionStrings["PadukaBazar_DB"].ConnectionString;
            public SqlConnection Connection { get; set; }
            public SqlCommand Command { get; set; }
            public SqlDataReader Reader { get; set; }
            public string Query { get; set; }

            public Gatway()
            {
                Connection = new SqlConnection(connectionString);
                Command = new SqlCommand();
                Command.Connection = Connection;
            }

        }
    }
}