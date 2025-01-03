using FootBall_Tournament_Management.NewFolder1;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FootBall_Tournament_Management.DAO
{
    internal class MatchDAO
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
