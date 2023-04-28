using CoffeeManagement.DAO;
using CoffeeManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class fAdmin : Form
    {
        BindingSource bindingSourceFood = new BindingSource();
        BindingSource bindingSourceAccount = new BindingSource();
        BindingSource bindingSourceCategory = new BindingSource();
        BindingSource bindingSourceTable = new BindingSource();
        public fAdmin()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            dtgvFood.DataSource = bindingSourceFood; // dat o vi tri nay, boi vi phai gan  dtgvFood.DataSource = bindingSource trc 
            dtgvAccounts.DataSource = bindingSourceAccount;
            dtgvCategories.DataSource = bindingSourceCategory;
            dtgvTableFood.DataSource = bindingSourceTable;
            LoadRoleAccount();
            LoadAccountList();
            LoadFoodList();
            LoadDateTimePicker();
            LoadFoodBinding();
            LoadAccountBinding();
            LoadCategory(cbCategoryFood);
            LoadCategoryList();
            LoadBindingCategoryList();
            LoadTableList();
            LoadBindingTable();

        }
        void LoadTableList()
        {
            bindingSourceTable.DataSource = TableDAO.Instance.LoadListTableWithoutStatus();
        }
        void LoadBindingTable()
        {
            txbTableId.DataBindings.Add(new Binding("Text", dtgvTableFood.DataSource, "id"));
            txbNameTable.DataBindings.Add(new Binding("Text", dtgvTableFood.DataSource, "name"));
        }
        void LoadCategoryList()
        {
            bindingSourceCategory.DataSource = CategoryDAO.Instance.getAllCategories();
        }
        void LoadBindingCategoryList()
        {
            txbCategoryId.DataBindings.Add(new Binding("Text", dtgvCategories.DataSource, "id"));
            txbCategoryName.DataBindings.Add(new Binding("Text", dtgvCategories.DataSource, "name"));
        }
        void LoadDateTimePicker()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }
        void LoadAccountList()
        {

            bindingSourceAccount.DataSource = AccountDAO.Instance.GetAllUser();
        }
        void LoadAccountBinding()
        {
            tbUserAccount.DataBindings.Add(new Binding("Text", dtgvAccounts.DataSource, "Username"));
            tbNameAccount.DataBindings.Add(new Binding("Text", dtgvAccounts.DataSource, "Name"));
        }
        void LoadRoleAccount()
        {
            List<int> type = new List<int>();
            type.Add(0);
            type.Add(1);
            cbRoleAccount.DataSource = type;

        }
        void LoadFoodList()
        {

            bindingSourceFood.DataSource = FoodDAO.Instance.LoadAllFood();


        }
        Category getCategory(int id)
        {
            return CategoryDAO.Instance.GetCategoryById(id);
        }
        void LoadFoodBinding()
        {
            txbNameFood.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "name"));
            txbFoodId.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "id"));
            nmFoodPrice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "price"));

        }
        public void LoadCategory(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.getAllCategories();
            cb.DisplayMember = "Name";
            cb.ValueMember = "id";
        }
        private void btnViewBill_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = dtpkFromDate.Value.Date;
            DateTime dateTo = dtpkToDate.Value.Date;
            List<StatisticBill> listStatisticBill = StatisticBillDAO.Instance.getListBillWithChecked(dateFrom, dateTo);
            dtgvBill.DataSource = listStatisticBill;
            dtgvBill.Columns[0].Width = 125;
            dtgvBill.Columns[1].Width = 125;
            dtgvBill.Columns[2].Width = 160;
            dtgvBill.Columns[3].Width = 160;
            dtgvBill.Columns[4].Width = 125;
        }

        private void btnViewFood_Click(object sender, EventArgs e)
        {
            LoadFoodList();
        }

        private void txbFoodId_TextChanged(object sender, EventArgs e)
        {
            if (dtgvFood.SelectedCells.Count > 0)
            {
                int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["idCategory"].Value;
                Category category = CategoryDAO.Instance.GetCategoryById(id);
                //  int index = -1;
                // int i = 0;
                //foreach (Category item in cbCategoryFood.Items) bai hc quy gia ve kieu tra ve
                //{
                //    if (item.Id == category.Id)
                //    {
                //        index=i; break;
                //    }
                //    i++;
                //}
                cbCategoryFood.SelectedValue = category.Id;
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = txbNameFood.Text;
            int idCate = (int)cbCategoryFood.SelectedValue;
            double price = (double)nmFoodPrice.Value;
            if (FoodDAO.Instance.InsertFood(name, idCate, price))
            {
                MessageBox.Show("Add Food successful !!", "Food Management");
            }
            else
            {
                MessageBox.Show("Add Fail !", "Food Management");
            }
        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            string name = txbNameFood.Text;
            int idCate = (int)cbCategoryFood.SelectedValue;
            double price = (double)nmFoodPrice.Value;
            int id = int.Parse(txbFoodId.Text);
            if (FoodDAO.Instance.UpdateFood(id, name, idCate, price))
            {
                MessageBox.Show("Update Food successful !!", "Food Management");
            }
            else
            {
                MessageBox.Show("Update Fail !", "Food Management");
            }
        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            string foodSearch = txbFoodNameSearch.Text;
            bindingSourceFood.DataSource = FoodDAO.Instance.GetFoodByName(foodSearch);
        }

        private void btnAccountAdd_Click(object sender, EventArgs e)
        {
            fCreateUser fCreateUser = new fCreateUser();
            fCreateUser.ShowDialog();
        }

        private void tbUserAccount_TextChanged(object sender, EventArgs e)
        {
            if (dtgvAccounts.SelectedCells.Count > 0)
            {
                if (dtgvAccounts.SelectedCells[0].OwningRow.Cells["type"].Value != null)
                {
                    int id = (int)dtgvAccounts.SelectedCells[0].OwningRow.Cells["type"].Value;
                    cbRoleAccount.SelectedItem = id;
                }

            }
        }

        private void btnViewAccount_Click(object sender, EventArgs e)
        {
            LoadAccountList();
        }

        private void btnAccountUpdate_Click(object sender, EventArgs e)
        {
            string fullname = tbNameAccount.Text;
            int role = (int)cbRoleAccount.SelectedItem;
            string username = tbUserAccount.Text;
            if (!string.IsNullOrEmpty(fullname))
            {
                MessageBox.Show(AccountDAO.Instance.UpdateUser(fullname, role, username) ? "Update successful!" : "Update fail !");
                LoadAccountList();
            }
            else
            {
                MessageBox.Show("Fill all blank please !", "Food Management");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string namesearch = tbSearchAccount.Text;
            if (!string.IsNullOrEmpty(namesearch))
            {
                bindingSourceAccount.DataSource = AccountDAO.Instance.SearchAccountByName(namesearch);
            }
            else
            {
                bindingSourceAccount.DataSource = AccountDAO.Instance.GetAllUser();
            }
        }

        private void btnResetPw_Click(object sender, EventArgs e)
        {
            string username = tbUserAccount.Text;
            if (AccountDAO.Instance.ResetPassword(username))
            {
                MessageBox.Show($"Changed {username} with password=1");
            }
        }

        private void btnCategoryView_Click(object sender, EventArgs e)
        {
            LoadCategoryList();
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            fCreateCategory fCreateCategories = new fCreateCategory();
            fCreateCategories.ShowDialog();
        }

        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbCategoryId.Text);
            string name = txbCategoryName.Text;
            if (!string.IsNullOrEmpty(name))
            {
                if (CategoryDAO.Instance.UpdateCategory(id, name))
                {
                    MessageBox.Show("Update successful ", "Food Management");
                }
            }
            else
            {
                MessageBox.Show("Fill all blank please !", "Food Management");
            }
        }

        private void btnCategorySearch_Click(object sender, EventArgs e)
        {
            string key = txbCategorySearch.Text;
            if (!string.IsNullOrEmpty(key))
            {
                List<Category> listCategorySearch = CategoryDAO.Instance.SearchByKey(key);
                if (listCategorySearch != null && listCategorySearch.Count > 0)
                {
                    bindingSourceCategory.DataSource = listCategorySearch;
                }
                else
                {
                    MessageBox.Show($"No category with name: {key}", "Food Management");
                }
            }
            else
            {
                LoadCategoryList();
            }
        }

        private void btnViewTable_Click(object sender, EventArgs e)
        {
            LoadTableList();
        }
        int GetIdTablePrev()
        {
            Table table = TableDAO.Instance.GetTop1TableById();
            int nameNum = int.Parse(table.name.Split(" ")[1]);
            return nameNum + 1;
        }
        private void btnAddTable_Click(object sender, EventArgs e)
        {
            int id = GetIdTablePrev();
            if (TableDAO.Instance.CreateTable($"Table {id}"))
            {
                MessageBox.Show($"Create table success with name: Table {id}", "Food Management");
            }
            else
            {
                MessageBox.Show("Create Fail", "Food Management");
            }
        }

        private void btnUpdateTable_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbTableId.Text);
            string name = txbNameTable.Text;
            if (!string.IsNullOrEmpty(name))
            {
                if (TableDAO.Instance.UpdateNameTable(id, name))
                {
                    MessageBox.Show("Update successful", "Food Management");
                }
                else
                {
                    MessageBox.Show("Update Fail", "Food Management");
                }
            }
            else
            {
                MessageBox.Show("Fill all blank please", "Food Management");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string key = txbTableSearchKey.Text;
            if (!string.IsNullOrEmpty(key))
            {
               List<Table> listTableSearch= TableDAO.Instance.SearchByKey(key);
                if(listTableSearch!=null && listTableSearch.Count > 0)
                {
                    bindingSourceTable.DataSource= listTableSearch;
                }
                else
                {
                    MessageBox.Show($"No table with name: {key}", "Food Management");
                }
            }
            else
            {
                LoadTableList();
            }
        }
    }
}
