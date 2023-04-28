using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.DTO
{
    public class Table
    {
        public int id { get; set; }
        public string name { get; set; }
        public string status { get; set; }

        public Table() { }

        public Table(int id, string name, string status)
        {
            this.id = id;
            this.name = name;
            this.status = status;
        }
        public Table(DataRow row)
        {
            this.id = (int)row["id"];
            this.name= (string)row["name"];
            this.status= (string)row["status"];
        }
    }
}
