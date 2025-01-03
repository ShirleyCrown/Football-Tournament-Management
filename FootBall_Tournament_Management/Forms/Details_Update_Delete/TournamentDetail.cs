﻿using FootBall_Tournament_Management.DAO;
using FootBall_Tournament_Management.NewFolder1;
using FootBall_Tournament_Management.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FootBall_Tournament_Management.Forms.Details_Update_Delete
{
    public partial class TournamentDetail : Form
    {
        private int tournamentID;
        private int count;
        Main_screen screen;
        public TournamentDetail(int tournamentID, Main_screen screen)
        {
            InitializeComponent();
            this.tournamentID = tournamentID;
            DisplayDetails();
            DisplayPrize();
            OptimizeDualListView();
            count = lstTeamInTournament.Items.Count;

            if (lstTeamInTournament.Items.Count > 0)
            {
                btnMoveAllLeft.Enabled = false;
                btnMoveAllRight.Enabled = false;
                btnMoveLeft.Enabled = false;
                btnMoveRight.Enabled = false;
                btnUpdateTeams.Enabled = false;
                btnStart.Enabled = true;
            }

            this.screen = screen;
        }

        public void DisplayDetails()
        {
            TournamentDAO tournamentDAO = new TournamentDAO();
            Tournament tournament = tournamentDAO.GetTournamentByID(tournamentID);

            txtID.Text = tournament.TournamentID.ToString();
            txtName.Text = tournament.TournamentName;
            dpkStart.Value = tournament.StartDate;
            dpkEnd.Value = tournament.EndDate;
            txtLocation.Text = tournament.Location;

            if (string.IsNullOrEmpty(tournament.AvatarPath))
            {
                return;
            }

            string fullPath = GetFullImagePath(tournament.AvatarPath);
            if (File.Exists(fullPath))
            {
                avatar.Image = new Bitmap(fullPath);
            }
        }

        private string GetFullImagePath(string relativePath)
        {
            string rootFolder = AppDomain.CurrentDomain.BaseDirectory;
            return Path.Combine(rootFolder, relativePath);
        }

        public void DisplayPrize()
        {
            AwardDAO awardDAO = new AwardDAO();
            DataTable dt = awardDAO.GetAllAwardsInTournament(tournamentID);

            if(dt.Rows.Count == 0)
            {
                return;
            }

            
            Award award1 = new Award(Convert.ToInt32(dt.Rows[0][0]), dt.Rows[0][1].ToString(), Convert.ToInt32(dt.Rows[0][2]));
            Award award2 = new Award(Convert.ToInt32(dt.Rows[1][0]), dt.Rows[1][1].ToString(), Convert.ToInt32(dt.Rows[1][2]));
            Award award3 = new Award(Convert.ToInt32(dt.Rows[2][0]), dt.Rows[2][1].ToString(), Convert.ToInt32(dt.Rows[2][2]));

            txtChampionPrize.Text = award1.PrizeAmount.ToString();
            txtRunnerup.Text = award2.PrizeAmount.ToString();
            txt2ndRunnerup.Text = award3.PrizeAmount.ToString();
        }

        public void DisplaySavedTeam()
        {
            TeamDAO teamDAO = new TeamDAO();
            DataTable dt = teamDAO.GetAllTeams();

            List<Team> teams = new List<Team>();
            foreach (DataRow row in dt.Rows)
            {
                teams.Add(new Team(Convert.ToInt32(row[0]), row[1].ToString(), Convert.ToInt32(row[2]), Convert.ToDateTime(row[3])));
            }

            for (int i = 0; i < teams.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = teams[i].TeamName;
                item.Tag = teams[i];

                lstTeamInDB.Items.Add(item);
            }
        }

        public void DisplayTeamInTournament()
        {
            TeamsInTournamentDAO teamsDAO = new TeamsInTournamentDAO();
            TeamsInTournament teamsInTournament = teamsDAO.GetAllTeamsInTournament(tournamentID);

            if(teamsInTournament.Teams == null)
            {
                MessageBox.Show("There no team in the tournament, please add !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (Team team in teamsInTournament.Teams)
            {
                ListViewItem item = new ListViewItem();
                item.Text = team.TeamName;
                item.Tag = team;

                lstTeamInTournament.Items.Add(item);
            }


        }

        public void OptimizeDualListView()
        {
            lstTeamInDB.Items.Clear();
            lstTeamInTournament.Items.Clear();
            DisplaySavedTeam();
            DisplayTeamInTournament();

            if(lstTeamInTournament.Items.Count < 0)
            {
                return;
            }

            for(int i = 0; i < lstTeamInDB.Items.Count; i++)
            {
                for(int j = 0; j < lstTeamInTournament.Items.Count; j++)
                {
                    Team team1 = (Team)lstTeamInDB.Items[i].Tag;
                    Team team2 = (Team)lstTeamInTournament.Items[j].Tag;
                    if (team1.TeamName == team2.TeamName)
                    {
                        lstTeamInDB.Items[i].Remove();
                    }
                }
            }
        }


        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstTeamInDB.SelectedItems)
            {
                lstTeamInDB.Items.Remove(item);
                lstTeamInTournament.Items.Add(item);
            }
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstTeamInTournament.SelectedItems)
            {
                lstTeamInTournament.Items.Remove(item);
                lstTeamInDB.Items.Add(item);
            }
        }

        private void btnMoveAllRight_Click(object sender, EventArgs e)
        {
            
            foreach (ListViewItem item in lstTeamInDB.Items)
            {
                lstTeamInTournament.Items.Add((ListViewItem)item.Clone());
            }
            lstTeamInDB.Items.Clear();
        }

        private void btnMoveAllLeft_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstTeamInTournament.Items)
            {
                lstTeamInDB.Items.Add((ListViewItem)item.Clone());
            }
            lstTeamInTournament.Items.Clear();
        }

        


        private void btnStart_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to start tournament ? The teams in tournamentt can't be changed !!!", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            TeamsInTournamentDAO teamsInTournamentDAO = new TeamsInTournamentDAO();
            TeamsInTournament teamsInTournament = teamsInTournamentDAO.GetAllTeamsInTournament(tournamentID);

            Random random = new Random();
            teamsInTournament.Teams = (teamsInTournament.Teams.OrderBy(t => random.Next()).ToList());

            for(int i = 0; i <  teamsInTournament.Teams.Count; i += 2)
            {
                if(i < teamsInTournament.Teams.Count - 1)
                {
                    Match match = new Match(tournamentID, teamsInTournament.Teams[i].TeamID, teamsInTournament.Teams[i+1].TeamID);
                    MatchDAO matchDAO = new MatchDAO();
                    matchDAO.AddMatch(match);
                }
            }

            btnStart.Enabled = false;
            this.Close();
            new TournamentBracket(tournamentID).ShowDialog();
        }

        private void ckbUpdateDetails_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbUpdateDetails.Checked)
            {
                txtName.ReadOnly = false;
                txtLocation.ReadOnly = false;
                dpkEnd.Enabled = true;
                dpkStart.Enabled = true;
                btnUpdateDetails.Enabled = true;

            }
            else
            {
                txtName.ReadOnly = true;
                txtLocation.ReadOnly = true;
                dpkStart.Enabled = false;
                dpkEnd.Enabled = false;
                btnUpdateDetails.Enabled = false;

                DisplayDetails();
            }
        }

        private void ckbUpdatePrize_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbUpdatePrize.Checked)
            {
                txtChampionPrize.ReadOnly = false;
                txtRunnerup.ReadOnly = false;
                txt2ndRunnerup.ReadOnly = false;
                btnUpdatePrize.Enabled = true;
            }
            else
            {
                txtChampionPrize.ReadOnly = true;
                txtRunnerup.ReadOnly = true;
                txt2ndRunnerup.ReadOnly = true;
                btnUpdatePrize.Enabled = false;

                DisplayPrize();
            }
        }

        private void ckbUpdateTeams_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbUpdateTeams.Checked)
            {
                btnMoveAllLeft.Enabled = true;
                btnMoveAllRight.Enabled = true;
                btnMoveLeft.Enabled = true;
                btnMoveRight.Enabled = true;
                btnUpdateTeams.Enabled = true;
            }
            else
            {
                btnMoveAllLeft.Enabled = false;
                btnMoveAllRight.Enabled = false;
                btnMoveLeft.Enabled = false;
                btnMoveRight.Enabled = false;

                btnUpdateTeams.Enabled = false;

                OptimizeDualListView();
            }
        }

        private void txt2ndRunnerup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnUpdateDetails_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please insert all data !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dpkStart.Value > dpkEnd.Value)
            {
                MessageBox.Show("Invalid start date !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure to update details?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            string[] sDate = dpkStart.Text.Split('/');
            DateTime sDateTime = new DateTime(int.Parse(sDate[2]), int.Parse(sDate[1]), int.Parse(sDate[0]));

            string[] eDate = dpkEnd.Text.Split('/');
            DateTime eDateTime = new DateTime(int.Parse(eDate[2]), int.Parse(eDate[1]), int.Parse(eDate[0]));

            Tournament tournament = new Tournament(tournamentID, txtName.Text.Trim(), sDateTime, eDateTime, txtLocation.Text.Trim());

            TournamentDAO tournamentDAO = new TournamentDAO();
            tournamentDAO.UpdateTournament(tournament);

            ckbUpdateDetails.Checked = false;
            MessageBox.Show("Update details successfully !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdatePrize_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtChampionPrize.Text) || string.IsNullOrWhiteSpace(txtRunnerup.Text) || string.IsNullOrWhiteSpace(txt2ndRunnerup.Text))
            {
                MessageBox.Show("Please insert all data !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int a = int.Parse(txtChampionPrize.Text.Trim());
            int b = int.Parse(txtRunnerup.Text.Trim());
            int c = int.Parse(txt2ndRunnerup.Text.Trim());
            if ( a == 0 || b == 0 || c == 0)
            {
                MessageBox.Show("Prize can't be 0 !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Award champion = new Award(tournamentID, "Champion", long.Parse(txtChampionPrize.Text));
            Award runnerup = new Award(tournamentID, "Runner-Up", long.Parse(txtRunnerup.Text));
            Award secondru = new Award(tournamentID, "Second Runner-Up", long.Parse(txt2ndRunnerup.Text));

            AwardDAO awardDAO = new AwardDAO();

            if (awardDAO.GetAllAwardsInTournament(tournamentID).Rows.Count == 0)
            {
                DialogResult result = MessageBox.Show("Are you sure to update prize?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }

                awardDAO.AddAward(champion);
                awardDAO.AddAward(runnerup);
                awardDAO.AddAward(secondru);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure to update prize?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }

                awardDAO.UpdateAward(champion);
                awardDAO.UpdateAward(runnerup);
                awardDAO.UpdateAward(secondru);
            }

            MessageBox.Show("Update prize successfully !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ckbUpdatePrize.Checked = false;
        }

        private void btnUpdateTeams_Click(object sender, EventArgs e)
        {
            if (lstTeamInTournament.Items.Count != 8)
            {
                MessageBox.Show("A tournament must have 8 teams", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure to update teams?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            if (count > 0)
            {
                TeamsInTournamentDAO teamsInTournamentDAO = new TeamsInTournamentDAO();
                teamsInTournamentDAO.DeleteAllTeams(tournamentID);
                for (int i = 0; i < lstTeamInTournament.Items.Count; i++)
                {
                    Team team = (Team)lstTeamInTournament.Items[i].Tag;
                    teamsInTournamentDAO.addTeam(tournamentID, team.TeamID);
                }

                MessageBox.Show("Update teams successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnStart.Enabled = true;

                count = lstTeamInTournament.Items.Count;
            }
            else
            {
                TeamsInTournamentDAO teamsInTournamentDAO = new TeamsInTournamentDAO();
                for (int i = 0; i < lstTeamInTournament.Items.Count; i++)
                {
                    Team team = (Team)lstTeamInTournament.Items[i].Tag;
                    teamsInTournamentDAO.addTeam(tournamentID, team.TeamID);
                }

                MessageBox.Show("Teams added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnStart.Enabled = true;

                count = lstTeamInTournament.Items.Count;
            }

            btnUpdateTeams.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure to delete this tournament ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult == DialogResult.No)
            {
                return;
            }

            TournamentDAO tournamentDAO = new TournamentDAO();
            tournamentDAO.DeleteTournament(tournamentID);

            MessageBox.Show("Tournament deleted !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            screen.InvokeButtonTournamentClick();
            this.Close();
        }

        
    }
}
