using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace framework.db
{
    public class Sql : IDatabase
    {
        private string _connectionStr;
        private SqlConnection connection;
        public Sql(string connectionStr)
        {
            this._connectionStr = connectionStr;
        }
        public void Connect()
        {
            connection = new SqlConnection(_connectionStr);

            try
            {
                // Open the connection
                connection.Open();
                Console.WriteLine("Connected to SQL Server database.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error connecting to SQL Server: {ex.Message}");
            }
        }



        public void Disconnect()
        {
            try
            {
                // Close the connection
                connection.Close();
                Console.WriteLine("Disconnected from SQL Server database.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error disconnecting from SQL Server: {ex.Message}");
            }
        }
       

    }
}
