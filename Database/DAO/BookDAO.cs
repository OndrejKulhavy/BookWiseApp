using System;
using System.Collections.Generic;
using BookWiseApp.Database.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BookWiseApp.Database.DAO
{
    public class BookDAO : IDAO<Book>
    {
        private SqlConnection? connection;
        public BookDAO()
        {
            this.connection = DbConnection.connection;
            if (connection == null) throw new Exception("Conection to database failed in BookDAO constructor");
        }
        public void Delete(Book book)
        {
            string query = "DELETE FROM Book WHERE id = @BookID";
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
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetInt32(2),
                    reader.GetInt32(3),
                    reader.GetString(4),
                    reader.GetDateTime(5)
                );
                yield return book;
            }
            reader.Close();
        }

        public Book? GetByID(int id)
        {
            Book? book = null;
            string query = "SELECT * FROM Book WHERE id = @BookID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookID", id);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                book = new Book(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetInt32(2),
                    reader.GetInt32(3),
                    reader.GetString(4),
                    reader.GetDateTime(5)
                );
            }
            reader.Close();
            return book;
        }

        public void Save(Book book)
        {
            if(book.Id == 0){
                string query = "INSERT INTO Book (title, author_id, category_id, ISBN, publication_date) VALUES (@Title, @AuthorID, @GenreID, @ISBN, @PublishDate)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Title", book.Title);
                command.Parameters.AddWithValue("@AuthorID", book.AuthorId);
                command.Parameters.AddWithValue("@GenreID", book.CategoryId);
                command.Parameters.AddWithValue("@ISBN", book.ISBN);
                command.Parameters.AddWithValue("@PublishDate", book.PublicationDate);
                command.ExecuteNonQuery();
            } else {
                string query = "UPDATE Book SET title = @Title, author_id = @AuthorID, category_id = @GenreID, ISBN = @ISBN, publication_date = @PublishDate WHERE id = @BookID";
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
