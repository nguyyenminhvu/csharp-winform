using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.DTO
{
    public class BillInfor
    {
        public BillInfor() { }
        public int Id { get; set; }
        public int IdBill { get; set; }
        public int IdFood { get; set; }
        public int Count { get; set; }

        public BillInfor(int id, int idBill, int idFood, int count)
        {
            Id = id;
            IdBill = idBill;
            IdFood = idFood;
            Count = count;
        }

        public BillInfor(DataRow dataRow)
        {
            Id =(int) dataRow["id"];
            IdBill = (int)dataRow["idBill"];
            IdFood = (int)dataRow["idFood"];
            Count = (int)dataRow["count"];
        }

    }
}
