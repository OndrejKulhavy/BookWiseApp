using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookWiseApp.Database.Models;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BookWiseApp.Database.DAO
{
    public class LoanDAO : IDAO<Loan>
    {
        private SqlConnection? connection;

        public LoanDAO()
        {
            this.connection = DbConnection.connection;
            if (connection == null)
                throw new Exception("Conection to database failed in LoanDAO constructor");
        }

        public void Delete(Loan loan)
        {
            string query = "DELETE FROM Loan WHERE id = @LoanID";
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
                    reader.GetInt32(0),
                    reader.GetInt32(1),
                    reader.GetInt32(2),
                    reader.GetDateTime(3),
                    reader.GetDateTime(4)
                );
                yield return loan;
            }
            reader.Close();
        }

        public Loan? GetByID(int id)
        {
            Loan? loan = null;
            string query = "SELECT * FROM Loan WHERE id = @LoanID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LoanID", id);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                loan = new Loan(
                    reader.GetInt32(0),
                    reader.GetInt32(1),
                    reader.GetInt32(2),
                    reader.GetDateTime(3),
                    reader.GetDateTime(4)
                );
            }
            reader.Close();
            return loan;
        }

        public void Save(Loan loan)
        {
            if (loan.Id == 0)
            {
                string query = "INSERT INTO Loan (book_id, member_id, loan_date, return_date) VALUES (@BookID, @MemberID, @LoanDate, @ReturnDate)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@BookID", loan.BookId);
                command.Parameters.AddWithValue("@MemberID", loan.MemberId);
                command.Parameters.AddWithValue("@LoanDate", loan.LoanDate);
                command.Parameters.AddWithValue("@ReturnDate", loan.ReturnDate);
                command.ExecuteNonQuery();
            }
            else
            {
                string query = "UPDATE Loan SET book_id = @BookID, member_id = @MemberID, loan_date = @LoanDate, return_date = @ReturnDate WHERE id = @LoanID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@BookID", loan.BookId);
                command.Parameters.AddWithValue("@MemberID", loan.MemberId);
                command.Parameters.AddWithValue("@LoanDate", loan.LoanDate);
                command.Parameters.AddWithValue("@ReturnDate", loan.ReturnDate);
                command.Parameters.AddWithValue("@LoanID", loan.Id);
                command.ExecuteNonQuery();
            }
        }
    }
}
