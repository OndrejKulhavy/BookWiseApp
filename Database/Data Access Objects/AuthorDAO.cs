using BookWiseApp.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BookWiseApp.Database.Data_Access_Objects
{
    public class AuthorDAO : IDAO <Author>
    {
        private SqlConnection connection;
        public AuthorDAO()
        {
            this.connection = DbConnection.connection;
            if (connection == null) throw new Exception("Conection to database failed in AuthorDAO constructor");
        }
        public void Delete(Author author)
        {
            string query = "DELETE FROM Author WHERE AuthorID = @AuthorID";
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
                    Convert.ToInt32(reader[0].ToString()),
                    reader[1].ToString(),
                    reader[2].ToString(),
                    reader[3].ToString()
                );
                yield return author;
            }
            reader.Close();
        }

        public Author? GetByID(int id)
        {
            Author? author = null;
            string query = "SELECT * FROM Author WHERE AuthorID = @AuthorID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AuthorID", id);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                author = new Author(
                    Convert.ToInt32(reader[0].ToString()),
                    reader[1].ToString(),
                    reader[2].ToString(),
                    reader[3].ToString()
                );
            }
            reader.Close();
            return author;
        }

        public void Save(Author author)
        {
            if(author.Id == 0)
            {
                string query = "INSERT INTO Author (FirstName, LastName, Biography) VALUES (@FirstName, @LastName, @Biography)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", author.FirstName);
                command.Parameters.AddWithValue("@LastName", author.LastName);
                command.Parameters.AddWithValue("@Biography", author.Biography);
                command.ExecuteNonQuery();
            }
            else
            {
                string query = "UPDATE Author SET FirstName = @FirstName, LastName = @LastName, Biography = @Biography WHERE AuthorID = @AuthorID";
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
