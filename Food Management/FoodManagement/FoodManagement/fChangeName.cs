using CoffeeManagement.DAO;
using CoffeeManagement.DTO;
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
    public partial class fChangeName : Form
    {
        public Account account { get; set; }
        public fChangeName(Account acc)
        {
            this.account = acc;
            InitializeComponent();
            LoadInformation(account);
        }
        void LoadInformation(Account account)
        {
            tbUsername.Text = account.Username;
            tbDisplayName.Text = account.Name;
        }
        private void btnCancelName_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateName_Click(object sender, EventArgs e)
        {
            string displayName = tbDisplayName.Text;
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            if (!string.IsNullOrEmpty(displayName) && !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                if (AccountDAO.Instance.ChangeName(displayName, username, password))
                {
                    MessageBox.Show("Update name successful !", "Food Management !");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Your password incorrect !", "Food Management !");
                }
            }
            else
            {
                MessageBox.Show("Please fill full blank !", "Food Management !");
            }
        }
    }
}
