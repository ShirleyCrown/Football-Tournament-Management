using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall_Tournament_Management.NewFolder1
{
    internal class Match
    {
        private string matchID;
        private string tournamentID;
        private string team1ID;
        private string team2ID;
        private DateTime matchDate;
        private string location;
        private string result;

        public Match(string matchID, string tournamentID, string team1, string team2, DateTime matchDate, string location, string result)
        {
            this.MatchID = matchID;
            this.TournamentID = tournamentID;
            this.Team1ID = team1;
            this.Team2ID = team2;
            this.MatchDate = matchDate;
            this.Location = location;
            this.Result = result;
        }

        public string MatchID { get => matchID; set => matchID = value; }
        public string TournamentID { get => tournamentID; set => tournamentID = value; }
        public string Team1ID { get => team1ID; set => team1ID = value; }
        public string Team2ID { get => team2ID; set => team2ID = value; }
        public DateTime MatchDate { get => matchDate; set => matchDate = value; }
        public string Location { get => location; set => location = value; }
        public string Result { get => result; set => result = value; }
    }
}
