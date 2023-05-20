using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookWiseApp.Database.Models;
using System.Data.SqlClient;

namespace BookWiseApp.Database.Data_Access_Objects
{
    public class EmployeeDAO : IDAO<Employee>
    {
        private SqlConnection connection;

        public EmployeeDAO()
        {
            this.connection = DbConnection.connection;
            if (connection == null)
                throw new Exception("Conection to database failed in EmployeeDAO constructor");
        }

        public void Delete(Employee employee)
        {
            string query = "DELETE FROM Employee WHERE id = @EmployeeID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@EmployeeID", employee.Id);
            command.ExecuteNonQuery();
        }

        public IEnumerable<Employee> GetAll()
        {
            string query = "SELECT * FROM Employee";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Employee employee = new Employee(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetString(5)
                );
                yield return employee;
            }
        }

        public Employee? GetByID(int id)
        {
            Employee? employee = null;
            string query = "SELECT * FROM Employee WHERE id = @EmployeeID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@EmployeeID", id);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                employee = new Employee(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetString(5)
                );
            }
            return employee;
        }

        public void Save(Employee element)
        {
            if (element.Id == 0){
                string query = "INSERT INTO Employee (first_name, last_name, password_hash, email, phone_number) VALUES (@FirstName, @LastName, @PasswordHash, @Email, @PhoneNumber)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", element.FirstName);
                command.Parameters.AddWithValue("@LastName", element.LastName);
                command.Parameters.AddWithValue("@PasswordHash", element.PasswordHash);
                command.Parameters.AddWithValue("@Email", element.Email);
                command.Parameters.AddWithValue("@PhoneNumber", element.PhoneNumber);
                command.ExecuteNonQuery();
            }
            else{
                string query = "UPDATE Employee SET first_name = @FirstName, last_name = @LastName, password_hash = @PasswordHash, email = @Email, phone_number = @PhoneNumber WHERE id = @EmployeeID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", element.FirstName);
                command.Parameters.AddWithValue("@LastName", element.LastName);
                command.Parameters.AddWithValue("@PasswordHash", element.PasswordHash);
                command.Parameters.AddWithValue("@Email", element.Email);
                command.Parameters.AddWithValue("@PhoneNumber", element.PhoneNumber);
                command.Parameters.AddWithValue("@EmployeeID", element.Id);
                command.ExecuteNonQuery();
            }
        }
    }
}
