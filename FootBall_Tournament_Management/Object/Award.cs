using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall_Tournament_Management.NewFolder1
{
    internal class Award
    {
        private int awardID;
        private int tournamentID;
        private string awardName;
        private long prizeAmount;

        public Award(int awardID, int tournamentID, string awardName, long prizeAmount)
        {
            this.AwardID = awardID;
            this.TournamentID = tournamentID;
            this.AwardName = awardName;
            this.PrizeAmount = prizeAmount;
        }

        public int AwardID { get => awardID; set => awardID = value; }
        public int TournamentID { get => tournamentID; set => tournamentID = value; }
        public string AwardName { get => awardName; set => awardName = value; }
        public long PrizeAmount { get => prizeAmount; set => prizeAmount = value; }
    }
}
