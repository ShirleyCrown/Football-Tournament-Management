using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall_Tournament_Management.NewFolder1
{
    internal class Award
    {
        private string awardID;
        private string tournamentID;
        private string awardName;
        private long prizeAmount;

        public Award(string adwardID, string tournamentID, string awardName, long prizeAmount)
        {
            this.AwardID = adwardID;
            this.TournamentID = tournamentID;
            this.AwardName = awardName;
            this.PrizeAmount = prizeAmount;
        }

        public string AwardID { get => awardID; set => awardID = value; }
        public string TournamentID { get => tournamentID; set => tournamentID = value; }
        public string AwardName { get => awardName; set => awardName = value; }
        public long PrizeAmount { get => prizeAmount; set => prizeAmount = value; }
    }
}
