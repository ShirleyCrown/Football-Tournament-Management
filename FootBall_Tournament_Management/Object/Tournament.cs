using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall_Tournament_Management.NewFolder1
{
    internal class Tournament
    {
        private int tournamentCreator;
        private int tournamentID;
        private string tournamentName;
        private DateTime startDate;
        private DateTime endDate;
        private string location;

        public Tournament(int tournamentCreator, int tournamentID, string tournamentName, DateTime startDate, DateTime endDate, string location)
        {
            this.TournamentCreator = tournamentCreator;
            this.TournamentID = tournamentID;
            this.TournamentName = tournamentName;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Location = location;
        }

        public int TournamentCreator { get => tournamentCreator; set => tournamentCreator = value; }
        public int TournamentID { get => tournamentID; set => tournamentID = value; }
        public string TournamentName { get => tournamentName; set => tournamentName = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public string Location { get => location; set => location = value; }
    }
}
