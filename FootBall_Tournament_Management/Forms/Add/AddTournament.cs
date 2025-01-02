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
        Main_screen screen;
        private readonly string user;
        public AddTournament(string user, Main_screen screen)
        {
            InitializeComponent();
            this.user = user;
            this.screen = screen;
        }

        public AddTournament()
        {
        }

        public void InvokeButtonClick()
        {
            btnAdd.PerformClick();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please insert all data !!!");
                return;
            }

            if (dpkStart.Value > dpkEnd.Value)
            {
                MessageBox.Show("Invalid start date !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure to add new tournament ?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            string[] sDate = dpkStart.Text.Split('/');
            DateTime sDateTime = new DateTime(int.Parse(sDate[2]), int.Parse(sDate[1]), int.Parse(sDate[0]));

            string[] eDate = dpkEnd.Text.Split('/');
            DateTime eDateTime = new DateTime(int.Parse(eDate[2]), int.Parse(eDate[1]), int.Parse(eDate[0]));

            Tournament tournament = new Tournament(user, txtName.Text.Trim(), sDateTime, eDateTime, txtLocation.Text.Trim());

            TournamentDAO tournamentDAO = new TournamentDAO();
            tournamentDAO.addTournament(tournament);

            MessageBox.Show("Add new coach successfully !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            screen.InvokeButtonTournamentClick();
            this.Close();
        }
    }
}
