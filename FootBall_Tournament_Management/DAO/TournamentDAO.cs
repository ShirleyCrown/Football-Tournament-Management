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
    internal class TournamentDAO
    {
        DatabaseHelper db = new DatabaseHelper();

        public void addTournament(Tournament tournament)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Tournaments (TournamentCreator, TournamentName, StartDate, EndDate, Location) VALUES (@TournamentCreator, @TournamentName, @StartDate, @EndDate, @Location);";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TournamentCreator", tournament.TournamentCreator);
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
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Tournaments  SET TournamentCreator = @TournamentCreator, TournamentName = @TournamentName, StartDate = @StartDate, EndDate = @EndDate, Location = @Location WHERE TournamentID = @TournamentID";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TournamentID", tournament.TournamentID);
                    command.Parameters.AddWithValue("@TournamentCreator", tournament.TournamentCreator);
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
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Tournaments  WHERE TournamentID = @TournamentID";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TournamentID", tournament.TournamentID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllTournaments()
        {
            using (var connection = db.GetConnection())
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

        public Tournament GetOneTournament(int TournamentID)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Tournaments  WHERE TournamentID = @TournamentID;";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TournamentID", TournamentID);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Tournament(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetDateTime(3), reader.GetDateTime(4), reader.GetString(5));
                        }
                    }
                }
            }
            return null;
        }
    }
}
