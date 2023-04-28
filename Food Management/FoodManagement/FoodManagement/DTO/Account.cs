using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace CoffeeManagement.DTO
{
    public class Account
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Type { get; set; }  
        public Account() { }

        public Account(string name, string username, string password, int type)
        {
            Name = name;
            Username = username;
            Password = "*********";
            Type = type;
        }
        public Account(DataRow data) {
            Name = (string) data["DisplayName"];
            Username = (string)data["Username"];
            Password = "*********";
            Type = (int)data["type"];
        }

    }
}
