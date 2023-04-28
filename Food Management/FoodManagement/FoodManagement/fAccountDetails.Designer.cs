namespace CoffeeManagement
{
    partial class fAccountDetails
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
            panel1 = new System.Windows.Forms.Panel();
            tbUsername = new System.Windows.Forms.TextBox();
            lbUsername = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            tbDisplayName = new System.Windows.Forms.TextBox();
            lbDisplayName = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            tbPassword = new System.Windows.Forms.TextBox();
            lbPassword = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            tbRole = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btnCancel = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tbUsername);
            panel1.Controls.Add(lbUsername);
            panel1.Location = new System.Drawing.Point(12, 28);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(391, 50);
            panel1.TabIndex = 1;
            // 
            // tbUsername
            // 
            tbUsername.Location = new System.Drawing.Point(146, 12);
            tbUsername.Name = "tbUsername";
            tbUsername.ReadOnly = true;
            tbUsername.Size = new System.Drawing.Size(220, 23);
            tbUsername.TabIndex = 1;
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
            // panel2
            // 
            panel2.Controls.Add(tbDisplayName);
            panel2.Controls.Add(lbDisplayName);
            panel2.Location = new System.Drawing.Point(12, 84);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(391, 50);
            panel2.TabIndex = 2;
            // 
            // tbDisplayName
            // 
            tbDisplayName.Location = new System.Drawing.Point(146, 12);
            tbDisplayName.Name = "tbDisplayName";
            tbDisplayName.ReadOnly = true;
            tbDisplayName.Size = new System.Drawing.Size(220, 23);
            tbDisplayName.TabIndex = 1;
            // 
            // lbDisplayName
            // 
            lbDisplayName.AutoSize = true;
            lbDisplayName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbDisplayName.Location = new System.Drawing.Point(12, 13);
            lbDisplayName.Name = "lbDisplayName";
            lbDisplayName.Size = new System.Drawing.Size(48, 19);
            lbDisplayName.TabIndex = 0;
            lbDisplayName.Text = "Name:";
            // 
            // panel3
            // 
            panel3.Controls.Add(tbPassword);
            panel3.Controls.Add(lbPassword);
            panel3.Location = new System.Drawing.Point(12, 140);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(391, 50);
            panel3.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.Location = new System.Drawing.Point(146, 12);
            tbPassword.Name = "tbPassword";
            tbPassword.ReadOnly = true;
            tbPassword.Size = new System.Drawing.Size(220, 23);
            tbPassword.TabIndex = 2;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbPassword.Location = new System.Drawing.Point(12, 13);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(67, 19);
            lbPassword.TabIndex = 0;
            lbPassword.Text = "Password";
            // 
            // panel4
            // 
            panel4.Controls.Add(tbRole);
            panel4.Controls.Add(label1);
            panel4.Location = new System.Drawing.Point(12, 196);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(391, 50);
            panel4.TabIndex = 4;
            // 
            // tbRole
            // 
            tbRole.Location = new System.Drawing.Point(146, 12);
            tbRole.Name = "tbRole";
            tbRole.ReadOnly = true;
            tbRole.Size = new System.Drawing.Size(220, 23);
            tbRole.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(35, 19);
            label1.TabIndex = 0;
            label1.Text = "Role";
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(158, 264);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(82, 31);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Back";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // fAccountDetails
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(415, 317);
            Controls.Add(btnCancel);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fAccountDetails";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Account Details";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbDisplayName;
        private System.Windows.Forms.Label lbDisplayName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
    }
}