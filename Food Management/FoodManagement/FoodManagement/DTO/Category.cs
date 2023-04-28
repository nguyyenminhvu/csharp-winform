using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.DTO
{
    public class Category
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public Category(DataRow dataRow)
        {
            this.Id = (int)dataRow["id"];
            this.Name = (string)dataRow["name"];    
        }
    }
}
