using FootBall_Tournament_Management.DAO;
using FootBall_Tournament_Management.NewFolder1;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootBall_Tournament_Management.Forms.Details_Update_Delete
{
    public partial class TeamDetail : Form
    {
        private int teamID;
        public TeamDetail(int teamID)
        {
            InitializeComponent();
            this.teamID = teamID;
            Display();
        }

        public void Display()
        {
            TeamDAO teamDAO = new TeamDAO();
            Team team = teamDAO.GetTeamByID(teamID);

            txtTeamID.Text = team.TeamID.ToString();
            txtName.Text = team.TeamName;
            txtCoachID.Text = team.CoachID.ToString();
            dpkEDate.Value = team.EstablishedDate;
        }

        private void ckb_CheckedChanged(object sender, EventArgs e)
        {
            if(ckb.Checked)
            {
                txtName.ReadOnly = false;
                txtCoachID.ReadOnly = false;
                dpkEDate.Enabled = true;
                btnUpdate.Enabled = true;   
            }
            else
            {
                txtName.ReadOnly = true;
                txtCoachID.ReadOnly = true;
                dpkEDate.Enabled = false;
                btnUpdate.Enabled = false;

                Display();
            }
        }

        private void txtCoachID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtCoachID.Text))
            {
                MessageBox.Show("Please enter all data !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure to update information ?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            string[] date = dpkEDate.Text.Split('/');
            DateTime dt = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));

            Team team = new Team(int.Parse(txtTeamID.Text), txtName.Text, int.Parse(txtCoachID.Text), dt);

            TeamDAO teamDAO = new TeamDAO();
            try
            {
                teamDAO.UpdateTeam(team);
            }
            catch (MySqlException)
            {
                MessageBox.Show("Coach ID must be defined, please try again !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCoachID.Clear();
                return;
            }

            MessageBox.Show("Data updated !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
