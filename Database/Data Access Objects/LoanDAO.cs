using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookWiseApp.Database.Models;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BookWiseApp.Database.Data_Access_Objects
{
    public class LoanDAO : IDAO<Loan>
    {
        private SqlConnection connection;

        public LoanDAO()
        {
            this.connection = DbConnection.connection;
            if (connection == null) throw new Exception("Conection to database failed in LoanDAO constructor");
        }
        public void Delete(Loan loan)
        {
            string query = "DELETE FROM Loan WHERE LoanID = @LoanID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LoanID", loan.Id);
            command.ExecuteNonQuery();
        }

        public IEnumerable<Loan> GetAll()
        {
            string query = "SELECT * FROM Loan";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Loan loan = new Loan(
                    Convert.ToInt32(reader[0].ToString()),
                    Convert.ToInt32(reader[1].ToString()),
                    Convert.ToInt32(reader[2].ToString()),
                    Convert.ToDateTime(reader[3].ToString()),
                    Convert.ToDateTime(reader[4].ToString())                );
                yield return loan;
            }
            reader.Close();
        }

        public Loan? GetByID(int id)
        {
            Loan? loan = null;
            string query = "SELECT * FROM Loan WHERE LoanID = @LoanID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LoanID", id);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                loan = new Loan(
                    Convert.ToInt32(reader[0].ToString()),
                    Convert.ToInt32(reader[1].ToString()),
                    Convert.ToInt32(reader[2].ToString()),
                    Convert.ToDateTime(reader[3].ToString()),
                    Convert.ToDateTime(reader[4].ToString())
                );
            }
            reader.Close();
            return loan;
        }

        public void Save(Loan loan)
        {
            string query = "INSERT INTO Loan (BookID, MemberID, LoanDate, ReturnDate) VALUES (@BookID, @MemberID, @LoanDate, @ReturnDate)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookID", loan.BookId);
            command.Parameters.AddWithValue("@MemberID", loan.MemberId);
            command.Parameters.AddWithValue("@LoanDate", loan.LoanDate);
            command.Parameters.AddWithValue("@ReturnDate", loan.ReturnDate);
            command.ExecuteNonQuery();
        }
    }
}
