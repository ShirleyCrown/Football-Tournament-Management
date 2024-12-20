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

        public void ChangeTeam(int tournamentID, int teamID)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Teams_in_tournament SET TeamID = @teamID WHERE TournamentID = @TournamentID";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@teamID", teamID);
                    command.Parameters.AddWithValue("@TournamentID", tournamentID);
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
        public void DeleteAllTeams(int tournamentID)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Teams_in_tournament WHERE TournamentID = @TournamentID";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TournamentID", tournamentID);
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

        public TeamsInTournament GetAllTeamsInTournament(int tournamentID)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Teams_in_tournament WHERE TournamentID = @TournamentID";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TournamentID", tournamentID);

                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        
                        if (dt.Rows.Count > 0)
                        {
                            TeamsInTournament teamsInTournament = new TeamsInTournament();
                            teamsInTournament.TournamentID = tournamentID;
                            foreach (DataRow row in dt.Rows)
                            {
                                TeamDAO teamDAO = new TeamDAO();
                                Team team = teamDAO.GetTeamByID(Convert.ToInt32(row[1]));
                                teamsInTournament.Teams.Add(team);
                            }

                            return teamsInTournament;
                        }
                    }
                }
            }
            return new TeamsInTournament();
        }
    }
}
