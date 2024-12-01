using FootBall_Tournament_Management.NewFolder1;
using FootBall_Tournament_Management.Object;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall_Tournament_Management.DAO
{
    internal class AccountDAO
    {
        readonly DatabaseHelper db = new DatabaseHelper();

        public void AddAccount(Account account)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Accounts (Username, Password, AccountRole) VALUES (@Username, @Password, @AccountRole);";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", account.Username);
                    command.Parameters.AddWithValue("@Password", account.Password);
                    command.Parameters.AddWithValue("@AccountRole", account.AccountRole);
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool IsExisted(string username, string password)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Accounts WHERE Username = @Username AND Password = @Password";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0; 
                }
            }
        }

    }
}
