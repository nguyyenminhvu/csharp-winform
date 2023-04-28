using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CoffeeManagement.DTO
{
    public class Menu
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }

        public Menu(string name, int count, double price, double totalPrice = 0)
        {
            Name = name;
            Count = count;
            Price = price;
            TotalPrice = totalPrice;
        }

        public Menu()
        {
        }
        public Menu(DataRow dataRow)
        {
            Name =(string) dataRow["Name"];
            Count = (int)dataRow["Quantity"];
            Price = (double)dataRow["Price"];
            TotalPrice = (double)dataRow["TotalPrice"];
        }


    }
}
