using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.DAL
{
    class LoginDALCommands
    {
        public bool has = false;
        public String message = "";
        SqlCommand cmd = new SqlCommand();
        Connection con = new Connection();
        SqlDataReader dr;

        // Verfica se tem no banco SQL
        public bool CheckLogin(String login, String password)
        {
            cmd.CommandText = "select * from nameOfList where email = @login and password = @password";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@password", password);

            try
            {
                cmd.Connection = con.Connect();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    has = true;
                }
            }
            catch (SqlException)
            {
                this.message = "Erro com o banco de dados!";
            }
            return has;
        }

        // Inseri valores no banco SQL
        public String Register(String email, String password, String confPass)
        {
            return message;
        }
    }
}
