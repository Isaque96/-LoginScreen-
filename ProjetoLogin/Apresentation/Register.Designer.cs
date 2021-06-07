
namespace ProjetoLogin.Apresentation
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRegisterLogin = new System.Windows.Forms.Label();
            this.lblRegisterPassword = new System.Windows.Forms.Label();
            this.lblRegisterConfirm = new System.Windows.Forms.Label();
            this.btnRegRegister = new System.Windows.Forms.Button();
            this.txbRegLogin = new System.Windows.Forms.TextBox();
            this.txbRegPassword = new System.Windows.Forms.TextBox();
            this.txbRegConfirm = new System.Windows.Forms.TextBox();
            this.lblRegisterBirthday = new System.Windows.Forms.Label();
            this.dtpRegBirthday = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblRegisterLogin
            // 
            this.lblRegisterLogin.AutoSize = true;
            this.lblRegisterLogin.Location = new System.Drawing.Point(32, 49);
            this.lblRegisterLogin.Name = "lblRegisterLogin";
            this.lblRegisterLogin.Size = new System.Drawing.Size(45, 15);
            this.lblRegisterLogin.TabIndex = 0;
            this.lblRegisterLogin.Text = "LOGIN";
            // 
            // lblRegisterPassword
            // 
            this.lblRegisterPassword.AutoSize = true;
            this.lblRegisterPassword.Location = new System.Drawing.Point(32, 85);
            this.lblRegisterPassword.Name = "lblRegisterPassword";
            this.lblRegisterPassword.Size = new System.Drawing.Size(75, 15);
            this.lblRegisterPassword.TabIndex = 1;
            this.lblRegisterPassword.Text = "PASSWORD";
            // 
            // lblRegisterConfirm
            // 
            this.lblRegisterConfirm.AutoSize = true;
            this.lblRegisterConfirm.Location = new System.Drawing.Point(32, 127);
            this.lblRegisterConfirm.Name = "lblRegisterConfirm";
            this.lblRegisterConfirm.Size = new System.Drawing.Size(135, 15);
            this.lblRegisterConfirm.TabIndex = 2;
            this.lblRegisterConfirm.Text = "CONFIRM PASSWORD";
            // 
            // btnRegRegister
            // 
            this.btnRegRegister.Font = new System.Drawing.Font("NewsGoth BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegRegister.Location = new System.Drawing.Point(191, 227);
            this.btnRegRegister.Name = "btnRegRegister";
            this.btnRegRegister.Size = new System.Drawing.Size(106, 31);
            this.btnRegRegister.TabIndex = 3;
            this.btnRegRegister.Text = "REGISTER";
            this.btnRegRegister.UseVisualStyleBackColor = true;
            this.btnRegRegister.Click += new System.EventHandler(this.btnRegRegister_Click);
            // 
            // txbRegLogin
            // 
            this.txbRegLogin.Location = new System.Drawing.Point(209, 49);
            this.txbRegLogin.Name = "txbRegLogin";
            this.txbRegLogin.Size = new System.Drawing.Size(196, 23);
            this.txbRegLogin.TabIndex = 4;
            // 
            // txbRegPassword
            // 
            this.txbRegPassword.Location = new System.Drawing.Point(209, 85);
            this.txbRegPassword.Name = "txbRegPassword";
            this.txbRegPassword.Size = new System.Drawing.Size(196, 23);
            this.txbRegPassword.TabIndex = 5;
            // 
            // txbRegConfirm
            // 
            this.txbRegConfirm.Location = new System.Drawing.Point(209, 127);
            this.txbRegConfirm.Name = "txbRegConfirm";
            this.txbRegConfirm.Size = new System.Drawing.Size(196, 23);
            this.txbRegConfirm.TabIndex = 6;
            // 
            // lblRegisterBirthday
            // 
            this.lblRegisterBirthday.AutoSize = true;
            this.lblRegisterBirthday.Location = new System.Drawing.Point(32, 169);
            this.lblRegisterBirthday.Name = "lblRegisterBirthday";
            this.lblRegisterBirthday.Size = new System.Drawing.Size(67, 15);
            this.lblRegisterBirthday.TabIndex = 7;
            this.lblRegisterBirthday.Text = "BIRTHDAY";
            // 
            // dtpRegBirthday
            // 
            this.dtpRegBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRegBirthday.Location = new System.Drawing.Point(209, 169);
            this.dtpRegBirthday.Name = "dtpRegBirthday";
            this.dtpRegBirthday.Size = new System.Drawing.Size(200, 23);
            this.dtpRegBirthday.TabIndex = 8;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 281);
            this.Controls.Add(this.dtpRegBirthday);
            this.Controls.Add(this.lblRegisterBirthday);
            this.Controls.Add(this.txbRegConfirm);
            this.Controls.Add(this.txbRegPassword);
            this.Controls.Add(this.txbRegLogin);
            this.Controls.Add(this.btnRegRegister);
            this.Controls.Add(this.lblRegisterConfirm);
            this.Controls.Add(this.lblRegisterPassword);
            this.Controls.Add(this.lblRegisterLogin);
            this.Font = new System.Drawing.Font("NewsGoth BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegisterLogin;
        private System.Windows.Forms.Label lblRegisterPassword;
        private System.Windows.Forms.Label lblRegisterConfirm;
        private System.Windows.Forms.Button btnRegRegister;
        private System.Windows.Forms.TextBox txbRegLogin;
        private System.Windows.Forms.TextBox txbRegPassword;
        private System.Windows.Forms.TextBox txbRegConfirm;
        private System.Windows.Forms.Label lblRegisterBirthday;
        private System.Windows.Forms.DateTimePicker dtpRegBirthday;
    }
}