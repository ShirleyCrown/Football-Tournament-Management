using FootBall_Tournament_Management.DAO;
using FootBall_Tournament_Management.NewFolder1;
using Org.BouncyCastle.Crypto.Macs;
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

namespace FootBall_Tournament_Management.Forms.Details_Update_Delete
{
    public partial class MatchDetails : Form
    {
        private int matchID;
        private int team1ID;
        private int team2ID;

        public MatchDetails(int matchID)
        {
            InitializeComponent();
            this.matchID = matchID;
            DisplayScore();
            DisplayInfo();
        }

        
        private void DisplayScore()
        {
            MatchDAO matchDAO = new MatchDAO();
            string result = matchDAO.GetScoreByID(matchID);
            Match match = matchDAO.GetMatchByID(matchID);

            if(!string.IsNullOrEmpty(result))
            {
                string[] _score = result.ToString().Split('-');

                score1.Value = int.Parse(_score[0]);
                score2.Value = int.Parse(_score[1]);
            }
            else
            {
                score1.Value = -1;
                score2.Value = -1;
            }
            
            TeamDAO teamDAO = new TeamDAO();
            Team team1 = teamDAO.GetTeamByID(match.Team1ID);
            Team team2 = teamDAO.GetTeamByID(match.Team2ID);

            if (!string.IsNullOrEmpty(team1.AvatarPath))
            {
                string fullPath = GetFullImagePath(team1.AvatarPath);
                if (File.Exists(fullPath))
                {
                    avatar1.Image = new Bitmap(fullPath);
                }
            }

            if (!string.IsNullOrEmpty(team2.AvatarPath))
            {
                string fullPath = GetFullImagePath(team2.AvatarPath);
                if (File.Exists(fullPath))
                {
                    avatar2.Image = new Bitmap(fullPath);
                }
            }
            
            this.team1ID = match.Team1ID;
            this.team2ID = match.Team2ID;

            lblTeam1.Text = team1.TeamName;
            lblTeam2.Text = team2.TeamName;

            NewPos(avatar1, lblTeam1 );
            NewPos(avatar2, lblTeam2 );
        }

        private void DisplayInfo()
        {
            Match match = new MatchDAO().GetMatchByID(matchID);

            if (match.MatchDate != null)
            {
                dpkDate.Value = match.MatchDate;
            }

            if (!string.IsNullOrEmpty(match.Location))
            {
                txtLocation.Text = match.Location;
            }
        }

        private void NewPos(PictureBox pictureBox, Label label)
        {
            int centerX = pictureBox.Left + (pictureBox.Width - label.Width) / 2;
            int positionY = pictureBox.Bottom + 5; 

            label.Location = new Point(centerX, positionY);
        }

        private string GetFullImagePath(string relativePath)
        {
            string rootFolder = AppDomain.CurrentDomain.BaseDirectory;
            return Path.Combine(rootFolder, relativePath);
        }

        private void ckbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbScore.Checked)
            {
                score1.Enabled = true;
                score2.Enabled = true;
                btnUpdateScore.Enabled = true;
            }
            else
            {
                score1.Enabled = false; 
                score2.Enabled = false;
                btnUpdateScore.Enabled = false;

                DisplayScore();
            }
        }

        private void ckbInfo_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbInfo.Checked)
            {
                dpkDate.Enabled = true;
                txtLocation.ReadOnly = false;
                btnUpdateInfo.Enabled = true;
            }
            else
            {
                dpkDate.Enabled = false;
                txtLocation.ReadOnly = true;
                btnUpdateInfo.Enabled = false;

                DisplayInfo();
            }
        }

        private void btnUpdateScore_Click(object sender, EventArgs e)
        {
            if(score1.Value == -1 || score2.Value == -1)
            {
                MessageBox.Show("Score must be from 0 !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure to update score ?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            string res = score1.Value + "-" + score2.Value;

            new MatchDAO().UpdateMatchResult(matchID, res);
            MessageBox.Show("Update successfully !!!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please insert location !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }   

            new MatchDAO().UpdateMatchInfo(matchID, dpkDate.Value, txtLocation.Text.Trim());
            MessageBox.Show("Update successfully !!!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
