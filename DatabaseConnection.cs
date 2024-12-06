using System.Data.SqlClient;
using System;

namespace SalesManagement
{
    internal class DatabaseConnection
    {
        private string connectionString = "Server=Admin-PC\\SQLEXPRESS01;Database=SalesManagement;Trusted_Connection=True";

        // Method to get and open connection
        public SqlConnection GetConnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();  // Open connection
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    Console.WriteLine("Database connection is open.");
                }
                else
                {
                    Console.WriteLine("Database connection failed to open.");
                }
                return connection;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error connecting to database: " + ex.Message);
                return null;
            }
        }

        // Method to close connection
        public void CloseConnection(SqlConnection connection)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                Console.WriteLine("Database connection closed.");
            }
            else
            {
                Console.WriteLine("Database connection is already closed.");
            }
        }
    }
}
