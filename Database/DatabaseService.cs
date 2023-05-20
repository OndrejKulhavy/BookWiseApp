using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWiseApp.Database.Models
{
    public class DatabaseService
    {
        private static SqlConnection connection;

        public DatabaseService()
        {
            InitializeConnection();
        }

        public void InitializeConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings[
                "Database"
            ].ConnectionString;
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public void CloseConnection()
        {
            if (connection != null)
            {
                connection.Close();
                connection.Dispose();
                connection = null;
            }
        }
    }
}
