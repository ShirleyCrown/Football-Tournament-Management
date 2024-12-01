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
    internal class AwardDAO
    {
        private DatabaseHelper db = new DatabaseHelper();

        public void AddAward(Award award)
        {
            using (var connection = db.GetConnection())
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
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Awards SET TournamentID = @TournamentID, AwardName = @AwardName, PrizeAmount = @PrizeAmount WHERE AwardID = @AwardID";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TournamentID", award.TournamentID);
                    command.Parameters.AddWithValue("@AwardName", award.AwardName);
                    command.Parameters.AddWithValue("@PrizeAmount", award.PrizeAmount);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteAward(int awardID)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Awards WHERE AwardID = @AwardID";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AwardID", awardID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllAwards()
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Awards";
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
