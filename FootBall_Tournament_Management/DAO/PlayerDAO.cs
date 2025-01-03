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
    internal class PlayerDAO
    {
        DatabaseHelper db = new DatabaseHelper();

        public void AddPlayer(Player player)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Players (TeamID, PlayerName, Position, BirthDate, PhoneNumber, JerseyNumber, AvatarPath) VALUES (@TeamID, @PlayerName, @Position, @BirthDate, @PhoneNumber, @JerseyNumber, @AvatarPath);";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PlayerName", player.PlayerName);
                    command.Parameters.AddWithValue("@TeamID", player.TeamID);
                    command.Parameters.AddWithValue("@Position", player.Position);
                    command.Parameters.AddWithValue("@BirthDate", player.Dob);
                    command.Parameters.AddWithValue("@PhoneNumber", player.PhoneNumber);
                    command.Parameters.AddWithValue("@JerseyNumber", player.JerseyNumber);
                    command.Parameters.AddWithValue("@AvatarPath", player.AvatarPath);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdatePlayer(Player player)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Players SET TeamID = @TeamID, PlayerName = @PlayerName, Position = @Position, BirthDate = @BirthDate, PhoneNumber = @PhoneNumber, JerseyNumber = @JerseyNumber " +
                    "           WHERE PlayerID = @PlayerID";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PlayerID", player.PlayerID);
                    command.Parameters.AddWithValue("@PlayerName", player.PlayerName);
                    command.Parameters.AddWithValue("@TeamID", player.TeamID);
                    command.Parameters.AddWithValue("@Position", player.Position);
                    command.Parameters.AddWithValue("@BirthDate", player.Dob);
                    command.Parameters.AddWithValue("@PhoneNumber", player.PhoneNumber);
                    command.Parameters.AddWithValue("@JerseyNumber", player.JerseyNumber);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeletePlayer(int playerId)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Players SET IsDeleted = 1 WHERE PlayerID = @PlayerID";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PlayerID", playerId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeletePlayerByTeamID(int teamID)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Players SET IsDeleted = 1 WHERE TeamID = @TeamID";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeamID", teamID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllPlayers()
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Players WHERE IsDeleted = 0";

                using (var command = new MySqlCommand(query, connection))
                {
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public Player GetPlayerByID(int PlayerID)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Players WHERE PlayerID = @PlayerID;";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PlayerID", PlayerID);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Player(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4), reader.GetString(5), reader.GetInt32(6), reader.GetString(8));
                        }
                    }
                }
            }
            return null;
        }

        public DataTable GetPlayersByNameLike(String playerName)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Players WHERE PlayerName LIKE CONCAT('%', @PlayerName, '%');";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PlayerName", playerName);

                    using (var adaptor = new MySqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adaptor.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public string GetNameByID(int PlayerID)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT PlayerName FROM Players WHERE PlayerID = @PlayerID;";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PlayerID", PlayerID);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetString(0);
                        }
                    }
                }
            }
            return "";
        }
    }
}
