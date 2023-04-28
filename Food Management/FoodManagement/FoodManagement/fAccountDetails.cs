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
    public partial class fAccountDetails : Form
    {
        private Account account { get; set; }
        public fAccountDetails(Account accounts)
        {
            this.account = accounts;
            InitializeComponent();
            Authorizations(this.account);
        }
        void Authorizations(Account acc)
        {
            tbUsername.Text = acc.Username;
            tbDisplayName.Text = acc.Name;
            tbPassword.Text = "********";
            tbRole.Text = (acc.Type == 1) ? "User" : "Admin";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
