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
    internal class TeamDAO
    {
        DatabaseHelper db = new DatabaseHelper();

        public void addTeam(Team team)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Teams (TeamName, CoachID, EstablishedDate) VALUES (@TeamName, @CoachID, @EstablishedDate);";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeamName", team.TeamName);
                    command.Parameters.AddWithValue("@CoachID", team.CoachID);
                    command.Parameters.AddWithValue("@EstablishedDate", team.EstablishedDate);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateTeam(Team team)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Teams SET TeamName = @TeamName, CoachID = @CoachID, EstablishedDate = @EstablishedDate WHERE TeamID = @TeamID";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeamID", team.TeamID);
                    command.Parameters.AddWithValue("@TeamName", team.TeamName);
                    command.Parameters.AddWithValue("@CoachID", team.CoachID);
                    command.Parameters.AddWithValue("@EstablishedDate", team.EstablishedDate);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteTeam(int teamID)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Teams SET IsDeleted = 1 WHERE TeamID = @TeamID";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeamID", teamID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllTeams()
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Teams WHERE IsDeleted = 0";
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

        public Team GetTeamByID(int teamID)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Teams WHERE TeamID = @TeamID;";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeamID", teamID);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read()) 
                        {
                            return new Team(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetDateTime(3));
                        }
                    }
                }
            }
            return null;
        }

        public DataTable GetTeamsByNameLike(string teamName)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Teams WHERE TeamName LIKE CONCAT('%', @TeamName, '%')";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeamName", teamName);

                    using (var adaptor = new MySqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adaptor.Fill(dt);
                        return dt;
                    }
                }
            }
            
        }

        public DataTable GetTeamMembers(int teamID)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Players WHERE TeamID = @TeamID AND IsDeleted = 0";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeamID", teamID);

                    using (var adaptor = new MySqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adaptor.Fill(dt);
                        return dt;
                    }
                }
            }

        }

        public string GetNameByID(int teamID)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT TeamName FROM Teams WHERE TeamID = @TeamID;";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeamID", teamID);

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
