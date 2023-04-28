using CoffeeManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class fCreateCategory : Form
    {
        public fCreateCategory()
        {
            InitializeComponent();
        }

        private void btnCancelName_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            string name = tbCaegoryNameAdd.Text;
            if (!string.IsNullOrEmpty(name))
            {
                if (CategoryDAO.Instance.InsertCategory(name))
                {
                    MessageBox.Show("Create successful", "Food Management");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Fill all blank please !", "Food Management");
            }
        }
    }
}
