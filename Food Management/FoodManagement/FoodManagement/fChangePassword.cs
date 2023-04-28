using CoffeeManagement.DAO;
using CoffeeManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class fChangePassword : Form
    {
        public Account account { get; set; }
        public fChangePassword(Account acc)
        {
            this.account = acc;
            InitializeComponent();
            LoadInformation(account);
        }
        void LoadInformation(Account accounts)
        {
            tbUsername.Text = accounts.Username;
        }
        private void btnCancelChangePW_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdatePW_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string newPassword = tbNewPassword.Text;
            string reNewPassword = tbReNewPassword.Text;
            if (!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(newPassword) && !string.IsNullOrEmpty(reNewPassword))
            {
                if (newPassword == reNewPassword)
                {


                    byte[] passwordByte = ASCIIEncoding.ASCII.GetBytes(password);
                    byte[] bytePasswordHash = new MD5CryptoServiceProvider().ComputeHash(passwordByte);
                    string hashPasswordString = ASCIIEncoding.ASCII.GetString(bytePasswordHash);

                    byte[] newPasswordByte = ASCIIEncoding.ASCII.GetBytes(reNewPassword);
                    byte[] byteNewPasswordHash = new MD5CryptoServiceProvider().ComputeHash(newPasswordByte);
                    string hashNewPasswordString = ASCIIEncoding.ASCII.GetString(byteNewPasswordHash);

                    if (AccountDAO.Instance.ChangePassword(username, hashNewPasswordString, hashPasswordString))
                    {
                        MessageBox.Show("Update password successful !", "Food Management");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Your password invalid !!", "Food Management");
                    }
                }
                else
                {
                    MessageBox.Show("Two New Password not equal !", "Food Management");
                }
            }
            else
            {
                MessageBox.Show("Fill all blank please !", "Food Management");
            }
        }
    }
}
