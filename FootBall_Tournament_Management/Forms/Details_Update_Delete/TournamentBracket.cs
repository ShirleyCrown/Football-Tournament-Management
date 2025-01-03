﻿using FootBall_Tournament_Management.DAO;
using FootBall_Tournament_Management.NewFolder1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootBall_Tournament_Management.Forms.Details_Update_Delete
{
    public partial class TournamentBracket : Form
    {
        private int tournamentID;
        public TournamentBracket(int tournamentID)
        {
            this.tournamentID = tournamentID;
            InitializeComponent();
            DisplayDetails();
            DisplayPrize();
            DisplayBracketDetails();
            DisplayRule();
        }

        private void DoPaint(int x1, int y1, int x2, int y2, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 2); 

            Point startPoint = new Point(x1 + 201 , y1 + 23);  
            Point endPoint = new Point(x2, y2 + 23);

            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.DrawLine(pen, startPoint, endPoint);

            pen.Dispose();
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

            if (dt.Rows.Count == 0)
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

        public void DisplayBracketDetails()
        {
            MatchDAO matchDAO = new MatchDAO();
            DataTable dt = matchDAO.GetAllMatchesInTournament(tournamentID);

            List<TeamInBracket> controls = new List<TeamInBracket> { uctTeam1, uctTeam2, uctTeam3, uctTeam4, uctTeam5, uctTeam6, uctTeam7, uctTeam8, uctTeam9, uctTeam10, uctTeam11, uctTeam12, uctTeam13, uctTeam14, uctTeam15 };
            List<Match> matches = new List<Match>();

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][6] != DBNull.Value)
                {
                    Match match = new Match(Convert.ToInt32(dt.Rows[i][0]), Convert.ToInt32(dt.Rows[i][1]),
                    Convert.ToInt32(dt.Rows[i][2]), Convert.ToInt32(dt.Rows[i][3]),
                    Convert.ToDateTime(dt.Rows[i][4]), Convert.ToString(dt.Rows[i][5]),
                    Convert.ToInt32(dt.Rows[i][6]), dt.Rows[i][7].ToString());
                    matches.Add(match);
                }
                else
                {
                    Match match = new Match(Convert.ToInt32(dt.Rows[i][0]), Convert.ToInt32(dt.Rows[i][1]),
                    Convert.ToInt32(dt.Rows[i][2]), Convert.ToInt32(dt.Rows[i][3]));
                    matches.Add(match);
                }
            }

            int index = 0;
            for(int i = 0; i < matches.Count; i++)
            {
                TeamDAO teamDAO = new TeamDAO();
                Team team1 = new Team();
                Team team2 = new Team();

                team1 = teamDAO.GetTeamByID(matches[i].Team1ID);
                team2 = teamDAO.GetTeamByID(matches[i].Team2ID);

                controls[index].TeamName = team1.TeamName;

                controls[index + 1].TeamName = team2.TeamName;

                if (matches[i].TeamWin != 0)
                {
                    controls[index].ckbTeamName.Enabled = false;
                    controls[index + 1].ckbTeamName.Enabled = false;

                }

                index += 2;

                if(matches.Count == 7 )
                {
                    Team champion = teamDAO.GetTeamByID(matches[6].TeamWin);
                    uctTeam15.TeamName = champion.TeamName;
                    uctTeam15.Enabled = false;
                }
            }

            SetWinTeam(matches, controls);

        }

        public void SetWinTeam(List<Match> matches, List<TeamInBracket> controls)
        {
            int index = 0;
            for(int i = 0; i < controls.Count; i+=2)
            {
                if (matches[index].TeamWin == 0)
                {
                    index++;
                    if (i == 12 || index == matches.Count)
                    {
                        break;
                    }
                    continue;
                }
                else
                {
                    if (matches[index].TeamWin == matches[index].Team1ID)
                    {
                        controls[i].IsCheck = true;
                        controls[i].BackColor = Color.Tomato;
                    }
                    else
                    {
                        controls[i + 1].IsCheck = true;
                        controls[i + 1].BackColor = Color.Tomato;

                    }
                    index++;
                }

                if(i == 12 || index == matches.Count)
                {
                    break;
                }
            }

            if (matches.Count == 7)
            {
                controls[14].IsCheck = true;
                controls[14].BackColor = Color.Tomato;
            }
        }

        private void DisplayRule()
        {
            rtbRule.Clear();

            RuleDAO ruleDAO = new RuleDAO();
            DataTable dt = ruleDAO.GetAllRulesInTournament(tournamentID);

            if(dt.Rows.Count == 0)
            {
                return;
            }

            List<string> rules = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
                rules.Add(row[2].ToString());
            }

            rtbRule.AppendText("1. " + rules[0]);
            for (int i = 1;i < rules.Count;i++)
            {
                rtbRule.AppendText(Environment.NewLine + (i+1) + ". " + rules[i].ToString());
            }
        }

        private void TournamentBracket_Paint(object sender, PaintEventArgs e)
        {
            DoPaint(uctTeam1.Location.X, uctTeam1.Location.Y, uctTeam9.Location.X, uctTeam9.Location.Y, e);
            DoPaint(uctTeam2.Location.X, uctTeam2.Location.Y, uctTeam9.Location.X, uctTeam9.Location.Y, e);
            DoPaint(uctTeam3.Location.X, uctTeam3.Location.Y, uctTeam10.Location.X, uctTeam10.Location.Y, e);
            DoPaint(uctTeam4.Location.X, uctTeam4.Location.Y, uctTeam10.Location.X, uctTeam10.Location.Y, e);
            DoPaint(uctTeam5.Location.X, uctTeam5.Location.Y, uctTeam11.Location.X, uctTeam11.Location.Y, e);
            DoPaint(uctTeam6.Location.X, uctTeam6.Location.Y, uctTeam11.Location.X, uctTeam11.Location.Y, e);
            DoPaint(uctTeam7.Location.X, uctTeam7.Location.Y, uctTeam12.Location.X, uctTeam12.Location.Y, e);
            DoPaint(uctTeam8.Location.X, uctTeam8.Location.Y, uctTeam12.Location.X, uctTeam12.Location.Y, e);
            DoPaint(uctTeam9.Location.X, uctTeam9.Location.Y, uctTeam13.Location.X, uctTeam13.Location.Y, e);
            DoPaint(uctTeam10.Location.X, uctTeam10.Location.Y, uctTeam13.Location.X, uctTeam13.Location.Y, e);
            DoPaint(uctTeam11.Location.X, uctTeam11.Location.Y, uctTeam14.Location.X, uctTeam14.Location.Y, e);
            DoPaint(uctTeam12.Location.X, uctTeam12.Location.Y, uctTeam14.Location.X, uctTeam14.Location.Y, e);
            DoPaint(uctTeam13.Location.X, uctTeam13.Location.Y, uctTeam15.Location.X, uctTeam15.Location.Y, e);
            DoPaint(uctTeam14.Location.X, uctTeam14.Location.Y, uctTeam15.Location.X, uctTeam15.Location.Y, e);

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

        private void ckbUpdateRule_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbUpdateRule.Checked)
            {
                rtbRule.ReadOnly = false;
                btnUpdateRule.Enabled = true;
            }
            else
            {
                rtbRule.ReadOnly = true;
                btnUpdateRule.Enabled = false;

                DisplayRule();
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
            if (a == 0 || b == 0 || c == 0)
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

        private void btnUpdateRule_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to update rule?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            RuleDAO ruleDAO = new RuleDAO();
            ruleDAO.DeleteRuleInTournament(tournamentID);

            string[] lines = rtbRule.Lines;

            for (int i = 0; i < lines.Length; i++)
            {
                ruleDAO.AddRule(new Rules(tournamentID, lines[i].Remove(0, 3)));
            }

            MessageBox.Show("Update rule successfully !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtChampionPrize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
    }
}
