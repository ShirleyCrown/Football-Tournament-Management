using FootBall_Tournament_Management.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FootBall_Tournament_Management.Forms
{
    public partial class Main_screen : Form
    {
        private string type;
        private readonly string user;

        #region Handle for main_screen
        public Main_screen(string user)
        {
            InitializeComponent();
            this.user = user;
            type = "tournament";
        }

        private void Main_screen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Main_screen_Load(object sender, EventArgs e)
        {
            title.Left = (this.ClientSize.Width - title.Width) / 2;
            title.Top = (heading.ClientSize.Height - title.Height) / 2;
            btnAdd.Left = pnlComponent.ClientSize.Width - (btnAdd.Width + 90);
            txtSearch.Left = pnlComponent.ClientSize.Width - (btnAdd.Width + 90 + txtSearch.Width + 30);
            TournamentDAO tournamentDAO = new TournamentDAO();
            DataTable dt = tournamentDAO.GetAllTournaments();

            int n = dt.Rows.Count;

            Component[] components = new Component[n];

            btnTournament.PerformClick();
        }

        private void Main_screen_SizeChanged(object sender, EventArgs e)
        {
            title.Left = (this.ClientSize.Width - title.Width) / 2;
            title.Top = (heading.ClientSize.Height - title.Height) / 2;
            btnAdd.Left = pnlComponent.ClientSize.Width - (btnAdd.Width + 20);
        }
        #endregion

        #region Handle for tournament button
        private void btnTournament_MouseEnter(object sender, EventArgs e)
        {
            btnTournament.BackColor = Color.White;
            btnTournament.ForeColor = Color.DodgerBlue;
            logo.Image = Properties.Resources.soccer_tournament;
            logo.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnTournament_Click(object sender, EventArgs e)
        {
            type = "tournament";
            componentList.Controls.Clear();

            TournamentDAO tournamentDAO = new TournamentDAO();
            DataTable dt = tournamentDAO.GetAllTournaments();

            int n = dt.Rows.Count;

            Component[] components = new Component[n];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                components[i] = new Component("tournament", Convert.ToInt32(dt.Rows[i][0]));
                components[i].Name = dt.Rows[i][1].ToString();

                componentList.Controls.Add(components[i]);
            }
        }

        private void btnTournament_MouseLeave(object sender, EventArgs e)
        {
            btnTournament.BackColor = Color.DodgerBlue;
            btnTournament.ForeColor = Color.White;
        }
        #endregion

        #region Handle for team button
        private void btnTeam_MouseLeave(object sender, EventArgs e)
        {
            btnTeam.BackColor = Color.DodgerBlue;
            btnTeam.ForeColor = Color.White;
        }

        private void btnTeam_MouseEnter(object sender, EventArgs e)
        {
            btnTeam.BackColor = Color.White;
            btnTeam.ForeColor = Color.DodgerBlue;
            logo.Image = Properties.Resources.soccer_team;
            logo.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnTeam_Click(object sender, EventArgs e)
        {
            type = "team";
            componentList.Controls.Clear();

            TeamDAO teamDAO = new TeamDAO();
            DataTable dt = teamDAO.GetAllTeams();

            int n = dt.Rows.Count;

            Component[] components = new Component[n];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                components[i] = new Component("team", Convert.ToInt32(dt.Rows[i][0]));
                components[i].Name = dt.Rows[i][1].ToString();

                componentList.Controls.Add(components[i]);
            }
        }
        #endregion

        #region Handle for player button
        private void btnPlayer_MouseLeave(object sender, EventArgs e)
        {
            btnPlayer.BackColor = Color.DodgerBlue;
            btnPlayer.ForeColor = Color.White;
        }

        private void btnPlayer_MouseEnter(object sender, EventArgs e)
        {
            btnPlayer.BackColor = Color.White;
            btnPlayer.ForeColor = Color.DodgerBlue;
            logo.Image = Properties.Resources.soccer_player;
            logo.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnPlayer_Click(object sender, EventArgs e)
        {
            type = "player";

            componentList.Controls.Clear();

            PlayerDAO playerDAO = new PlayerDAO();
            DataTable dt = playerDAO.GetAllPlayers();

            int n = dt.Rows.Count;

            Component[] components = new Component[n];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                components[i] = new Component("player", Convert.ToInt32(dt.Rows[i][0]));
                components[i].Name = dt.Rows[i][2].ToString();

                componentList.Controls.Add(components[i]);
            }
        }
        #endregion

        #region Handle for coach button
        private void btnCoach_MouseLeave(object sender, EventArgs e)
        {
            btnCoach.BackColor = Color.DodgerBlue;
            btnCoach.ForeColor = Color.White;
        }

        private void btnCoach_MouseEnter(object sender, EventArgs e)
        {
            btnCoach.BackColor = Color.White;
            btnCoach.ForeColor = Color.DodgerBlue;
            logo.Image = Properties.Resources.soccer_coach;
            logo.SizeMode = PictureBoxSizeMode.Zoom;
        }


        private void btnCoach_Click(object sender, EventArgs e)
        {
            type = "coach";
            componentList.Controls.Clear();

            CoachDAO coachDAO = new CoachDAO();
            DataTable dt = coachDAO.GetAllCoaches();

            int n = dt.Rows.Count;

            Component[] components = new Component[n];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                components[i] = new Component("coach", Convert.ToInt32(dt.Rows[i][0]));
                components[i].Name = dt.Rows[i][1].ToString();

                componentList.Controls.Add(components[i]);
            }
        }


        #endregion

        #region Handle for add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(type == "tournament")
            {
                AddTournament addTournament = new AddTournament(user);
                addTournament.ShowDialog(); 
            } 
            else if(type == "team")
            {
                AddTeam addTeam = new AddTeam();
                addTeam.ShowDialog();
            } 
            else if(type == "player")
            {
                AddPlayer addPlayer = new AddPlayer();
                addPlayer.ShowDialog();
            }
            else
            {
                AddCoach addCoach = new AddCoach();
                addCoach.ShowDialog();
            }
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.White;
            btnAdd.ForeColor = Color.DodgerBlue;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.DodgerBlue ;
            btnAdd.ForeColor = Color.White;
        }


        #endregion

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt;
            int n;
            Component[] components;
            switch (type)
            {
                case "tournament":
                    componentList.Controls.Clear();

                    TournamentDAO tournamentDAO = new TournamentDAO();
                    dt = tournamentDAO.GetTournamentsByNameLike(txtSearch.Text);

                    n = dt.Rows.Count;

                    components = new Component[n];

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        components[i] = new Component("tournament", Convert.ToInt32(dt.Rows[i][0]));
                        components[i].Name = dt.Rows[i][1].ToString();

                        componentList.Controls.Add(components[i]);
                    }
                    break;
                case "team":
                    componentList.Controls.Clear();

                    TeamDAO teamDAO = new TeamDAO();
                    dt = teamDAO.GetTeamsByNameLike(txtSearch.Text);

                    n = dt.Rows.Count;

                    components = new Component[n];

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        components[i] = new Component("team", Convert.ToInt32(dt.Rows[i][0]));
                        components[i].Name = dt.Rows[i][1].ToString();

                        componentList.Controls.Add(components[i]);
                    }
                    break ;
                case "player":
                    componentList.Controls.Clear();

                    PlayerDAO playerDAO = new PlayerDAO();
                    dt = playerDAO.GetPlayersByNameLike(txtSearch.Text);

                    n = dt.Rows.Count;

                    components = new Component[n];

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        components[i] = new Component("team", Convert.ToInt32(dt.Rows[i][0]));
                        components[i].Name = dt.Rows[i][2].ToString();

                        componentList.Controls.Add(components[i]);
                    }
                    break;
                case "coach":
                    componentList.Controls.Clear();

                    CoachDAO coachDAO = new CoachDAO();
                    dt = coachDAO.GetCoachsByNameLike(txtSearch.Text);

                    n = dt.Rows.Count;

                    components = new Component[n];

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        components[i] = new Component("team", Convert.ToInt32(dt.Rows[i][0]));
                        components[i].Name = dt.Rows[i][1].ToString();

                        componentList.Controls.Add(components[i]);
                    }
                    break ; 
            }
        }

        
    }
}
