using CoffeeManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.DAO
{
    public class StatisticBillDAO
    {
        private static StatisticBillDAO instance;

        public static StatisticBillDAO Instance { get { if (instance == null) { instance = new StatisticBillDAO(); }return instance; }private set => instance = value; }
        public StatisticBillDAO() { }   

        public List<StatisticBill> getListBillWithChecked(DateTime froms, DateTime tos)
        {
            List<StatisticBill> listStatisticBill = new List<StatisticBill>();
            DataTable dt = DataProvider.Instance.ExecuteQuery($"select  t.name as Name,  b.DateCheckIn, b.DateCheckOut, b.discount as Discount,b.totalMoney as TotalMoney, b.status from bill as b, TableFood as t where b.idTable=t.id and b.status=1  and DateCheckIn>='{froms}' and DateCheckOut<='{tos}'");
            foreach (DataRow item in dt.Rows)
            {
                StatisticBill statisticBill = new StatisticBill(item);
                listStatisticBill.Add(statisticBill);
            }
            return listStatisticBill;   
        }
    }
}
