namespace CoffeeManagement
{
    partial class fChangePassword
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
            panel3 = new System.Windows.Forms.Panel();
            tbNewPassword = new System.Windows.Forms.TextBox();
            lbPassword = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            tbUsername = new System.Windows.Forms.TextBox();
            lbUsername = new System.Windows.Forms.Label();
            btnUpdatePW = new System.Windows.Forms.Button();
            btnCancelChangePW = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            tbReNewPassword = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            tbPassword = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(tbNewPassword);
            panel3.Controls.Add(lbPassword);
            panel3.Location = new System.Drawing.Point(33, 144);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(391, 50);
            panel3.TabIndex = 7;
            // 
            // tbNewPassword
            // 
            tbNewPassword.Location = new System.Drawing.Point(146, 12);
            tbNewPassword.Name = "tbNewPassword";
            tbNewPassword.Size = new System.Drawing.Size(220, 23);
            tbNewPassword.TabIndex = 2;
            tbNewPassword.UseSystemPasswordChar = true;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbPassword.Location = new System.Drawing.Point(12, 13);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(98, 19);
            lbPassword.TabIndex = 0;
            lbPassword.Text = "New Password";
            // 
            // panel1
            // 
            panel1.Controls.Add(tbUsername);
            panel1.Controls.Add(lbUsername);
            panel1.Location = new System.Drawing.Point(33, 32);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(391, 50);
            panel1.TabIndex = 5;
            // 
            // tbUsername
            // 
            tbUsername.Location = new System.Drawing.Point(146, 12);
            tbUsername.Name = "tbUsername";
            tbUsername.ReadOnly = true;
            tbUsername.Size = new System.Drawing.Size(220, 23);
            tbUsername.TabIndex = 0;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbUsername.Location = new System.Drawing.Point(12, 13);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new System.Drawing.Size(74, 19);
            lbUsername.TabIndex = 0;
            lbUsername.Text = "Username:";
            // 
            // btnUpdatePW
            // 
            btnUpdatePW.Location = new System.Drawing.Point(179, 268);
            btnUpdatePW.Name = "btnUpdatePW";
            btnUpdatePW.Size = new System.Drawing.Size(86, 30);
            btnUpdatePW.TabIndex = 9;
            btnUpdatePW.Text = "Update";
            btnUpdatePW.UseVisualStyleBackColor = true;
            btnUpdatePW.Click += btnUpdatePW_Click;
            // 
            // btnCancelChangePW
            // 
            btnCancelChangePW.Location = new System.Drawing.Point(283, 268);
            btnCancelChangePW.Name = "btnCancelChangePW";
            btnCancelChangePW.Size = new System.Drawing.Size(86, 30);
            btnCancelChangePW.TabIndex = 10;
            btnCancelChangePW.Text = "Cancel";
            btnCancelChangePW.UseVisualStyleBackColor = true;
            btnCancelChangePW.Click += btnCancelChangePW_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(tbReNewPassword);
            panel2.Controls.Add(label1);
            panel2.Location = new System.Drawing.Point(33, 200);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(391, 50);
            panel2.TabIndex = 8;
            // 
            // tbReNewPassword
            // 
            tbReNewPassword.Location = new System.Drawing.Point(146, 12);
            tbReNewPassword.Name = "tbReNewPassword";
            tbReNewPassword.Size = new System.Drawing.Size(220, 23);
            tbReNewPassword.TabIndex = 3;
            tbReNewPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(119, 19);
            label1.TabIndex = 0;
            label1.Text = "Re-New Password";
            // 
            // panel4
            // 
            panel4.Controls.Add(tbPassword);
            panel4.Controls.Add(label2);
            panel4.Location = new System.Drawing.Point(33, 88);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(391, 50);
            panel4.TabIndex = 8;
            // 
            // tbPassword
            // 
            tbPassword.Location = new System.Drawing.Point(146, 12);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new System.Drawing.Size(220, 23);
            tbPassword.TabIndex = 1;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(12, 13);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(67, 19);
            label2.TabIndex = 0;
            label2.Text = "Password";
            // 
            // fChangePassword
            // 
            AcceptButton = btnUpdatePW;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancelChangePW;
            ClientSize = new System.Drawing.Size(457, 321);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(btnCancelChangePW);
            Controls.Add(btnUpdatePW);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "fChangePassword";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Change Password";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Button btnUpdatePW;
        private System.Windows.Forms.Button btnCancelChangePW;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbReNewPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label2;
    }
}