using BookWiseApp.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BookWiseApp.Database.DAO
{
    public class AuthorDAO : IDAO <Author>
    {
        private SqlConnection? connection;
        public AuthorDAO()
        {
            this.connection = DbConnection.connection;
            if (connection == null) throw new Exception("Conection to database failed in AuthorDAO constructor");
        }
        public void Delete(Author author)
        {
            string query = "DELETE FROM Author WHERE id = @AuthorID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AuthorID", author.Id);
            command.ExecuteNonQuery();
        }

        public IEnumerable<Author> GetAll()
        {
            string query = "SELECT * FROM Author";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Author author = new Author(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3)
                );
                yield return author;
            }
            reader.Close();
        }

        public Author? GetByID(int id)
        {
            Author? author = null;
            string query = "SELECT * FROM Author WHERE id = @AuthorID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AuthorID", id);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                author = new Author(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3)
                );
            }
            reader.Close();
            return author;
        }

        public void Save(Author author)
        {
            if(author.Id == 0)
            {
                string query = "INSERT INTO Author (first_name, last_name, biography) VALUES (@FirstName, @LastName, @Biography)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", author.FirstName);
                command.Parameters.AddWithValue("@LastName", author.LastName);
                command.Parameters.AddWithValue("@Biography", author.Biography);
                command.ExecuteNonQuery();
            }
            else
            {
                string query = "UPDATE Author SET first_name = @FirstName, last_name = @LastName, biography = @Biography WHERE id = @AuthorID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AuthorID", author.Id);
                command.Parameters.AddWithValue("@FirstName", author.FirstName);
                command.Parameters.AddWithValue("@LastName", author.LastName);
                command.Parameters.AddWithValue("@Biography", author.Biography);
                command.ExecuteNonQuery();
            }
        }
    }
}
