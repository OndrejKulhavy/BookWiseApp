using System;
using System.Collections.Generic;
using BookWiseApp.Database.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BookWiseApp.Database.Data_Access_Objects
{
    public class BookDAO : IDAO<Book>
    {
        private SqlConnection connection;
        public BookDAO()
        {
            this.connection = DbConnection.connection;
            if (connection == null) throw new Exception("Conection to database failed in BookDAO constructor");
        }
        public void Delete(Book book)
        {
            string query = "DELETE FROM Book WHERE BookID = @BookID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookID", book.Id);
            command.ExecuteNonQuery();
        }

        public IEnumerable<Book> GetAll()
        {
            string query = "SELECT * FROM Book";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Book book = new Book(
                    Convert.ToInt32(reader[0].ToString()),
                    reader[1].ToString(),
                    Convert.ToInt32(reader[2].ToString()),
                    Convert.ToInt32(reader[3].ToString()),
                    reader[4].ToString(),
                    Convert.ToDateTime(reader[5].ToString())
                );
                yield return book;
            }
        }

        public Book? GetByID(int id)
        {
            Book? book = null;
            string query = "SELECT * FROM Book WHERE BookID = @BookID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookID", id);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                book = new Book(
                    Convert.ToInt32(reader[0].ToString()),
                    reader[1].ToString(),
                    Convert.ToInt32(reader[2].ToString()),
                    Convert.ToInt32(reader[3].ToString()),
                    reader[4].ToString(),
                    Convert.ToDateTime(reader[5].ToString())
                );
            }
            return book;
        }

        public void Save(Book book)
        {
            if(book.Id == 0){
                string query = "INSERT INTO Book (Title, AuthorID, GenreID, ISBN, PublishDate) VALUES (@Title, @AuthorID, @GenreID, @ISBN, @PublishDate)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Title", book.Title);
                command.Parameters.AddWithValue("@AuthorID", book.AuthorId);
                command.Parameters.AddWithValue("@GenreID", book.CategoryId);
                command.Parameters.AddWithValue("@ISBN", book.ISBN);
                command.Parameters.AddWithValue("@PublishDate", book.PublicationDate);
                command.ExecuteNonQuery();
            } else {
                string query = "UPDATE Book SET Title = @Title, AuthorID = @AuthorID, GenreID = @GenreID, ISBN = @ISBN, PublishDate = @PublishDate WHERE BookID = @BookID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@BookID", book.Id);
                command.Parameters.AddWithValue("@Title", book.Title);
                command.Parameters.AddWithValue("@AuthorID", book.AuthorId);
                command.Parameters.AddWithValue("@GenreID", book.CategoryId);
                command.Parameters.AddWithValue("@ISBN", book.ISBN);
                command.Parameters.AddWithValue("@PublishDate", book.PublicationDate);
                command.ExecuteNonQuery();
            }
        }
    
    }
}
