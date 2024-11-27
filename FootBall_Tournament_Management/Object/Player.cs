using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall_Tournament_Management.NewFolder1
{
    internal class Player
    {
        private string playerID;
        private string teamID;
        private string playerName;
        private string position;
        private DateTime dob;
        private int jerseyNumber;

        public Player(string playerID, string teamID, string playerName, string position, DateTime dob, int jerseyNumber)
        {
            this.PlayerID = playerID;
            this.TeamID = teamID;
            this.PlayerName = playerName;
            this.Position = position;
            this.Dob = dob;
            this.JerseyNumber = jerseyNumber;
        }

        public string PlayerID { get => playerID; set => playerID = value; }
        public string TeamID { get => teamID; set => teamID = value; }
        public string PlayerName { get => playerName; set => playerName = value; }
        public string Position { get => position; set => position = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public int JerseyNumber { get => jerseyNumber; set => jerseyNumber = value; }
    }
}
