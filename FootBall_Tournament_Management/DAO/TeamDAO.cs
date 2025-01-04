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
                string query = "INSERT INTO Teams (TeamName, CoachID, EstablishedDate, AvatarPath) VALUES (@TeamName, @CoachID, @EstablishedDate, @AvatarPath);";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeamName", team.TeamName);
                    command.Parameters.AddWithValue("@CoachID", team.CoachID);
                    command.Parameters.AddWithValue("@EstablishedDate", team.EstablishedDate);
                    command.Parameters.AddWithValue("@AvatarPath", team.AvatarPath);

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
                        if (reader.Read() && reader[5] != DBNull.Value) 
                        {
                            return new Team(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetDateTime(3), reader.GetString(5));
                        }
                        else
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

        public DataTable GetTeamMembers(int teamID, string name, string position, DateTime startDate, DateTime endDate)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Players WHERE TeamID = @TeamID AND IsDeleted = 0 " +
                                "AND PlayerName LIKE CONCAT('%', @PlayerName, '%') AND Position = @Position " +
                                "AND BirthDate BETWEEN @StartDate AND @EndDate";


                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeamID", teamID);
                    command.Parameters.AddWithValue("@PlayerName", name);
                    command.Parameters.AddWithValue("@Position", position);
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);

                    using (var adaptor = new MySqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adaptor.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        // Overload 1: TeamID + Name + Position
        public DataTable GetTeamMembers(int teamID, string name, string position)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Players WHERE TeamID = @TeamID AND IsDeleted = 0 " +
                    "AND PlayerName LIKE CONCAT('%', @PlayerName, '%') AND Position = @Position";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeamID", teamID);
                    command.Parameters.AddWithValue("@PlayerName", name);
                    command.Parameters.AddWithValue("@Position", position);

                    using (var adaptor = new MySqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adaptor.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        // Overload 2: TeamID + Name + Date Range
        public DataTable GetTeamMembers(int teamID, string name, DateTime startDate, DateTime endDate)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Players WHERE TeamID = @TeamID AND IsDeleted = 0 " +
                    "AND PlayerName LIKE CONCAT('%', @PlayerName, '%') AND BirthDate BETWEEN @StartDate AND @EndDate";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeamID", teamID);
                    command.Parameters.AddWithValue("@PlayerName", name);
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);

                    using (var adaptor = new MySqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adaptor.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        // Overload 3: TeamID + Position + Date Range
        public DataTable GetTeamMembers(string position, int teamID, DateTime startDate, DateTime endDate)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Players WHERE TeamID = @TeamID AND IsDeleted = 0 " +
                    "AND Position = @Position AND BirthDate BETWEEN @StartDate AND @EndDate";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeamID", teamID);
                    command.Parameters.AddWithValue("@Position", position);
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);

                    using (var adaptor = new MySqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adaptor.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        // Overload 4: TeamID + Name
        public DataTable GetTeamMembers(int teamID, string name)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Players WHERE TeamID = @TeamID AND IsDeleted = 0 " +
                    "AND PlayerName LIKE CONCAT('%', @PlayerName, '%')";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeamID", teamID);
                    command.Parameters.AddWithValue("@PlayerName", name);

                    using (var adaptor = new MySqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adaptor.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        // Overload 5: TeamID + Position
        public DataTable GetTeamMembers(string position, int teamID)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Players WHERE TeamID = @TeamID AND IsDeleted = 0 " +
                    "AND Position = @Position";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeamID", teamID);
                    command.Parameters.AddWithValue("@Position", position);

                    using (var adaptor = new MySqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adaptor.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        // Overload 6: TeamID + Date Range
        public DataTable GetTeamMembers(int teamID, DateTime startDate, DateTime endDate)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Players WHERE TeamID = @TeamID AND IsDeleted = 0 " +
                    "AND BirthDate BETWEEN @StartDate AND @EndDate";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeamID", teamID);
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);

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
