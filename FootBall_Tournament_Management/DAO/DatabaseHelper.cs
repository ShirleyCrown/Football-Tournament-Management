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

        DatabaseHelper() 
        {
            connectionString = "Server=localhost;Database=Footbal_Tournament_Management;User=root;Password=2704;";
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
            catch(Exception ex) {
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
        #region CRUD for Coach
        public void addCoach (Coach coach)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Coachs (CoachName, BirthDate) VALUES (@CoachName, @BirthDate);";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CoachName", coach.CoachName);
                    command.Parameters.AddWithValue("@BirthDate", coach.CoachName);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateCoach(int coachId, string coachName, DateTime birthDate)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "UPDATE Coachs SET CoachName = @CoachName, BirthDate = @BirthDate WHERE CoachID = @CoachID";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CoachID", coachId);
                    command.Parameters.AddWithValue("@CoachName", coachName);
                    command.Parameters.AddWithValue("@BirthDate", birthDate);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteCoach(int coachId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Coachs WHERE CoachID = @CoachID";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CoachID", coachId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllCoaches()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Coachs";
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
        #endregion

        #region CRUD for Tournament
        public void addTournament(Tournament tournament)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Tournaments (TournamentName, StartDate, EndDate, Location) VALUES (@TournamentName, @StartDate, @EndDate, @Location);";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TournamentName", tournament.TournamentName);
                    command.Parameters.AddWithValue("@StartDate", tournament.StartDate);
                    command.Parameters.AddWithValue("@EndDate", tournament.EndDate);
                    command.Parameters.AddWithValue("@Location", tournament.Location);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateTournament(Tournament tournament)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "UPDATE Coachs SET TournamentName = @TournamentName, StartDate = @StartDate, EndDate = @EndDate, Location = @Location WHERE TournamentID = @TournamentID";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TournamentID", tournament.TournamentID);
                    command.Parameters.AddWithValue("@TournamentName", tournament.TournamentName);
                    command.Parameters.AddWithValue("@StartDate", tournament.StartDate);
                    command.Parameters.AddWithValue("@EndDate", tournament.EndDate);
                    command.Parameters.AddWithValue("@Location", tournament.Location);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteTournament(Tournament tournament)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Coachs WHERE TournamentID = @TournamentID";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TournamentID", tournament.TournamentID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllTournaments()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Tournaments";
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
        #endregion

        #region CRUD for Teamm
        public void addTeam(Team team)
        {
            using (var connection = GetConnection())
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
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "UPDATE Coachs SET TeamName = @TeamName, CouchID = @CouchID, EstablishedDate = @EstablishedDate WHERE TeamID = @TeamID";
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

        public void DeleteTeam(Team team)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Coachs WHERE TournamentID = @TournamentID";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TournamentID", team.TeamID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllTeams()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Teams";
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
        #endregion

        #region CRUD for Player
        public void AddPlayer(Player player)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Players (PlayerName, TeamID, Position, BirthDate) VALUES (@PlayerName, @TeamID, @Position, @BirthDate);";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PlayerName", player.PlayerName);
                    command.Parameters.AddWithValue("@TeamID", player.TeamID);
                    command.Parameters.AddWithValue("@Position", player.Position);
                    command.Parameters.AddWithValue("@BirthDate", player.Dob);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdatePlayer(Player player)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "UPDATE Players SET PlayerName = @PlayerName, TeamID = @TeamID, Position = @Position, BirthDate = @BirthDate WHERE PlayerID = @PlayerID";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PlayerID", player.PlayerID);
                    command.Parameters.AddWithValue("@PlayerName", player.PlayerName);
                    command.Parameters.AddWithValue("@TeamID", player.TeamID);
                    command.Parameters.AddWithValue("@Position", player.Position);
                    command.Parameters.AddWithValue("@BirthDate", player.Dob);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeletePlayer(int playerId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Players WHERE PlayerID = @PlayerID";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PlayerID", playerId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllPlayers()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Players";

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
        #endregion

        #region CRUD for Match
        public void AddMatch(Match match)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Matches (HomeTeamID, AwayTeamID, TournamentID, MatchDate, Location, Score) VALUES (@HomeTeamID, @AwayTeamID, @TournamentID, @MatchDate, @Location, @Score);";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@HomeTeamID", match.Team1ID);
                    command.Parameters.AddWithValue("@AwayTeamID", match.Team2ID);
                    command.Parameters.AddWithValue("@TournamentID", match.TournamentID);
                    command.Parameters.AddWithValue("@MatchDate", match.MatchDate);
                    command.Parameters.AddWithValue("@Location", match.Location);
                    command.Parameters.AddWithValue("@Score", match.Result);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateMatch(Match match)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "UPDATE Matches SET HomeTeamID = @HomeTeamID, AwayTeamID = @AwayTeamID, TournamentID = @TournamentID, MatchDate = @MatchDate, Location = @Location, Score = @Score WHERE MatchID = @MatchID";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MatchID", match.MatchID);
                    command.Parameters.AddWithValue("@HomeTeamID", match.Team1ID);
                    command.Parameters.AddWithValue("@AwayTeamID", match.Team2ID);
                    command.Parameters.AddWithValue("@TournamentID", match.TournamentID);
                    command.Parameters.AddWithValue("@MatchDate", match.MatchDate);
                    command.Parameters.AddWithValue("@Location", match.Location);
                    command.Parameters.AddWithValue("@Score", match.Result);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteMatch(int matchId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Matches WHERE MatchID = @MatchID";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MatchID", matchId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllMatches()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Matches";

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
        #endregion

        #region CRUD for Awards
        public void AddAward(Award award)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Awards (TournamentID, AwardName, PrizeAmount) VALUES (@TournamentID, @AwardName, @PrizeAmount);";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TournamentID", award.TournamentID);
                    command.Parameters.AddWithValue("@AwardName", award.AwardName);
                    command.Parameters.AddWithValue("@PrizeAmount", award.PrizeAmount);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateAward(Award award)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "UPDATE Awards SET TournamentID = @TournamentID, AwardName = @AwardName, PrizeAmount = @PrizeAmount WHERE AwardID = @AwardID;";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AwardID", award.AwardID);
                    command.Parameters.AddWithValue("@TournamentID", award.TournamentID);
                    command.Parameters.AddWithValue("@AwardName", award.AwardName);
                    command.Parameters.AddWithValue("@PrizeAmount", award.PrizeAmount);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteAward(int awardId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Awards WHERE AwardID = @AwardID;";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AwardID", awardId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllAwards()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Awards;";

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
        #endregion

        #region CRUD for Rules
        public void AddRule(Rules rule)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Rules (TournamentID, RuleDescription) VALUES (@TournamentID, @RuleDescription);";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TournamentID", rule.TournamentID);
                    command.Parameters.AddWithValue("@RuleDescription", rule.RuleDescription);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateRule(Rules rule)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "UPDATE Rules SET TournamentID = @TournamentID, RuleDescription = @RuleDescription WHERE RuleID = @RuleID;";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RuleID", rule.RuleID);
                    command.Parameters.AddWithValue("@TournamentID", rule.TournamentID);
                    command.Parameters.AddWithValue("@RuleDescription", rule.RuleDescription);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteRule(int ruleId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Rules WHERE RuleID = @RuleID;";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RuleID", ruleId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllRules()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Rules;";

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
        #endregion


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
