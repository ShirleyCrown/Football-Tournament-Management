using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall_Tournament_Management.DAO
{
    internal class RoleDAO
    {
        DatabaseHelper db = new DatabaseHelper();

        public bool IsAdmin(string username)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT AccountRole FROM Accounts WHERE Username = @Username";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read()) 
                        {
                            string role = reader.GetString("AccountRole");
                            return role.Equals("admin", StringComparison.OrdinalIgnoreCase);
                        }
                    }
                }
            }
            return false;
        }

        public void AllocateAdminRole(string username)
        {
            using(var connection = db.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Accounts SET AccountRole = @AccountRole WHERE Username = @Username;";

                using(var command = new MySqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@AccountRole", "admin");
                    command.Parameters.AddWithValue("@Username", username);
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
