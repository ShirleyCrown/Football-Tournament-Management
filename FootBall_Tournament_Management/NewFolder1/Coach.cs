using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall_Tournament_Management.NewFolder1
{
    internal class Coach
    {
        private string coachID;
        private string coachName;
        private DateTime dob;

        public Coach(string coachID, string coachName, DateTime dob)
        {
            this.CoachID = coachID;
            this.CoachName = coachName;
            this.Dob = dob;
        }

        public string CoachID { get => coachID; set => coachID = value; }
        public string CoachName { get => coachName; set => coachName = value; }
        public DateTime Dob { get => dob; set => dob = value; }
    }
}
