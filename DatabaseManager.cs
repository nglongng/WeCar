using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeCar
{
    internal class DatabaseManager
    {
        private SqlConnection _connection;
        private string _connectionString = "YourConnectionStringHere";

        public DatabaseManager()
        {
            _connection = new SqlConnection(_connectionString);
        }

        public void OpenConnection()
        {
            try
            {
                _connection.Open();
                Console.WriteLine("Database connection opened successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error opening the connection: " + ex.Message);
            }
        }

        public void CloseConnection()
        {
            try
            {
                _connection.Close();
                Console.WriteLine("Database connection closed successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error closing the connection: " + ex.Message);
            }
        }

    }
}
