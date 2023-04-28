using CoffeeManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance { get { if (instance == null) { instance = new FoodDAO();  } return instance; } private set => instance = value; }

        public List<Food> getFoodByIdCate(int id)
        {
            List<Food> listFood = new List<Food>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("exec USP_GetListFoodIdCate @idCategory", new object[] { id });
            if (dataTable.Rows.Count > 0){
                foreach (DataRow item in dataTable.Rows)
                {
                    Food food = new Food(item);
                    listFood.Add(food);
                }
            }
            return listFood;
        }

        public List<Food> LoadAllFood()
        {
            List<Food> listFood = new List<Food>() ;
            string query = " select food.id as ID, food.name as Name, food.idCategory as idCategory, food.price as Price from food ";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                listFood.Add(new Food(item));
            }
            return listFood;
        }
        public Boolean InsertFood(string name, int idCate, double price)
        {
            int num = DataProvider.Instance.ExecuteNoneQuery($"insert into food(name,idCategory,price) values('{name}',{idCate},{price})");
            return num > 0;
        }
        public Boolean UpdateFood(int id,string name , int idCate, double price)
        {
            int num = DataProvider.Instance.ExecuteNoneQuery($"update food set name = '{name}' ,idCategory={idCate},price={price} where id={id}");
            return num > 0;
        }
        public List<Food> GetFoodByName(string name)
        {
            List<Food> listFood= new List<Food> ();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery($"SELECT * FROM food WHERE name like '%{name}%'");
            foreach (DataRow item in dataTable.Rows)
            {
                listFood.Add(new Food(item));   
            }
            return listFood;
        }
    }
}
