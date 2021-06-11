using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace ProjetoLogin.DAL
{
    class LoginDALCommands
    {
        public bool has = false;
        public String message = "";
        SqlCommand cmd = new SqlCommand();
        Connection con = new Connection();
        SqlDataReader dr;

        // Verify if SQL has it
        public bool CheckLogin(String login, String password)
        {
            cmd.CommandText = "select * from logIns where email = @login and psword = @password";
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
                con.Disconnect();
                dr.Close();
            }
            catch (SqlException)
            {
                this.message = "Database Error!";
            }
            return has;
        }

        // Insert values in SQL
        public String Register(String email, String password, String confPass, DateTime birthday)
        {
            has = false;
            if (password.Equals(confPass))
            {
                cmd.CommandText = "insert into logIns values (@e,@p,@b);";
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@p", password);
                cmd.Parameters.AddWithValue("@b", birthday);

                try
                {
                    cmd.Connection = con.Connect();
                    cmd.ExecuteNonQuery();
                    con.Disconnect();
                    this.message = "Successfully Registered";
                    has = true;
                } catch (SqlException)
                {
                    this.message = "Database Error!";
                }
            } else
            {
                this.message = "Password doesn't match!";
            }
            return message;
        }

        // Access Birthday Values in SQL 
        public DateTime AccessBirthday(String email)
        {
            DateTime birth = DateTime.Now;
            cmd.CommandText = "select birthday from logIns where email = @e";
            cmd.Parameters.AddWithValue("@e", email);
            try
            {
                cmd.Connection = con.Connect();
                
                birth = (DateTime)cmd.ExecuteScalar();                

                con.Disconnect();                
                has = true;
            }
            catch (SqlException)
            {
                this.message = "Database Error!";
            }

            return birth;
        }

    }
}
