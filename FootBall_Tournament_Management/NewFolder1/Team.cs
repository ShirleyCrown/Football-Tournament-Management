using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall_Tournament_Management.NewFolder1
{
    internal class Team
    {
        private string teamID;
        private string teamName;
        private string coachID;
        private DateTime establishedDate;

        public Team(string teamID, string teamName, string coachID, DateTime establishDate)
        {
            this.TeamID = teamID;
            this.TeamName = teamName;
            this.CoachID = coachID;
            this.EstablishedDate = establishDate;
        }

        public string TeamID { get => teamID; set => teamID = value; }
        public string TeamName { get => teamName; set => teamName = value; }
        public string CoachID { get => coachID; set => coachID = value; }
        public DateTime EstablishedDate { get => establishedDate; set => establishedDate = value; }
    }
}