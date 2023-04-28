using CoffeeManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance { get { if (instance == null) { instance = new CategoryDAO(); }return instance; }private set => instance = value; }

        public List<Category> getAllCategories()
        {
            List<Category> listCategory = new List<Category>() ;
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("Select * from FoodCategory");
            if (dataTable.Rows.Count>0)
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    Category category = new Category(item);
                    listCategory.Add(category);
                }
            }
            return listCategory;
        }
        public Category GetCategoryById(int id)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("select * from FoodCategory where id='" + id + "'");
            Category category = new Category(dataTable.Rows[0]);
            return category;
        }
        public Boolean UpdateCategory(int id, string name)
        {
            int num = DataProvider.Instance.ExecuteNoneQuery($"UPDATE FoodCategory set name='{name}' WHERE id={id}");
            return num > 0;
        }
        public Boolean InsertCategory(string name)
        {
            int num = DataProvider.Instance.ExecuteNoneQuery($"INSERT INTO FoodCategory (name) VALUES('{name}')");
            return num > 0;
        }
        public List<Category> SearchByKey(string name)
        {
            List<Category> listCategory = new List<Category>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery($"select * from FoodCategory where name like '%{name}%'");
            foreach (DataRow item in dataTable.Rows)
            {
                listCategory.Add(new Category(item));
            }
            return listCategory;
        }
    }
}
