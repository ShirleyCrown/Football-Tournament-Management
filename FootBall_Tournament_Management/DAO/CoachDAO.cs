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
                string query = "INSERT INTO Coachs (CoachName, BirthDate, PhoneNumber, Forte, AvatarPath) VALUES (@CoachName, @BirthDate, @PhoneNumber, @Forte, @AvatarPath);";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CoachName", coach.CoachName);
                    command.Parameters.AddWithValue("@BirthDate", coach.Dob);
                    command.Parameters.AddWithValue("@PhoneNumber", coach.PhoneNumber);
                    command.Parameters.AddWithValue("@Forte", coach.Forte);
                    command.Parameters.AddWithValue("@AvatarPath", string.IsNullOrEmpty(coach.AvatarPath) ? null : coach.AvatarPath);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateCoach(Coach coach)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Coachs SET CoachName = @CoachName, BirthDate = @BirthDate, PhoneNumber = @PhoneNumber, Forte = @Forte, AvatarPath = @AvatarPath WHERE CoachID = @CoachID";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CoachID", coach.CoachID);
                    command.Parameters.AddWithValue("@CoachName", coach.CoachName);
                    command.Parameters.AddWithValue("@BirthDate", coach.Dob);
                    command.Parameters.AddWithValue("@PhoneNumber", coach.PhoneNumber);
                    command.Parameters.AddWithValue("@Forte", coach.Forte);
                    command.Parameters.AddWithValue("@AvatarPath", coach.AvatarPath);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteCoach(int coachId)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Coachs SET IsDeleted = 1 WHERE CoachID = @CoachID";
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
                string query = "SELECT * FROM Coachs  WHERE IsDeleted = 0";
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
                        if (reader.Read() && reader[6] != DBNull.Value)
                        {
                            return new Coach(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2), reader.GetString(3), reader.GetString(4), reader.GetString(6));
                        }
                        else
                        {
                            return new Coach(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2), reader.GetString(3), reader.GetString(4));
                        }
                    }
                }
            }
            return null;
        }

        public DataTable GetCoachsByNameLike(string coachName)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Coachs WHERE CoachName LIKE CONCAT('%' @CoachName, '%');";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CoachName", coachName);

                    using (var adaptor = new MySqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adaptor.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public string GetNameByID(int coachID)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT CoachName FROM Coachs WHERE CoachID = @CoachID;";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CoachID", coachID);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetString(0);
                        }
                    }
                }
            }
            return "";
        }
    }
}
