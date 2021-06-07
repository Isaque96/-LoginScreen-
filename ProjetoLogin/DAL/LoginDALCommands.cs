using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.DAL
{
    class LoginDALCommands
    {
        public bool has;
        public String message;

        // Verfica se tem no banco SQL
        public bool CheckLogin(String login, String password)
        {
            return has;
        }

        // Inseri valores no banco SQL
        public String Register(String email, String password, String confPass)
        {
            return message;
        }
    }
}
