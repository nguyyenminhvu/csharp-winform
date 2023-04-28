using CoffeeManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
        public static int TableWidth = 70;
        public static int TableHeight = 70;
        public static TableDAO Instance { get { if (instance == null){ instance = new TableDAO(); } return instance; } private set => instance = value; }
        private TableDAO() { }

        public List<Table> loadListTable()
        {
            List<Table> listTable= new List<Table>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("exec USP_GetTableList");
            foreach (DataRow item in dataTable.Rows)
            {
                Table table = new Table(item);
                listTable.Add(table);
            }
            return listTable;
        }
        public List<Table> LoadListTableWithoutStatus()
        {
            List<Table> listTable = new List<Table>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("select * from TableFood");
            foreach (DataRow item in dataTable.Rows)
            {
                Table table = new Table(item);
                listTable.Add(table);
            }
            return listTable;
        }
        public void updateStatusTable(int id, string status)
        {
            DataProvider.Instance.ExecuteQuery("exec USP_UpdateStatusTable @id , @status", new object[] {id, status});
        }
        public Boolean CreateTable(string name)
        {
            int num = DataProvider.Instance.ExecuteNoneQuery($"INSERT INTO TableFood (name) values('{name}')");
            return num > 0;
        }
        public Table GetTop1TableById()
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("select top 1 * from TableFood order by id desc");
            Table table = new Table(dataTable.Rows[0]);
            return table;
        }
        public Boolean UpdateNameTable(int id, string name)
        {
            int num = DataProvider.Instance.ExecuteNoneQuery($"update TableFood set name='{name}' where id={id}");
            return num > 0;
        }
        public List<Table> SearchByKey(string key)
        {
            List<Table> listTable = new List<Table>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery($"select * from tablefood where name like '%{key}%'");
            foreach (DataRow item in dataTable.Rows)
            {
                listTable.Add(new Table(item));
            }
            return listTable;
        }
    }
}
