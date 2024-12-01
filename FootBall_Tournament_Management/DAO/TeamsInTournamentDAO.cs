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
    internal class TeamsInTournamentDAO
    {
        DatabaseHelper db = new DatabaseHelper();

        public void addTeam(int tournamentID, int teamID)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Teams_in_tournament (TournamentID, TeamID) VALUES (@TournamentID, @TeamID);";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TournamentID", tournamentID);
                    command.Parameters.AddWithValue("@TeamID", teamID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void ChangeTeam(int teamID1, int teamID2)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Teams_in_tournament SET TeamID = @teamID2 WHERE TeamID = @teamID1";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@teamID1", teamID1);
                    command.Parameters.AddWithValue("@teamID2", teamID2);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteTeam(int teamID)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Teams_in_tournament WHERE TeamID = @TeamID";
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
                string query = "SELECT * FROM Teams_in_tournament";
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
    }
}
