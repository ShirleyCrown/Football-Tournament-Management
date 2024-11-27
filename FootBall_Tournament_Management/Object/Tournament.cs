using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall_Tournament_Management.NewFolder1
{
    internal class Tournament
    {
        private string tournamentID;
        private string tournamentName;
        private DateTime startDate;
        private DateTime endDate;
        private string location;

        public Tournament(string tournamentID, string tournamentName, DateTime startDate, DateTime endDate, string location)
        {
            this.TournamentID = tournamentID;
            this.TournamentName = tournamentName;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Location = location;
        }

        public string TournamentID { get => tournamentID; set => tournamentID = value; }
        public string TournamentName { get => tournamentName; set => tournamentName = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public string Location { get => location; set => location = value; }
    }
}
