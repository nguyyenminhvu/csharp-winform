using CoffeeManagement.DAO;
using CoffeeManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class fTableManagement : Form
    {
        private Account loginAccount;

        public Account LoginAccount { get => loginAccount; set { loginAccount = value; } }
        public fTableManagement()
        {
        }
        public fTableManagement(Account account)
        {
            this.loginAccount = account;
            InitializeComponent();
            loadTable();
            loadCategory();
            Authorizations(loginAccount.Type);
        }
        public void Authorizations(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            accountToolStripMenuItem.Text += " ( " + loginAccount.Name + " )";
        }
        void loadTable()
        {
            List<Table> listTable = TableDAO.Instance.loadListTable();
            foreach (Table item in listTable)
            {
                Button button = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight, Text = item.name + "\n" + $"({item.status})" };
                button.Click += btn_click;
                button.Tag = item;
                switch (item.status)
                {
                    case "Active": button.BackColor = Color.DarkOrange; break;
                    default: break;
                }
                flpTable.Controls.Add(button);
            }
            cbChangeTable.DataSource = listTable;
            cbChangeTable.DisplayMember = "Name";
        }
        void loadCategory()
        {
            cbCate.DataSource = CategoryDAO.Instance.getAllCategories();
            cbCate.DisplayMember = "Name";
        }
        void ShowBill(int id)
        {
            lvBill.Items.Clear();
            int idBill = BillDAO.Instance.getBillUncheckByTableId(id);
            double total = 0;
            if (idBill > 0)
            {
                List<Menu> listMenuInfo = MenuDAO.Instance.getListMenuByTableId(id);
                foreach (Menu item in listMenuInfo)
                {
                    ListViewItem lsvItem = new ListViewItem(item.Name.ToString());
                    lsvItem.SubItems.Add(item.Count.ToString());
                    lsvItem.SubItems.Add(item.Price.ToString());
                    lsvItem.SubItems.Add(item.TotalPrice.ToString());
                    total += item.TotalPrice;
                    lvBill.Items.Add(lsvItem);
                }
                if (listMenuInfo.Count() > 0 && total > 0)
                {
                    ListViewItem listView = new ListViewItem();
                    listView.SubItems.Add(" ");
                    listView.SubItems.Add("Total: ");
                    listView.SubItems.Add($"{total}");
                    lvBill.Items.Add(listView);
                }

            }
            CultureInfo cultureInfo = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            txbTotalPrice.Text = total.ToString("c", cultureInfo);

        }
        private void btn_click(object sender, EventArgs e)
        {
            int id = ((sender as Button).Tag as Table).id;
            lbDisplayNameTable.Text = ((sender as Button).Tag as Table).name;
            lbDisplayNameTable.Tag = (sender as Button).Tag as Table;
            lvBill.Tag = (sender as Button).Tag; //listview cua table da nhan vao nut
            ShowBill(id);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accountDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountDetails fAccountDetails = new fAccountDetails(loginAccount);
            fAccountDetails.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin fAdmin = new fAdmin();
            fAdmin.ShowDialog();
        }
        void loadFoodByIdCate(int id)
        {
            List<Food> foods = FoodDAO.Instance.getFoodByIdCate(id);
            cbFood.DataSource = foods;
            cbFood.DisplayMember = "Name";
        }
        private void cbCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = ((Category)cbCate.SelectedItem).Id;
            loadFoodByIdCate(id);
        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            int numDiscount = (int)numUPDiscount.Value;
            int quantity = (int)numUDCount.Value;
            int idFood = (int)(cbFood.SelectedItem as Food).Id;
            Table table = lvBill.Tag as Table;
            if (table != null)
            {
                int idBill = BillDAO.Instance.getBillUncheckByTableId(table.id);
                if (idBill == -1)
                {
                    BillDAO.Instance.insertBill(table.id, numDiscount);
                    idBill = BillDAO.Instance.getBillUncheckByTableId(table.id);
                    BillInfoDAO.Instance.InsertBillInfo(idBill, idFood, quantity);
                    TableDAO.Instance.updateStatusTable(table.id, "Active");
                    flpTable.Controls.Clear();
                    loadTable();
                    ShowBill(table.id);
                }
                else
                {
                    BillInfoDAO.Instance.InsertBillInfo(idBill, idFood, quantity);
                    ShowBill(table.id);
                }
            }
            else
            {
                MessageBox.Show("Please choose table ", "Food Management");
            }
        }
        private void btnPayment_Click(object sender, EventArgs e)
        {
            Table table = lvBill.Tag as Table;
            int idTable = (lvBill.Tag as Table).id;
            int discount = (int)numUPDiscount.Value;
            float totalMoney = float.Parse(txbTotalPrice.Text.Split(" ")[0].Trim());
            float totalMoneyWithDiscount = totalMoney - totalMoney * ((float)discount / 100);
            int idBill = BillDAO.Instance.getBillUncheckByTableId(idTable);
            if (idBill > 0)
            {
                if (MessageBox.Show("You want payment for " + table.name + " with discount: " + discount + " % \nTotal Money: " + totalMoneyWithDiscount, "Coffee Management", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.paymentBill(idBill, discount, totalMoneyWithDiscount);
                    TableDAO.Instance.updateStatusTable(idTable, "No Body");
                    flpTable.Controls.Clear();
                    loadTable();
                    ShowBill(idTable);
                };
            }
        }

        private void btnChangeTable_Click(object sender, EventArgs e)
        {
            Table TableNew = cbChangeTable.SelectedItem as Table;
            Table TableOld = lbDisplayNameTable.Tag as Table;
            if (TableOld.status.Equals("Active"))
            {
                int idNew = BillDAO.Instance.getBillUncheckByTableId(TableNew.id);
                if (idNew < 0)
                {
                    idNew = 1;
                }
                int idOld = BillDAO.Instance.getBillUncheckByTableId(TableOld.id);
                if (MessageBox.Show($"Do you want switch from {TableOld.name} to {TableNew.name}", "Food Management", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.changeTable(TableNew.id, TableOld.id, idNew, idOld);
                    flpTable.Controls.Clear();
                    loadTable();
                    lbDisplayNameTable.Text = TableNew.name;
                }
            }
        }

        private void changeNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fChangePassword fChangePasswod = new fChangePassword(loginAccount);
            fChangePasswod.ShowDialog();
        }

        private void changeNameToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fChangeName fChangeName = new fChangeName(loginAccount);
            fChangeName.ShowDialog();
        }
    }
}
