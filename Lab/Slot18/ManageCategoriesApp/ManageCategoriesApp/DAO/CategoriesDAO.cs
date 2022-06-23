using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageCategoriesApp.Model;
using ManageCategoriesApp.DAO;

namespace ManageCategoriesApp.DAO
{
     class CategoriesDAO
    {
        public List<Categories> GetAllCategories() {
            string sql = "Select CategoryID,CategoryName from Categories";
           DataTable dt = DAO.GetDataBySql(sql);
            List<Categories> list = new List<Categories>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Categories(
                    Convert.ToInt32(dr["CategoryID"]),
                    dr["CategoryName"].ToString()
                    ));
            }
            return list;
        }
        public void InsertCategories(Categories categories)
        {
            string sql = "INSERT INTO [Categories]([CategoryName])"
                           + "VALUES(@CategoryName)";
            SqlConnection connection = DAO.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@CategoryName", categories.CategoryName);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void UpdateCategories(Categories categories)
        {
            string sql = "UPDATE Categories SET CategoryName = @CategoryName WHERE CategoryID = @CategoryID";
            SqlConnection connection = DAO.GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@CategoryName", categories.CategoryName);
            command.Parameters.AddWithValue("@CategoryID", categories.CategoryId);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void DeleteCategories(Categories categories)
        {
            string sql = "DELETE FROM Categories WHERE CategoryID = @CategoryID";
            SqlConnection connection = DAO.GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@CategoryID", categories.CategoryId);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
