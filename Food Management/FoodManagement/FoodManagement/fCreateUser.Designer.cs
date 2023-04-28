namespace CoffeeManagement
{
    partial class fCreateUser
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
            panel2 = new System.Windows.Forms.Panel();
            tbRePassword = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            tbPassword = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            tbUsername = new System.Windows.Forms.TextBox();
            lbUsername = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            tbFullname = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            btnCancelCreate = new System.Windows.Forms.Button();
            btnCreate = new System.Windows.Forms.Button();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(tbRePassword);
            panel2.Controls.Add(label1);
            panel2.Location = new System.Drawing.Point(38, 206);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(391, 50);
            panel2.TabIndex = 3;
            // 
            // tbRePassword
            // 
            tbRePassword.Location = new System.Drawing.Point(146, 12);
            tbRePassword.Name = "tbRePassword";
            tbRePassword.Size = new System.Drawing.Size(220, 23);
            tbRePassword.TabIndex = 3;
            tbRePassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(91, 19);
            label1.TabIndex = 0;
            label1.Text = "Re-Password:";
            // 
            // panel4
            // 
            panel4.Controls.Add(tbPassword);
            panel4.Controls.Add(label2);
            panel4.Location = new System.Drawing.Point(38, 150);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(391, 50);
            panel4.TabIndex = 2;
            // 
            // tbPassword
            // 
            tbPassword.Location = new System.Drawing.Point(146, 12);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new System.Drawing.Size(220, 23);
            tbPassword.TabIndex = 2;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(12, 13);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(70, 19);
            label2.TabIndex = 0;
            label2.Text = "Password:";
            // 
            // panel1
            // 
            panel1.Controls.Add(tbUsername);
            panel1.Controls.Add(lbUsername);
            panel1.Location = new System.Drawing.Point(38, 38);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(391, 50);
            panel1.TabIndex = 0;
            // 
            // tbUsername
            // 
            tbUsername.Location = new System.Drawing.Point(146, 12);
            tbUsername.Name = "tbUsername";
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
            // panel3
            // 
            panel3.Controls.Add(tbFullname);
            panel3.Controls.Add(label3);
            panel3.Location = new System.Drawing.Point(38, 94);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(391, 50);
            panel3.TabIndex = 1;
            // 
            // tbFullname
            // 
            tbFullname.Location = new System.Drawing.Point(146, 12);
            tbFullname.Name = "tbFullname";
            tbFullname.Size = new System.Drawing.Size(220, 23);
            tbFullname.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(12, 13);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(67, 19);
            label3.TabIndex = 0;
            label3.Text = "Fullname:";
            // 
            // btnCancelCreate
            // 
            btnCancelCreate.Location = new System.Drawing.Point(288, 274);
            btnCancelCreate.Name = "btnCancelCreate";
            btnCancelCreate.Size = new System.Drawing.Size(86, 30);
            btnCancelCreate.TabIndex = 5;
            btnCancelCreate.Text = "Cancel";
            btnCancelCreate.UseVisualStyleBackColor = true;
            btnCancelCreate.Click += btnCancelCreate_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new System.Drawing.Point(184, 274);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(86, 30);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // fCreateUser
            // 
            AcceptButton = btnCreate;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancelCreate;
            ClientSize = new System.Drawing.Size(466, 330);
            Controls.Add(btnCancelCreate);
            Controls.Add(btnCreate);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "fCreateUser";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Create User";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbRePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbFullname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelCreate;
        private System.Windows.Forms.Button btnCreate;
    }
}