using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall_Tournament_Management.NewFolder1
{
    public class Player
    {
        private int playerID;
        private int teamID;
        private string playerName;
        private string position;
        private DateTime dob;
        private string phoneNumber;
        private int jerseyNumber;

        public Player(int playerID, int teamID, string playerName, string position, DateTime dob, string phoneNumber, int jerseyNumber)
        {
            this.PlayerID = playerID;
            this.TeamID = teamID;
            this.PlayerName = playerName;
            this.Position = position;
            this.Dob = dob;
            this.PhoneNumber = phoneNumber;
            this.JerseyNumber = jerseyNumber;
        }

        public int PlayerID { get => playerID; set => playerID = value; }
        public int TeamID { get => teamID; set => teamID = value; }
        public string PlayerName { get => playerName; set => playerName = value; }
        public string Position { get => position; set => position = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public int JerseyNumber { get => jerseyNumber; set => jerseyNumber = value; }
    }


}
