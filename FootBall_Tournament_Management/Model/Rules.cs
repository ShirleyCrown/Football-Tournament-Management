using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall_Tournament_Management.NewFolder1
{
    internal class Rules
    {
        private int ruleID;
        private int tournamentID;
        private string ruleDescription;

        public Rules(int ruleID, int tournamentID, string ruleDescription)
        {
            this.RuleID = ruleID;
            this.TournamentID = tournamentID;
            this.RuleDescription = ruleDescription;
        }

        public Rules(int tournamentID, string ruleDescription)
        {
            this.TournamentID = tournamentID;
            this.RuleDescription = ruleDescription;
        }

        public int RuleID { get => ruleID; set => ruleID = value; }
        public int TournamentID { get => tournamentID; set => tournamentID = value; }
        public string RuleDescription { get => ruleDescription; set => ruleDescription = value; }
    }
}
