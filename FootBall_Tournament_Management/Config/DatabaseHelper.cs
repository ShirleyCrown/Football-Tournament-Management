using FootBall_Tournament_Management.NewFolder1;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall_Tournament_Management.DAO
{
    internal class DatabaseHelper
    {
        string connectionString;

        public DatabaseHelper() 
        {
            connectionString = "Server=localhost;Database=Football_Tournament_Management;User=root;Password=2704;";
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public MySqlConnection openConnection()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
            }
            catch(Exception ) {
                throw new Exception("$Can't connect to database: {ex.Message}");
            }

            return conn;
        }

        public void closeConnection(MySqlConnection connection)
        {
            if(connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }


        //Find property name by ID, Table name, Property name
        public string GetNameById(string tableName, string idColumnName, string targetColumnName, int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = $"SELECT {targetColumnName} FROM {tableName} WHERE {idColumnName} = @Id";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    var result = command.ExecuteScalar();
                    return result != null ? result.ToString() : null;
                }
            }
        }

    }


}
