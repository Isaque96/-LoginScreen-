
namespace ProjetoLogin.Apresentation
{
    partial class Welcome
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblToday = new System.Windows.Forms.Label();
            this.lblTD = new System.Windows.Forms.Label();
            this.lblTxtYB = new System.Windows.Forms.Label();
            this.lblBirthShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("NewsGoth BT", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(126, 18);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(214, 48);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "WELCOME";
            // 
            // lblToday
            // 
            this.lblToday.AutoSize = true;
            this.lblToday.Location = new System.Drawing.Point(275, 252);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(83, 15);
            this.lblToday.TabIndex = 2;
            this.lblToday.Text = "Today\'s Date:";
            // 
            // lblTD
            // 
            this.lblTD.AutoSize = true;
            this.lblTD.Location = new System.Drawing.Point(364, 252);
            this.lblTD.Name = "lblTD";
            this.lblTD.Size = new System.Drawing.Size(33, 15);
            this.lblTD.TabIndex = 3;
            this.lblTD.Text = "Date";
            // 
            // lblTxtYB
            // 
            this.lblTxtYB.AutoSize = true;
            this.lblTxtYB.Location = new System.Drawing.Point(22, 252);
            this.lblTxtYB.Name = "lblTxtYB";
            this.lblTxtYB.Size = new System.Drawing.Size(99, 15);
            this.lblTxtYB.TabIndex = 4;
            this.lblTxtYB.Text = "Your Birthday is:";
            // 
            // lblBirthShow
            // 
            this.lblBirthShow.AutoSize = true;
            this.lblBirthShow.Location = new System.Drawing.Point(127, 252);
            this.lblBirthShow.Name = "lblBirthShow";
            this.lblBirthShow.Size = new System.Drawing.Size(33, 15);
            this.lblBirthShow.TabIndex = 5;
            this.lblBirthShow.Text = "Birth";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 281);
            this.Controls.Add(this.lblBirthShow);
            this.Controls.Add(this.lblTxtYB);
            this.Controls.Add(this.lblTD);
            this.Controls.Add(this.lblToday);
            this.Controls.Add(this.lblWelcome);
            this.Font = new System.Drawing.Font("NewsGoth BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Label lblTD;
        private System.Windows.Forms.Label lblTxtYB;
        private System.Windows.Forms.Label lblBirthShow;
    }
}