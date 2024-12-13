using FootBall_Tournament_Management.DAO;
using FootBall_Tournament_Management.NewFolder1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootBall_Tournament_Management.Forms
{
    public partial class AddTournament : Form
    {
        private readonly string user;
        public AddTournament(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] sDate = dpkStart.Text.Split('/');
            DateTime sDateTime = new DateTime(int.Parse(sDate[2]), int.Parse(sDate[1]), int.Parse(sDate[0]));

            string[] eDate = dpkEnd.Text.Split('/');
            DateTime eDateTime = new DateTime(int.Parse(eDate[2]), int.Parse(eDate[1]), int.Parse(eDate[0]));

            Tournament tournament = new Tournament(user, txtName.Text, sDateTime, eDateTime, txtLocation.Text);

            TournamentDAO tournamentDAO = new TournamentDAO();
            tournamentDAO.addTournament(tournament);

            txtName.Clear();
            txtLocation.Clear();
            dpkEnd.Value = DateTime.Now;
            dpkStart.Value = DateTime.Now;
        }
    }
}
