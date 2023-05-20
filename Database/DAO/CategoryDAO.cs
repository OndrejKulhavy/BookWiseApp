using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookWiseApp.Database.Models;
using System.Data.SqlClient;

namespace BookWiseApp.Database.DAO
{
    public class CategoryDAO : IDAO<Category>
    {
        private SqlConnection? connection;

        public CategoryDAO()
        {
            this.connection = DbConnection.connection;
            if (connection == null)
                throw new Exception("Conection to database failed in CategoryDAO constructor");
        }

        public void Delete(Category element)
        {
            string query = "DELETE FROM Category WHERE id = @CategoryID";
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
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2)
                );
                yield return category;
            }
            reader.Close();
        }

        public Category? GetByID(int id)
        {
            Category? category = null;
            string query = "SELECT * FROM Category WHERE id = @CategoryID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CategoryID", id);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                category = new Category(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2)
                );
            }
            reader.Close();
            return category;
        }

        public void Save(Category category)
        {
            if (category.Id == 0)
            {
                string query =
                    "INSERT INTO Category (name, description) VALUES (@Name, @Description)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", category.Name);
                command.Parameters.AddWithValue("@Description", category.Description);
                command.ExecuteNonQuery();
            }
            else
            {
                string query =
                    "UPDATE Category SET name = @Name, description = @Description WHERE id = @CategoryID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", category.Name);
                command.Parameters.AddWithValue("@Description", category.Description);
                command.Parameters.AddWithValue("@CategoryID", category.Id);
                command.ExecuteNonQuery();
            }
        }
    }
}
