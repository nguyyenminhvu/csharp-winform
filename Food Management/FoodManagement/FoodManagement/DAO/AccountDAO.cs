using CoffeeManagement.DTO;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance {
            get { if (instance == null) { instance = new AccountDAO(); } return instance;}
            private  set => instance = value; }
        private AccountDAO() { }

        public Boolean Login(string username, string password)
        {
            string sql = "exec USP_Login @Username , @Password";
            DataTable dataTable= DataProvider.Instance.ExecuteQuery(sql,new object[] {username, password});
            return dataTable.Rows.Count > 0; //cach 2 xai proceduce store
        }
        public Account GetAccountByUsername(string username)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("select * from account where username='" + username + "'");
            foreach (DataRow item in dataTable.Rows)
            {
                return new Account(item);
            }
            return null;
        }
        public Boolean ChangePassword(string username, string newPassword, string oldPassword)
        {
            int num = DataProvider.Instance.ExecuteNoneQuery("exec USP_ChangePassword @newPassword , @username , @oldPassword", new object[] {newPassword, username, oldPassword });
            return num > 0;
        }
        public Boolean ChangeName(string name, string username, string password)
        {
            int num = DataProvider.Instance.ExecuteNoneQuery("exec USP_ChangeName @displayName , @username , @password", new object[] { name, username, password });
            return num > 0;
        }
        public Boolean InsertUser(string username, string password, string fullname)
        {
            int num = DataProvider.Instance.ExecuteNoneQuery($"insert into Account(Username,DisplayName,Password,Type) values('{username}','{fullname}','{password}',0)");
            return num > 0;
        }
        public List<Account> GetAllUser()
        {
            List<Account> listUser = new List<Account>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("SELECT * FROM ACCOUNT; ");
            foreach (DataRow item in dataTable.Rows)
            {
                listUser.Add(new Account(item));
            }
            return listUser;
        }
        public Boolean UpdateUser(string name, int type, string username)
        {
            int num = DataProvider.Instance.ExecuteNoneQuery($"UPDATE Account SET DisplayName='{name}', Type={type} WHERE username='{username}'");
            return num > 0;
        }
        public List<Account> SearchAccountByName(string name)
        {
            List<Account> listAccount= new List<Account>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery($"SELECT * FROM Account WHERE DisplayName like '%{name}%'");
            foreach (DataRow item in dataTable.Rows)
            {
                listAccount.Add(new Account(item));
            }
            return listAccount;
        }
        public Boolean ResetPassword(string username)
        {
            int num = DataProvider.Instance.ExecuteNoneQuery($"UPDATE Account set password='1' WHERE Username='{username}'");
            return num > 0;
        }
    }
}
