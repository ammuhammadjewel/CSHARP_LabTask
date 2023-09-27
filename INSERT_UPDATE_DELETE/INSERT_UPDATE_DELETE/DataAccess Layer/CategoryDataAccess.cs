using Microsoft.Build.Framework.XamlTypes;
using System;
using INSERT_UPDATE_DELETE.Entities.Presentation_Layer;
using System.Collections.Generic;
using INSERT_UPDATE_DELETE.Entities;
using System.Data.SqlClient;
//using System.DataCategory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Category = INSERT_UPDATE_DELETE.Entities.Category;

namespace INSERT_UPDATE_DELETE.DataAccess_Layer
{
    internal class CategoryDataAccess : DataAccess
    {
        public List<Category> GetCategories()
        {
            string sql = "select * from Categories";
            SqlDataReader reader = this.GetData(sql);
            List<Category> categories = new List<Category>();
            while (reader.Read())
            {
                Category category = new Category();
                category.CategoryId = (int)reader["CategroyId"];
                category.CategoryName = reader["CategoryName"].ToString();
                categories.Add(category);

            }

            return categories;
        }

        public Category GetCategoryById(int categoryId)
        {
            string sql = "select * from Categories where CategoryId = " + categoryId;
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
            {
                reader.Read();
                Category category = new Category();
                category.CategoryId = (int)reader["CategroyId"];
                category.CategoryName = reader["CategoryName"].ToString();
                return category;
            }
            return null;
        }

        public bool CreateCategory(string categoryName)
        {
            string sql = "INSERT INTO Categories(CategoryName) VALUES('"+categoryName+"')";
            int result = this.ExecuteQuery(sql);
            if(result == 0)
                return true;
            else
                return false;
        }

        public bool UpdateCategory(int categoryId, string categoryName)
        {
            string sql = "UPDATE Categories SET CategoryName'" + categoryName + "' WHERE CategoryId="+categoryId;
            int result = this.ExecuteQuery(sql);
            if (result == 0)
                return true;
            else
                return false;
        }

        public bool DeleteCategory(int categoryId)
        {
            string sql = "DELETE FROM Categories  WHERE CategoryId=" + categoryId;
            int result = this.ExecuteQuery(sql);
            if (result == 0)
                return true;
            else
                return false;
        }
    }
}
