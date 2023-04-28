namespace CoffeeManagement
{
    partial class fCreateCategory
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
            tbCaegoryNameAdd = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            btnCategoryAdd = new System.Windows.Forms.Button();
            btnCancelName = new System.Windows.Forms.Button();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Controls.Add(tbCaegoryNameAdd);
            panel4.Controls.Add(label2);
            panel4.Location = new System.Drawing.Point(12, 21);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(391, 50);
            panel4.TabIndex = 13;
            // 
            // tbCaegoryNameAdd
            // 
            tbCaegoryNameAdd.Location = new System.Drawing.Point(146, 12);
            tbCaegoryNameAdd.Name = "tbCaegoryNameAdd";
            tbCaegoryNameAdd.Size = new System.Drawing.Size(220, 23);
            tbCaegoryNameAdd.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(12, 13);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(108, 19);
            label2.TabIndex = 0;
            label2.Text = "Name Category:";
            // 
            // btnCategoryAdd
            // 
            btnCategoryAdd.Location = new System.Drawing.Point(158, 86);
            btnCategoryAdd.Name = "btnCategoryAdd";
            btnCategoryAdd.Size = new System.Drawing.Size(86, 30);
            btnCategoryAdd.TabIndex = 14;
            btnCategoryAdd.Text = "Create";
            btnCategoryAdd.UseVisualStyleBackColor = true;
            btnCategoryAdd.Click += btnCategoryAdd_Click;
            // 
            // btnCancelName
            // 
            btnCancelName.Location = new System.Drawing.Point(250, 86);
            btnCancelName.Name = "btnCancelName";
            btnCancelName.Size = new System.Drawing.Size(86, 30);
            btnCancelName.TabIndex = 15;
            btnCancelName.Text = "Cancel";
            btnCancelName.UseVisualStyleBackColor = true;
            btnCancelName.Click += btnCancelName_Click;
            // 
            // fCreateCategory
            // 
            AcceptButton = btnCategoryAdd;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancelName;
            ClientSize = new System.Drawing.Size(418, 136);
            Controls.Add(btnCategoryAdd);
            Controls.Add(btnCancelName);
            Controls.Add(panel4);
            Name = "fCreateCategory";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Create Category";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbCaegoryNameAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCategoryAdd;
        private System.Windows.Forms.Button btnCancelName;
    }
}