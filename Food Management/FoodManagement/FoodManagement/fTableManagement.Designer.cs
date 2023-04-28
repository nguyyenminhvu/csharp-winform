namespace CoffeeManagement
{
    partial class fTableManagement
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            accountDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            changePasswordseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            changeNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            panel2 = new System.Windows.Forms.Panel();
            lvBill = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            panel3 = new System.Windows.Forms.Panel();
            lbDiscount = new System.Windows.Forms.Label();
            txbTotalPrice = new System.Windows.Forms.TextBox();
            lbTotalPrice = new System.Windows.Forms.Label();
            cbChangeTable = new System.Windows.Forms.ComboBox();
            btnChangeTable = new System.Windows.Forms.Button();
            numUPDiscount = new System.Windows.Forms.NumericUpDown();
            button1 = new System.Windows.Forms.Button();
            panel4 = new System.Windows.Forms.Panel();
            lbDisplayNameTable = new System.Windows.Forms.Label();
            numUDCount = new System.Windows.Forms.NumericUpDown();
            btnAddFood = new System.Windows.Forms.Button();
            cbFood = new System.Windows.Forms.ComboBox();
            cbCate = new System.Windows.Forms.ComboBox();
            flpTable = new System.Windows.Forms.FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUPDiscount).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUDCount).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { adminToolStripMenuItem, accountToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { accountDetailsToolStripMenuItem, changePasswordseToolStripMenuItem, changeNameToolStripMenuItem, logOutToolStripMenuItem });
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            accountToolStripMenuItem.Text = "Account";
            // 
            // accountDetailsToolStripMenuItem
            // 
            accountDetailsToolStripMenuItem.Name = "accountDetailsToolStripMenuItem";
            accountDetailsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            accountDetailsToolStripMenuItem.Text = "Account Details";
            accountDetailsToolStripMenuItem.Click += accountDetailsToolStripMenuItem_Click;
            // 
            // changePasswordseToolStripMenuItem
            // 
            changePasswordseToolStripMenuItem.Name = "changePasswordseToolStripMenuItem";
            changePasswordseToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            changePasswordseToolStripMenuItem.Text = "Change Password";
            changePasswordseToolStripMenuItem.Click += changeNameToolStripMenuItem_Click;
            // 
            // changeNameToolStripMenuItem
            // 
            changeNameToolStripMenuItem.Name = "changeNameToolStripMenuItem";
            changeNameToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            changeNameToolStripMenuItem.Text = "Change Name";
            changeNameToolStripMenuItem.Click += changeNameToolStripMenuItem_Click_1;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            logOutToolStripMenuItem.Text = "Log Out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lvBill);
            panel2.Location = new System.Drawing.Point(411, 114);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(377, 251);
            panel2.TabIndex = 2;
            // 
            // lvBill
            // 
            lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvBill.HideSelection = false;
            lvBill.Location = new System.Drawing.Point(0, 0);
            lvBill.Name = "lvBill";
            lvBill.Size = new System.Drawing.Size(377, 251);
            lvBill.TabIndex = 0;
            lvBill.UseCompatibleStateImageBehavior = false;
            lvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name Food";
            columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Quantity";
            columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Price";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Total Price";
            columnHeader4.Width = 70;
            // 
            // panel3
            // 
            panel3.Controls.Add(lbDiscount);
            panel3.Controls.Add(txbTotalPrice);
            panel3.Controls.Add(lbTotalPrice);
            panel3.Controls.Add(cbChangeTable);
            panel3.Controls.Add(btnChangeTable);
            panel3.Controls.Add(numUPDiscount);
            panel3.Controls.Add(button1);
            panel3.Location = new System.Drawing.Point(411, 371);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(377, 67);
            panel3.TabIndex = 3;
            // 
            // lbDiscount
            // 
            lbDiscount.AutoSize = true;
            lbDiscount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbDiscount.Location = new System.Drawing.Point(88, 9);
            lbDiscount.Name = "lbDiscount";
            lbDiscount.Size = new System.Drawing.Size(82, 19);
            lbDiscount.TabIndex = 10;
            lbDiscount.Text = "Discount(%)";
            // 
            // txbTotalPrice
            // 
            txbTotalPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txbTotalPrice.Location = new System.Drawing.Point(175, 35);
            txbTotalPrice.Name = "txbTotalPrice";
            txbTotalPrice.ReadOnly = true;
            txbTotalPrice.Size = new System.Drawing.Size(108, 25);
            txbTotalPrice.TabIndex = 9;
            txbTotalPrice.Text = "0";
            txbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbTotalPrice
            // 
            lbTotalPrice.AutoSize = true;
            lbTotalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbTotalPrice.Location = new System.Drawing.Point(238, 6);
            lbTotalPrice.Name = "lbTotalPrice";
            lbTotalPrice.Size = new System.Drawing.Size(45, 21);
            lbTotalPrice.TabIndex = 8;
            lbTotalPrice.Text = "Total";
            // 
            // cbChangeTable
            // 
            cbChangeTable.FormattingEnabled = true;
            cbChangeTable.Location = new System.Drawing.Point(0, 37);
            cbChangeTable.Name = "cbChangeTable";
            cbChangeTable.Size = new System.Drawing.Size(82, 23);
            cbChangeTable.TabIndex = 7;
            // 
            // btnChangeTable
            // 
            btnChangeTable.Location = new System.Drawing.Point(-1, 3);
            btnChangeTable.Name = "btnChangeTable";
            btnChangeTable.Size = new System.Drawing.Size(64, 28);
            btnChangeTable.TabIndex = 6;
            btnChangeTable.Text = "Change";
            btnChangeTable.UseVisualStyleBackColor = true;
            btnChangeTable.Click += btnChangeTable_Click;
            // 
            // numUPDiscount
            // 
            numUPDiscount.Location = new System.Drawing.Point(92, 38);
            numUPDiscount.Name = "numUPDiscount";
            numUPDiscount.Size = new System.Drawing.Size(63, 23);
            numUPDiscount.TabIndex = 5;
            numUPDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(289, 7);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(88, 53);
            button1.TabIndex = 3;
            button1.Text = "Payment";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnPayment_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(lbDisplayNameTable);
            panel4.Controls.Add(numUDCount);
            panel4.Controls.Add(btnAddFood);
            panel4.Controls.Add(cbFood);
            panel4.Controls.Add(cbCate);
            panel4.Location = new System.Drawing.Point(411, 27);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(377, 81);
            panel4.TabIndex = 4;
            // 
            // lbDisplayNameTable
            // 
            lbDisplayNameTable.AutoSize = true;
            lbDisplayNameTable.Font = new System.Drawing.Font("BIZ UDPGothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbDisplayNameTable.Location = new System.Drawing.Point(195, 17);
            lbDisplayNameTable.Name = "lbDisplayNameTable";
            lbDisplayNameTable.Size = new System.Drawing.Size(0, 15);
            lbDisplayNameTable.TabIndex = 4;
            // 
            // numUDCount
            // 
            numUDCount.Location = new System.Drawing.Point(198, 45);
            numUDCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numUDCount.Name = "numUDCount";
            numUDCount.Size = new System.Drawing.Size(70, 23);
            numUDCount.TabIndex = 3;
            numUDCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            numUDCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new System.Drawing.Point(289, 15);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new System.Drawing.Size(88, 54);
            btnAddFood.TabIndex = 2;
            btnAddFood.Text = "Add Food";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // cbFood
            // 
            cbFood.FormattingEnabled = true;
            cbFood.Location = new System.Drawing.Point(0, 45);
            cbFood.Name = "cbFood";
            cbFood.Size = new System.Drawing.Size(183, 23);
            cbFood.TabIndex = 1;
            // 
            // cbCate
            // 
            cbCate.FormattingEnabled = true;
            cbCate.Location = new System.Drawing.Point(0, 14);
            cbCate.Name = "cbCate";
            cbCate.Size = new System.Drawing.Size(183, 23);
            cbCate.TabIndex = 0;
            cbCate.SelectedIndexChanged += cbCate_SelectedIndexChanged;
            // 
            // flpTable
            // 
            flpTable.AutoScroll = true;
            flpTable.Location = new System.Drawing.Point(12, 27);
            flpTable.Name = "flpTable";
            flpTable.Size = new System.Drawing.Size(393, 411);
            flpTable.TabIndex = 5;
            // 
            // fTableManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(flpTable);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fTableManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Food Management";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUPDiscount).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUDCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbCate;
        private System.Windows.Forms.NumericUpDown numUDCount;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numUPDiscount;
        private System.Windows.Forms.ComboBox cbChangeTable;
        private System.Windows.Forms.Button btnChangeTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.Label lbDisplayNameTable;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.ToolStripMenuItem changePasswordseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeNameToolStripMenuItem;
    }
}