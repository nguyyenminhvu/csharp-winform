using CoffeeManagement.DAO;
using CoffeeManagement.DTO;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;


            byte[] usernameByte = ASCIIEncoding.ASCII.GetBytes(username);
            byte[] byteUsernameHash = new MD5CryptoServiceProvider().ComputeHash(usernameByte);
            string hashUsernameString = ASCIIEncoding.ASCII.GetString(byteUsernameHash);


            byte[] passwordByte = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] bytePasswordHash = new MD5CryptoServiceProvider().ComputeHash(passwordByte);
            string hashPasswordString = ASCIIEncoding.ASCII.GetString(bytePasswordHash);

            if (Login(hashUsernameString, hashPasswordString))
            {
                Account account = AccountDAO.Instance.GetAccountByUsername(hashUsernameString);
                fTableManagement fTableManagement = new fTableManagement(account);
                this.Hide();
                fTableManagement.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Food Management");

            }
        }

        Boolean Login(string username, string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure? ", "Food Management", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
