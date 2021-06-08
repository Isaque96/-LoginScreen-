using ProjetoLogin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.Models
{
    public class Controls
    {
        public bool has;
        public String message = "";

        public bool Access(String login, String password)
        {
            LoginDALCommands loginDAL = new LoginDALCommands();
            has = loginDAL.CheckLogin(login, password);

            if (!loginDAL.message.Equals(""))
            {
                this.message = loginDAL.message;
            }
            return has;
        }
        public String Register(String email, String password, String confPass, DateTime birthday)
        {
            LoginDALCommands loginDAL = new LoginDALCommands();
            this.message = loginDAL.Register(email, password, confPass, birthday);

            if (loginDAL.has)
            {
                this.has = true;
            }
            return message;
        }
    }
}
