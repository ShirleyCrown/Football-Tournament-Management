using FootBall_Tournament_Management.DAO;
using FootBall_Tournament_Management.NewFolder1;
using FootBall_Tournament_Management.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public TournamentDetail(int tournamentID)
        {
            InitializeComponent();
            this.tournamentID = tournamentID;
            Display();
            OptimizeDualListView();
            count = lstTeamInTournament.Items.Count;

            if (lstTeamInTournament.Items.Count > 0) {
                btnMoveAllLeft.Enabled = false;
                btnMoveAllRight.Enabled = false;
                btnMoveLeft.Enabled = false;
                btnMoveRight.Enabled = false;
            }
        }

        public void Display()
        {
            TournamentDAO tournamentDAO = new TournamentDAO();
            Tournament tournament = tournamentDAO.GetTournamentByID(tournamentID);

            txtID.Text = tournament.TournamentID.ToString();
            txtName.Text = tournament.TournamentName;
            dpkStart.Value = tournament.StartDate;
            dpkEnd.Value = tournament.EndDate;
            txtLocation.Text = tournament.Location;
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

        private void ckbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbUpdate.Checked)
            {
                txtName.ReadOnly = false;
                txtLocation.ReadOnly = false;
                dpkEnd.Enabled = true;
                dpkStart.Enabled = true;
                btnUpdate.Enabled = true;

                btnMoveAllLeft.Enabled = true;
                btnMoveAllRight.Enabled = true;
                btnMoveLeft.Enabled = true;
                btnMoveRight.Enabled = true;
            }
            else
            {
                txtName.ReadOnly = true;
                txtLocation.ReadOnly = true;
                dpkStart.Enabled = false;
                dpkEnd.Enabled = false;
                btnUpdate.Enabled = false;

                btnMoveAllLeft.Enabled = false;
                btnMoveAllRight.Enabled = false;
                btnMoveLeft.Enabled = false;
                btnMoveRight.Enabled = false;
                Display();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(lstTeamInTournament.Items.Count != 8)
            {
                MessageBox.Show("A tournament must have 8 teams", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure to update these teams to tournament ?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }

                TeamsInTournamentDAO teamsInTournamentDAO = new TeamsInTournamentDAO();
                for (int i = 0; i < lstTeamInTournament.Items.Count; i++)
                {
                    Team team = (Team)lstTeamInTournament.Items[i].Tag;
                    teamsInTournamentDAO.ChangeTeam(tournamentID, team.TeamID);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure to add these teams to tournament ?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                TeamsInTournamentDAO teamsInTournamentDAO = new TeamsInTournamentDAO();
                for (int i = 0; i < lstTeamInTournament.Items.Count; i++)
                {
                    Team team = (Team)lstTeamInTournament.Items[i].Tag;
                    teamsInTournamentDAO.addTeam(tournamentID, team.TeamID);
                }

                MessageBox.Show("Teams added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
