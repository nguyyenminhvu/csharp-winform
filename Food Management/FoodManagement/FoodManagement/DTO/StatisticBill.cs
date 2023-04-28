using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CoffeeManagement.DTO
{
    public class StatisticBill
    {
        public string Name { get; set; }
        public double TotalMoney { get; set; }
        public DateTime DateCheckIn { get; set; }
        public DateTime DateCheckOut { get; set;}
        public int Discount { get; set; }
  
        public StatisticBill(string name, double totalMoney, DateTime dateCheckIn, DateTime dateCheckOut, int discount)
        {
            Name = name;
            TotalMoney = totalMoney;
            DateCheckIn = dateCheckIn;
            DateCheckOut = dateCheckOut;
            Discount = discount;
        }
        public StatisticBill() { }

        public StatisticBill(DataRow data) {
            Name = (string)data["Name"];
            if (data["TotalMoney"]!=null && data["TotalMoney"].ToString()!="")
            {
                TotalMoney = (double)data["TotalMoney"];
            }
            else
            {
                TotalMoney = 0;
            }
            DateCheckIn = (DateTime)data["DateCheckIn"];
            DateCheckOut = (DateTime)data["DateCheckOut"];
            Discount = (int)data["Discount"];
        }
    }
}
