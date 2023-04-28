using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.DAO
{
    internal class DataProvider
    {
        private static string ConnectionSTR = "Data Source=NGYNMINHVU\\SQLEXPRESS;Initial Catalog=FoodManagement;User ID=sa;Password=12345";
        private static DataProvider instance;

        public static DataProvider Instance { get { if (instance == null) { instance = new DataProvider(); } return instance; } private set => instance = value; }

        public DataTable ExecuteQuery(string query, object[] objects=null) // execute query giong prj tra ve ket qua data table
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionSTR)) // sau khi thuc hien xong thi nhung gi trong using(...){} se dc giai phong
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConnection); // thuc thi query

                //cmd.Parameters.AddWithValue("@Username", id);   // @username la parameter cua proceduce store
                if(objects != null) {
                    string[] objectArray= query.Split(" ");
                    int i=0;
                    foreach (var item in objectArray)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, objects[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd); // lay data 
                sqlDataAdapter.Fill(dataTable); // gan vao datatable
                sqlConnection.Close();
            }
            return dataTable;   
        }

        public int ExecuteNoneQuery(string query, object[] param = null) // execute none query tra ve so dong duoc thuc thi  giong executeUpdate prj.
        {
            int data = 0;
            using (SqlConnection sqlConnection= new SqlConnection(ConnectionSTR))
            {
                sqlConnection.Open();   
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection); 
                if (param != null)
                {
                    int i = 0;
                    string[] splitObject= query.Split(' ');
                    foreach (var item in splitObject)
                    {
                        if (item.Contains("@"))
                        {
                            sqlCommand.Parameters.AddWithValue(item, param[i]);
                            Console.WriteLine(sqlCommand.Parameters);
                            i++;
                        }
                    }
                }
                data =sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] param = null)
        {
            object data = 0;
            using(SqlConnection sqlConnection=new SqlConnection()) {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                if (param != null)
                {
                    int i = 0;
                    string[] splitObject= query.Split(" ");
                    foreach (var item in splitObject)
                    {
                        if (item.Contains("@"))
                        {
                            sqlCommand.Parameters.AddWithValue(item, param[i]); 
                            i++;    
                        }
                    }
                }
                data=sqlCommand.ExecuteScalar(); // thuc hien query va tra ve dong dau tien cua bang ket qua
                sqlConnection.Close();
            }
            return data;
        }
    }
}
