using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall_Tournament_Management.NewFolder1
{
    internal class Rules
    {
        private string ruleID;
        private string tournamentID;
        private string ruleDescription;

        public Rules(string ruleID, string tournamentID, string ruleDescription)
        {
            this.RuleID = ruleID;
            this.TournamentID = tournamentID;
            this.RuleDescription = ruleDescription;
        }

        public string RuleID { get => ruleID; set => ruleID = value; }
        public string TournamentID { get => tournamentID; set => tournamentID = value; }
        public string RuleDescription { get => ruleDescription; set => ruleDescription = value; }
    }
}
