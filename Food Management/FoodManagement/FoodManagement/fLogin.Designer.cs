namespace CoffeeManagement
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new System.Windows.Forms.Panel();
            tbUsername = new System.Windows.Forms.TextBox();
            lbUsername = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            tbPassword = new System.Windows.Forms.TextBox();
            lbPassword = new System.Windows.Forms.Label();
            btnLogin = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tbUsername);
            panel1.Controls.Add(lbUsername);
            panel1.Location = new System.Drawing.Point(12, 22);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(391, 50);
            panel1.TabIndex = 0;
            // 
            // tbUsername
            // 
            tbUsername.Location = new System.Drawing.Point(126, 12);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new System.Drawing.Size(220, 23);
            tbUsername.TabIndex = 1;
            tbUsername.Text = "admin";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbUsername.Location = new System.Drawing.Point(24, 14);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new System.Drawing.Size(81, 21);
            lbUsername.TabIndex = 0;
            lbUsername.Text = "Username";
            // 
            // panel2
            // 
            panel2.Controls.Add(tbPassword);
            panel2.Controls.Add(lbPassword);
            panel2.Location = new System.Drawing.Point(12, 78);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(391, 50);
            panel2.TabIndex = 2;
            // 
            // tbPassword
            // 
            tbPassword.Location = new System.Drawing.Point(126, 12);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new System.Drawing.Size(220, 23);
            tbPassword.TabIndex = 2;
            tbPassword.Text = "1";
            tbPassword.UseSystemPasswordChar = true;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbPassword.Location = new System.Drawing.Point(24, 14);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(76, 21);
            lbPassword.TabIndex = 0;
            lbPassword.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new System.Drawing.Point(138, 145);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(102, 29);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(256, 145);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(102, 29);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // fLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(412, 196);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = " Food Management";
            FormClosing += fLogin_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
    }
}
