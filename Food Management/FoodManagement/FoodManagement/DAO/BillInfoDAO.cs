using CoffeeManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.DAO
{
    public class BillInfoDAO
    {
        private BillInfoDAO() { }

        private static BillInfoDAO instance;

        public static BillInfoDAO Instance { get { if (instance == null){ instance = new BillInfoDAO(); }return instance; } private set => instance = value; }

        public List<BillInfor> getListBillInfoByIdBill(int id)
        {
            List<BillInfor> listBillInfo = new List<BillInfor>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("select * from BillInfo where idBill=" + id);
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    BillInfor billInfor = new BillInfor(item);
                    listBillInfo.Add(billInfor);    
                }
            }
            return listBillInfo;
        }
        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            DataProvider.Instance.ExecuteQuery("Exec USP_InsertBillInfo @idBill  , @idFood  , @count", new object[] { idBill, idFood, count });
        }

    }
}
