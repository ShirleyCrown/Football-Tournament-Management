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
    internal class RuleDAO
    {
        DatabaseHelper db = new DatabaseHelper();

        public void AddRule(Rules rule)
        {
            using (var connection = db.GetConnection())
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
            using (var connection = db.GetConnection())
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

        public void DeleteRuleInTournament(int tournamentID)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Rules WHERE TournamentID = @TournamentID;";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TournamentID", tournamentID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllRulesInTournament(int tournamentID)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Rules WHERE TournamentID = @TournamentID;";

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
