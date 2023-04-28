using CoffeeManagement.DAO;
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
    public partial class fCreateUser : Form
    {
        public fCreateUser()
        {
            InitializeComponent();
        }

        private void btnCancelCreate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string repassword = tbRePassword.Text;
            string fullname = tbFullname.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(repassword) && !string.IsNullOrEmpty(fullname))
            {
                if (password.Equals(repassword))
                {

                    if (AccountDAO.Instance.GetAccountByUsername(username) == null)
                    {

                        byte[] usernameByte = ASCIIEncoding.ASCII.GetBytes(username);
                        byte[] byteUsernameHash = new MD5CryptoServiceProvider().ComputeHash(usernameByte);
                        string hashUsernameString = ASCIIEncoding.ASCII.GetString(byteUsernameHash);


                        byte[] passwordByte = ASCIIEncoding.ASCII.GetBytes(password);
                        byte[] bytePasswordHash = new MD5CryptoServiceProvider().ComputeHash(passwordByte);
                        string hashPasswordString = ASCIIEncoding.ASCII.GetString(bytePasswordHash);


                        if (AccountDAO.Instance.InsertUser(hashUsernameString, hashPasswordString, fullname))
                        {
                            MessageBox.Show("Create user successful", "Food Management");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Create fail !", "Food Management");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username already exist!", "Food Management");
                    }
                }
                else
                {
                    MessageBox.Show("Two password not equal !", "Food Management");
                }
            }
            else
            {
                MessageBox.Show("Fill all blank please !", "Food Management");
            }
        }
    }
}
