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
            return has;
        }
        public String Register(String email, String password, String confPass)
        {
            return message;
        }
    }
}
