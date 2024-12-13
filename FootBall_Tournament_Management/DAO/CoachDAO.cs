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
    internal class CoachDAO
    {
        private DatabaseHelper db = new DatabaseHelper();

        public void AddCoach(Coach coach)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Coachs (CoachName, BirthDate, PhoneNumber, Forte) VALUES (@CoachName, @BirthDate, @PhoneNumber, @Forte);";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CoachName", coach.CoachName);
                    command.Parameters.AddWithValue("@BirthDate", coach.Dob);
                    command.Parameters.AddWithValue("@PhoneNumber", coach.PhoneNumber);
                    command.Parameters.AddWithValue("@Forte", coach.Forte);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateCoach(Coach coach)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Coachs SET CoachName = @CoachName, BirthDate = @BirthDate, PhoneNumber = @PhoneNumber, Forte = @Forte WHERE CoachID = @CoachID";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CoachID", coach.CoachID);
                    command.Parameters.AddWithValue("@CoachName", coach.CoachName);
                    command.Parameters.AddWithValue("@BirthDate", coach.Dob);
                    command.Parameters.AddWithValue("@PhoneNumber", coach.PhoneNumber);
                    command.Parameters.AddWithValue("@Forte", coach.Forte);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteCoach(int coachId)
        {
            using (var connection = db.GetConnection())
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
            using (var connection = db.GetConnection())
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

        public Coach GetCoachByID(int coachID)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Coachs WHERE CoachID = @CoachID;";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CoachID", coachID);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Coach(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2), reader.GetString(3), reader.GetString(4));
                        }
                    }
                }
            }
            return null;
        }
    }
}
