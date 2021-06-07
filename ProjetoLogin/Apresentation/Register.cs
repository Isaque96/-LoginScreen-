using ProjetoLogin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLogin.Apresentation
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
        }

        private void btnRegRegister_Click(object sender, EventArgs e)
        {
            Controls control = new Controls();
            String message = control.Register(txbRegLogin.Text, txbRegPassword.Text, txbRegConfirm.Text);
            
            if (control.has)
            {
                MessageBox.Show(message, "Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show(control.message);
            }
        }
    }
}
