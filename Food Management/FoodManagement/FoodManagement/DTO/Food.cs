using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.DTO
{
    public class Food
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public int IdCategory { get; set; }
        public double Price { get; set; }

        public Food(DataRow dataRow) {
            this.Id = (int)dataRow["id"];
            this.Name = (string)dataRow["name"];
            this.IdCategory= (int)dataRow["idCategory"];
            this.Price = (double)dataRow["price"];
        }
    }
}
