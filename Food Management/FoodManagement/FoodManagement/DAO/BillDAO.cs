using CoffeeManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.DAO
{
    public class BillDAO
    {

        private static BillDAO instance;
        public static BillDAO Instance { get { if (instance == null) { instance = new BillDAO(); }return instance; } private set => instance = value; }
        private BillDAO() { }
        public int getBillUncheckByTableId(int id)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("select * from bill where idtable=" + id + " and status=0");
            if(dataTable.Rows.Count > 0)
            {
                Bill bill = new Bill(dataTable.Rows[0]);
                return bill.Id;
            }
            return -1;
        }
        public void insertBill(int idTable, int discount)
        {
            DataProvider.Instance.ExecuteQuery("exec USP_InsertNewBill @idTable , @discount ", new object[] { idTable, discount});
        }
        public void paymentBill(int id, int discount, float totalMoney)
        {
            DataProvider.Instance.ExecuteQuery("exec USP_PaymentBill @id , @discount , @totalMoney", new object[] {id, discount, totalMoney });
        }
        public void changeTable(int idTableNew, int idTableOld, int idBillNew, int idBillOld)
        {
            DataProvider.Instance.ExecuteQuery("exec USP_ChangeTable @idTableOld , @idTableNew , @idBillOld , @idBillNew ", new object[] { idTableOld, idTableNew, idBillOld, idBillNew});
        }
    }
}
