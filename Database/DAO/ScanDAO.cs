using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookWiseApp.Database.Models;
using System.Data.SqlClient;

namespace BookWiseApp.Database.DAO
{
    public class ScanDAO : IDAO<Scan>
    {
        private SqlConnection? connection;

        public ScanDAO()
        {
            this.connection = DbConnection.connection;
            if (connection == null)
                throw new Exception("Conection to database failed in ScanDAO constructor");
        }

        public void Delete(Scan element)
        {
            string query = "DELETE FROM Scan WHERE id = @ScanID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ScanID", element.Id);
            command.ExecuteNonQuery();
        }

        public IEnumerable<Scan> GetAll()
        {
            string query = "SELECT * FROM Scan";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Scan scan = new Scan(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetDateTime(2)
                    );
                yield return scan;
            }
            reader.Close();
        }

        public Scan? GetByID(int id)
        {
            string query = "SELECT * FROM Scan WHERE id = @ScanID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ScanID", id);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Scan scan = new Scan(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetDateTime(2)
                    );
                reader.Close();
                return scan;
            }
            reader.Close();
            return null;
        }

        public void Save(Scan element)
        {
            if (element.Id == 0){
                string query = "INSERT INTO Scan (ISBN, scan_date) VALUES (@ISBN, @scan_date)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ISBN", element.ISBN);
                command.Parameters.AddWithValue("@scan_date", element.ScanDate);
                command.ExecuteNonQuery();
            }
            else{
                string query = "UPDATE Scan SET ISBN = @ISBN, scan_date = @scan_date WHERE id = @ScanID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ScanID", element.Id);
                command.Parameters.AddWithValue("@ISBN", element.ISBN);
                command.Parameters.AddWithValue("@scan_date", element.ScanDate);
                command.ExecuteNonQuery();
            }
        }
    }
}
