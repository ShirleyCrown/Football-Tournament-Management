using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall_Tournament_Management.NewFolder1
{
    internal class Team
    {
        private int teamID;
        private string teamName;
        private int coachID;
        private DateTime establishedDate;

        public Team(int teamID, string teamName, int coachID, DateTime establishDate)
        {
            this.TeamID = teamID;
            this.TeamName = teamName;
            this.CoachID = coachID;
            this.EstablishedDate = establishDate;
        }

        public int TeamID { get => teamID; set => teamID = value; }
        public string TeamName { get => teamName; set => teamName = value; }
        public int CoachID { get => coachID; set => coachID = value; }
        public DateTime EstablishedDate { get => establishedDate; set => establishedDate = value; }
    }
}