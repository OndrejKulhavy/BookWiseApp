using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookWiseApp.Database.Models;
using System.Data.SqlClient;



namespace BookWiseApp.Database.Data_Access_Objects
{
    public class CategoryDAO : IDAO<Category>
    {
        private SqlConnection connection;
        public CategoryDAO()
        {
            this.connection = DbConnection.connection;
            if (connection == null) throw new Exception("Conection to database failed in CategoryDAO constructor");
        }
        public void Delete(Category element)
        {
            string query = "DELETE FROM Category WHERE CategoryID = @CategoryID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CategoryID", element.Id);
            command.ExecuteNonQuery();
        }

        public IEnumerable<Category> GetAll()
        {
            string query = "SELECT * FROM Category";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Category category = new Category(
                    Convert.ToInt32(reader[0].ToString()),
                    reader[1].ToString(),
                    reader[2].ToString()
                );
                yield return category;
            }
            reader.Close();
        }

        public Category? GetByID(int id)
        {
            Category? category = null;
            string query = "SELECT * FROM Category WHERE CategoryID = @CategoryID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CategoryID", id);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                category = new Category(
                    Convert.ToInt32(reader[0].ToString()),
                    reader[1].ToString(),
                    reader[2].ToString()
                );
            }
            reader.Close();
            return category;
        }

        public void Save(Category category)
        {
            string query = "INSERT INTO Category (CategoryName) VALUES (@CategoryName)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CategoryName", category.Name);
            command.ExecuteNonQuery();
        }

    }
}
