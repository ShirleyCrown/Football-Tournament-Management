﻿using DevComponents.DotNetBar;
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
        private Main_screen screen;

        public TeamDetail(int teamID, Main_screen screen)
        {
            InitializeComponent();
            this.teamID = teamID;
            LoadCoachList();
            Display();
            this.screen = screen;
        }

        private void Display()
        {
            TeamDAO teamDAO = new TeamDAO();
            Team team = teamDAO.GetTeamByID(teamID);

            txtTeamID.Text = team.TeamID.ToString();
            txtName.Text = team.TeamName;

            cbbCoachName.SelectedIndex = GetItemIndex(team.CoachID);
            dpkEDate.Value = team.EstablishedDate;

            DisplayMembers();
        }

        private int GetItemIndex(int id)
        {
            int index = 0;
            foreach (ComboBoxItem item in cbbCoachName.Items)
            {
                if (int.Parse(item.Tag.ToString()) == id)
                {
                    return index; 
                }
                index++; 
            }

            return -1; 
        }


        private void LoadCoachList()
        {
            cbbCoachName.DataSource = null;
            cbbCoachName.Items.Clear();

            CoachDAO coachDAO = new CoachDAO();
            DataTable dt = coachDAO.GetAllCoaches();

            List<ComboBoxItem> items = dt.AsEnumerable()
                .Select(row => new ComboBoxItem
                {
                    Tag = row[0].ToString(),
                    Text = coachDAO.GetNameByID(int.Parse(row[0].ToString())).Trim()
                })
                .ToList();

            cbbCoachName.DisplayMember = "Text";
            cbbCoachName.ValueMember = "Tag";
            cbbCoachName.DataSource = items;
        }

        private void ckb_CheckedChanged(object sender, EventArgs e)
        {
            if(ckb.Checked)
            {
                txtName.ReadOnly = false;
                cbbCoachName.Enabled = true;
                dpkEDate.Enabled = true;
                btnUpdate.Enabled = true;   
            }
            else
            {
                txtName.ReadOnly = true;
                cbbCoachName.Enabled = false;
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
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(cbbCoachName.Text))
            {
                MessageBox.Show("Please enter all data !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dpkEDate.Value > DateTime.Now)
            {
                MessageBox.Show("Invalid Establish Date !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure to update information ?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            string[] date = dpkEDate.Text.Split('/');
            DateTime dt = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));

            var item = cbbCoachName.SelectedItem as ComboBoxItem;
            Team team = new Team(int.Parse(txtTeamID.Text), txtName.Text.Trim(), int.Parse(item.Tag.ToString()), dt);

            TeamDAO teamDAO = new TeamDAO();
            try
            {
                teamDAO.UpdateTeam(team);
            }
            catch (MySqlException)
            {
                MessageBox.Show("Coach ID must be defined, please try again !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Data updated !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure to delete this team ? All player in the team will be also deleted !", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.No)
            {
                return;
            }

            TeamDAO teamDAO= new TeamDAO();
            teamDAO.DeleteTeam(teamID);

            PlayerDAO playerDAO= new PlayerDAO();
            playerDAO.DeletePlayerByTeamID(teamID);

            MessageBox.Show("Team deleted !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            screen.InvokeButtonTeamClick();
            this.Close();
        }

        public void DisplayMembers()
        {
            TeamDAO teamDAO= new TeamDAO();
            DataTable dt = teamDAO.GetTeamMembers(teamID);
            dt.Columns.RemoveAt(7);

            //dt.Columns["Column1"].ColumnName = "ID";
            //dt.Columns["Column3"].ColumnName = "Name";
            //dt.Columns["Column4"].ColumnName = "Position";
            //dt.Columns["Column5"].ColumnName = "Birth Date";
            //dt.Columns["Column6"].ColumnName = "Phone Number";
            //dt.Columns["Column7"].ColumnName = "Jersey Number";

            dgvMemebers.DataSource = dt;

            int width = dgvMemebers.Width / dgvMemebers.Columns.Count;

            for(int i = 0; i < dgvMemebers.Columns.Count; i++)
            {
                dgvMemebers.Columns[i].Width = width;
            }
        }

        
    }
}
