using CoffeeManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance { get { if (instance == null){ instance = new MenuDAO(); }return instance; } private set => instance = value; }

        public MenuDAO() { }    
        public List<Menu> getListMenuByTableId(int id)
        {
            string sql = "select f.name as Name, bi.count as Quantity,f.price as Price, f.price*bi.count as TotalPrice from Bill as b, BillInfo as bi, Food as f where b.status=0 and b.id= bi.idBill and bi.idFood=f.id and b.idTable=" + id;
            List<Menu> listMenu= new List<Menu> ();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(sql);
            if(dataTable.Rows.Count > 0) {
                foreach (DataRow item in dataTable.Rows)
                {
                    listMenu.Add(new Menu(item));
                }
            }
            return listMenu;
        }
    }
}
