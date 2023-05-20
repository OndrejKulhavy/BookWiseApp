using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookWiseApp.Database.Models;
using System.Data.SqlClient;

namespace BookWiseApp.Database.DAO
{
    public class MemberDAO : IDAO<Member>
    {
        private SqlConnection? connection;

        public MemberDAO()
        {
            this.connection = DbConnection.connection;
            if (connection == null)
                throw new Exception("Conection to database failed in MemberDAO constructor");
        }

        public void Delete(Member member)
        {
            string query = "DELETE FROM Member WHERE id = @MemberID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MemberID", member.Id);
            command.ExecuteNonQuery();
        }

        public IEnumerable<Member> GetAll()
        {
            string query = "SELECT * FROM Member";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Member member = new Member(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetString(5)
                );
                yield return member;
            }
            reader.Close();
        }

        public Member? GetByID(int id)
        {
            string query = "SELECT * FROM Member WHERE id = @MemberID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MemberID", id);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Member member = new Member(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetString(5)
                );
                reader.Close();
                return member;
            }
            reader.Close();
            return null;
        }

        public void Save(Member element)
        {
            if (element.Id == 0)
            {
                string query =
                    "INSERT INTO Member (first_name, last_name, address, email, phone_number) VALUES (@FirstName, @LastName, @Address, @Email, @PhoneNumber)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", element.FirstName);
                command.Parameters.AddWithValue("@LastName", element.LastName);
                command.Parameters.AddWithValue("@Address", element.Address);
                command.Parameters.AddWithValue("@Email", element.Email);
                command.Parameters.AddWithValue("@PhoneNumber", element.PhoneNumber);
                command.ExecuteNonQuery();
            }
            else
            {
                string query =
                    "UPDATE Member SET first_name = @FirstName, last_name = @LastName, address = @Address, email = @Email, phone_number = @PhoneNumber WHERE id = @MemberID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", element.FirstName);
                command.Parameters.AddWithValue("@LastName", element.LastName);
                command.Parameters.AddWithValue("@Address", element.Address);
                command.Parameters.AddWithValue("@Email", element.Email);
                command.Parameters.AddWithValue("@PhoneNumber", element.PhoneNumber);
                command.Parameters.AddWithValue("@MemberID", element.Id);
                command.ExecuteNonQuery();
            }
        }
    }
}
