using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.DAL
{
    public class Connection
    {
        SqlConnection con = new SqlConnection();

        public Connection()
        {
            con.ConnectionString = @"Data Source=ZACK-PC\SQLEXPRESS;Initial Catalog=ProjectLogin;Integrated Security=True";
        }

        public SqlConnection Connect()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }

        public void Disconnect()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
