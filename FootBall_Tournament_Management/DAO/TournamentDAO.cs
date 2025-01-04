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
                string query = "INSERT INTO Tournaments (TournamentCreator, TournamentName, StartDate, EndDate, Location, AvatarPath) VALUES (@TournamentCreator, @TournamentName, @StartDate, @EndDate, @Location, @AvatarPath);";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TournamentCreator", tournament.TournamentCreator);
                    command.Parameters.AddWithValue("@TournamentName", tournament.TournamentName);
                    command.Parameters.AddWithValue("@StartDate", tournament.StartDate);
                    command.Parameters.AddWithValue("@EndDate", tournament.EndDate);
                    command.Parameters.AddWithValue("@Location", tournament.Location);
                    command.Parameters.AddWithValue("@AvatarPath", tournament.AvatarPath);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateTournament(Tournament tournament)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Tournaments SET TournamentName = @TournamentName, StartDate = @StartDate, EndDate = @EndDate, Location = @Location WHERE TournamentID = @TournamentID";
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

        public void DeleteTournament(int tournamentID)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Tournaments SET IsDeleted = 1 WHERE TournamentID = @TournamentID";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TournamentID", tournamentID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateStage(int tournamentID, int stage)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Tournaments SET Stage = @Stage WHERE TournamentID = @TournamentID";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TournamentID", tournamentID);
                    command.Parameters.AddWithValue("@Stage", stage);

                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllTournaments()
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Tournaments WHERE IsDeleted = 0";
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

        public Tournament GetTournamentByID(int TournamentID)
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
                        if (reader.Read() && reader[7] != DBNull.Value)
                        {
                            return new Tournament(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2), reader.GetDateTime(3), reader.GetString(4), reader.GetString(7), reader.GetInt32(8));
                        }
                        else
                        {
                            return new Tournament(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2), reader.GetDateTime(3), reader.GetString(4), reader.GetInt32(8));
                        }
                    }
                }
            }
        }

        public DataTable GetTournamentsByNameLike(String tournamentName)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Tournaments WHERE TournamentName LIKE CONCAT('%', @TournamentName, '%');";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TournamentName", tournamentName);

                    using (var adaptor = new MySqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adaptor.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}
