using System;
using System.Data.SqlClient;
using ProjetoLogin.DAL;
using System.Windows.Forms;
using ProjetoLogin.Models;

namespace ProjetoLogin.Apresentation
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {            
            LoginDALCommands login = new LoginDALCommands();
            DateTime today = DateTime.Today;
            DateTime birthday = login.AccessBirthday(Main.rec);
            
            lblTD.Text = DateTime.Now.ToShortDateString();
            lblBirthShow.Text = birthday.ToString("dd/MM/yyyy");
            lblUtlBD.Text = login.DaysUtlBD(today, birthday);
        }
    }
}
