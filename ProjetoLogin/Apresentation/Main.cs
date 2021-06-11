using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoLogin.Apresentation;
using ProjetoLogin.Models;

namespace ProjetoLogin
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }        

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // To keep the value
        public static string email;
        public static string rec
        {
            get { return email; }
            set { email = value; }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            rec = txbLogin.Text;
            Controls control = new Controls();
            control.Access(txbLogin.Text, txbPassword.Text);
            if (control.message.Equals(""))
            {
                if (control.has)
                {
                    MessageBox.Show("Login Successfully", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Welcome wc = new Welcome();
                    wc.Show();
                }
                else
                {
                    MessageBox.Show("Login not found, check your login and password", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show(control.message);
            }
        }
    }
}
