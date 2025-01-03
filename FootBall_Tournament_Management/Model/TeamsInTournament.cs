using FootBall_Tournament_Management.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall_Tournament_Management.Object
{
    internal class TeamsInTournament
    {
        private int tournamentID;
        private List<Team> teams;

        public TeamsInTournament(int tournamentID, List<Team> teams)
        {
            this.TournamentID = tournamentID;
            this.Teams = teams;
        }

        public TeamsInTournament() 
        {
            this.Teams = new List<Team>();  
        }

        public int TournamentID { get => tournamentID; set => tournamentID = value; }
        internal List<Team> Teams { get => teams; set => teams = value; }
    }
}
