using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CoffeeManagement.DTO
{
    public class Bill
    {
        public int Id { get; set; }
        public DateTime? CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public int IdTable { get; set; }
        public int Status { get; set; }
        public int Discount { get; set; }
        public double TotalMoney { get; set; }
        public Bill() { }
        public Bill(DataRow data)
        {
            Id =(int) data["id"];
            CheckIn = (DateTime?)data["DateCheckIn"];
            var temp = data["DateCheckOut"];
            if (temp != null && temp.ToString() != "")
            {
                CheckOut = (DateTime?)data["DateCheckOut"];
            }
            else
            {
                CheckOut = null;
            }
            IdTable = (int)data["idTable"];
            Status = (int)data["status"];
            Discount = (int)data["discount"];
            if (data["totalMoney"] != null && data["totalMoney"].ToString()!="")
            {
                TotalMoney = (double)data["totalMoney"];
            }
            else
            {
                TotalMoney=0;
            }
           
        }


        public Bill(int id, DateTime? checkIn, DateTime? checkOut, int idTable, int status, int discount=0, double totalMoney =0)
        {
            Id = id;
            CheckIn = checkIn;
            CheckOut = checkOut;
            IdTable = idTable;
            Status = status;
            Discount = discount;
            TotalMoney = totalMoney;
        }


    }
}
