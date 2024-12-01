using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall_Tournament_Management.NewFolder1
{
    internal class Coach
    {
        private int coachID;
        private string coachName;
        private DateTime dob;
        private string phoneNumber;
        private string forte;

        public Coach(int coachID, string coachName, DateTime dob, string phoneNumber, string forte)
        {
            this.CoachID = coachID;
            this.CoachName = coachName;
            this.Dob = dob;
            this.PhoneNumber = phoneNumber;
            this.Forte = forte;
        }

        public int CoachID { get => coachID; set => coachID = value; }
        public string CoachName { get => coachName; set => coachName = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Forte { get => forte; set => forte = value; }
    }
}
