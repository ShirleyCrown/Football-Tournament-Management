using FootBall_Tournament_Management.NewFolder1;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;
using Match = FootBall_Tournament_Management.NewFolder1.Match;

namespace FootBall_Tournament_Management.DAO
{
    public class MatchDAO
    {
        private DatabaseHelper db = new DatabaseHelper();

        public void AddMatch(FootBall_Tournament_Management.NewFolder1.Match match)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Matches (TournamentID, Team1ID, Team2ID) " +
                                "VALUES (@TournamentID, @Team1ID, @Team2ID);";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Team1ID", match.Team1ID);
                    command.Parameters.AddWithValue("@Team2ID", match.Team2ID);
                    command.Parameters.AddWithValue("@TournamentID", match.TournamentID);
                    //command.Parameters.AddWithValue("@MatchDate", match.MatchDate);
                    //command.Parameters.AddWithValue("@Location", match.Location);
                    //command.Parameters.AddWithValue("@Result", match.Result);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddTeamWin(int matchID, int teamID)
        {
            using(var connection = db.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Matches SET TeamWin = @TeamWin WHERE MatchID = @MatchID";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeamWin", teamID);
                    command.Parameters.AddWithValue("@MatchID", matchID);
                    command.ExecuteNonQuery ();
                }
            }
        }

        public void UpdateMatchInfo(FootBall_Tournament_Management.NewFolder1.Match match)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Matches SET MatchDate = @MatchDate, Location = @Location, Result = @Result WHERE MatchID = @MatchID";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MatchDate", match.MatchDate);
                    command.Parameters.AddWithValue("@Location", match.Location);
                    command.Parameters.AddWithValue("@Result", match.Result);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateMatchWinner(FootBall_Tournament_Management.NewFolder1.Match match, int winner)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Matches SET TeamWin = @TeamWin WHERE MatchID = @MatchID";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeamWin", winner);
                    command.Parameters.AddWithValue("@MatchID", match.MatchID); ;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateMatchResult(int matchID, string res)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Matches SET Result = @Result WHERE MatchID = @MatchID";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Result", res);
                    command.Parameters.AddWithValue("@MatchID", matchID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateMatchInfo(int matchID, DateTime matchDate, string location)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Matches SET MatchDate = @MatchDate, Location = @Location WHERE MatchID = @MatchID";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MatchDate", matchDate);
                    command.Parameters.AddWithValue("@Location", location);
                    command.Parameters.AddWithValue("@MatchID", matchID);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteMatch(int matchId)
        {
            using (var connection = db.GetConnection())
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
            using (var connection = db.GetConnection())
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

        public String GetScoreByID(int matchID)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT Result FROM Matches WHERE MatchID = @MatchID";

                using(var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MatchID", matchID);
                    using(var reader = command.ExecuteReader())
                    {
                        if (reader.Read() && reader[0] != DBNull.Value )
                        {
                            return reader.GetString(0);
                        }
                    }
                }
            }
            return "";
        }

        public Match GetMatchByID(int matchID)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Matches WHERE MatchID = @MatchID";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MatchID", matchID);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int matchId = reader.GetInt32(0);
                            int tournamentID = reader.GetInt32(1);
                            int team1ID = reader.GetInt32(2);
                            int team2ID = reader.GetInt32(3);
                            DateTime matchDate = !reader.IsDBNull(4) ? reader.GetDateTime(4) : DateTime.Now;
                            string location = !reader.IsDBNull(5) ? reader.GetString(5) : "";
                            int winner = !reader.IsDBNull(6) ? reader.GetInt32(6) : 0;
                            string avatarPath = !reader.IsDBNull(7) ? reader.GetString(7) : "";

                            return new Match(matchId, tournamentID, team1ID, team2ID, matchDate, location, winner, avatarPath);
                        }
                    }
                }
            }
            return null;
        }


        public DataTable GetAllMatchesInTournament(int tournamentID)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Matches WHERE TournamentID = @TournamentID";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TournamentID", tournamentID);

                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}
