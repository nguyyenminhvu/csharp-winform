namespace CoffeeManagement
{
    partial class fChangeName
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
            panel4 = new System.Windows.Forms.Panel();
            tbDisplayName = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            tbPassword = new System.Windows.Forms.TextBox();
            lbPassword = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            tbUsername = new System.Windows.Forms.TextBox();
            lbUsername = new System.Windows.Forms.Label();
            btnCancelName = new System.Windows.Forms.Button();
            btnUpdateName = new System.Windows.Forms.Button();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Controls.Add(tbDisplayName);
            panel4.Controls.Add(label2);
            panel4.Location = new System.Drawing.Point(37, 89);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(391, 50);
            panel4.TabIndex = 12;
            // 
            // tbDisplayName
            // 
            tbDisplayName.Location = new System.Drawing.Point(146, 12);
            tbDisplayName.Name = "tbDisplayName";
            tbDisplayName.Size = new System.Drawing.Size(220, 23);
            tbDisplayName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(12, 13);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(96, 19);
            label2.TabIndex = 0;
            label2.Text = "Display Name:";
            // 
            // panel3
            // 
            panel3.Controls.Add(tbPassword);
            panel3.Controls.Add(lbPassword);
            panel3.Location = new System.Drawing.Point(37, 145);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(391, 50);
            panel3.TabIndex = 10;
            // 
            // tbPassword
            // 
            tbPassword.Location = new System.Drawing.Point(146, 12);
            tbPassword.Name = "tbPassword";
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
            // panel1
            // 
            panel1.Controls.Add(tbUsername);
            panel1.Controls.Add(lbUsername);
            panel1.Location = new System.Drawing.Point(37, 33);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(391, 50);
            panel1.TabIndex = 9;
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
            // btnCancelName
            // 
            btnCancelName.Location = new System.Drawing.Point(275, 205);
            btnCancelName.Name = "btnCancelName";
            btnCancelName.Size = new System.Drawing.Size(86, 30);
            btnCancelName.TabIndex = 4;
            btnCancelName.Text = "Cancel";
            btnCancelName.UseVisualStyleBackColor = true;
            btnCancelName.Click += btnCancelName_Click;
            // 
            // btnUpdateName
            // 
            btnUpdateName.Location = new System.Drawing.Point(183, 205);
            btnUpdateName.Name = "btnUpdateName";
            btnUpdateName.Size = new System.Drawing.Size(86, 30);
            btnUpdateName.TabIndex = 3;
            btnUpdateName.Text = "Update";
            btnUpdateName.UseVisualStyleBackColor = true;
            btnUpdateName.Click += btnUpdateName_Click;
            // 
            // fChangeName
            // 
            AcceptButton = btnUpdateName;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancelName;
            ClientSize = new System.Drawing.Size(469, 254);
            Controls.Add(btnUpdateName);
            Controls.Add(btnCancelName);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "fChangeName";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Change Name";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbDisplayName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Button btnCancelName;
        private System.Windows.Forms.Button btnUpdateName;
    }
}