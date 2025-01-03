using FootBall_Tournament_Management.DAO;
using FootBall_Tournament_Management.Forms;
using FootBall_Tournament_Management.Forms.Details_Update_Delete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootBall_Tournament_Management
{
    public partial class Component : UserControl
    {
        private string component;
        private int componentID;
        private Main_screen screen;
        private string avatarPath;
        public Component(string component, int componentID, Main_screen screen, string avatarPath)
        {
            InitializeComponent();

            this.component = component;
            this.componentID = componentID;
            this.screen = screen;
            this.avatarPath = avatarPath;

            if (component == "tournament")
            {
                avatar.Image = Properties.Resources.soccer_tournament;
                avatar.SizeMode = PictureBoxSizeMode.Zoom;
            } 
            else if(component == "team")
            {
                avatar.Image = Properties.Resources.soccer_team;
                avatar.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (component == "player")
            {
                avatar.Image = Properties.Resources.soccer_player;
                avatar.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                avatar.Image = Properties.Resources.soccer_coach;
                avatar.SizeMode = PictureBoxSizeMode.Zoom;
            }

            this.MouseEnter += Component_MouseHover;
            this.MouseLeave += Component_MouseLeave;
            avatar.MouseEnter += Component_MouseHover;
            avatar.MouseLeave += Component_MouseLeave;
            avatar.Click += Component_Click;
            name.MouseEnter += Component_MouseHover;
            name.MouseLeave += Component_MouseLeave;
            name.Click += Component_Click;
        }

        public string Name
        {
            get { return name.Text; }
            set { name.Text = value; }
        }

        public Image Avatar
        {
            get { return avatar.Image; }
            set { avatar.Image = value; }
        }

        private string GetFullImagePath(string relativePath)
        {
            string rootFolder = AppDomain.CurrentDomain.BaseDirectory; 
            return Path.Combine(rootFolder, relativePath); 
        }

        private void Component_Load(object sender, EventArgs e)
        {
            name.Left = (this.ClientSize.Width - name.Width) / 2;

            if (string.IsNullOrEmpty(avatarPath))
            {
                return;
            }

            string fullPath = GetFullImagePath(avatarPath);

            if (File.Exists(fullPath))
            {
                avatar.Image = new Bitmap(fullPath);
            }
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int borderRadius = 20;
            Graphics g = e.Graphics;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(this.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(this.Width - borderRadius, this.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, this.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);

                
            }
        }

        

        private void Component_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.DodgerBlue;

           
        }

        private void Component_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor= Color.DodgerBlue;
            this.ForeColor= Color.White;

        }

        private void avatar_SizeChanged(object sender, EventArgs e)
        {
            int borderRadius = 20;
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(avatar.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(avatar.Width - borderRadius, avatar.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, avatar.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                path.CloseFigure();

                avatar.Region = new Region(path);


            }
        }

        private void Component_Click(object sender, EventArgs e)
        {
            if (component == "tournament")
            {
                MatchDAO matchDAO = new MatchDAO();
                if(matchDAO.GetAllMatchesInTournament(componentID).Rows.Count > 0)
                {
                    new TournamentBracket(componentID).ShowDialog();
                    
                }
                else
                {
                    new TournamentDetail(componentID, screen).ShowDialog();
                }
            }
            else if (component == "team")
            {
                new TeamDetail(componentID, screen).ShowDialog();
            }
            else if (component == "player")
            {
                new PlayerDetail(componentID, screen).ShowDialog();
            }
            else
            {
                new CoachDetail(componentID, screen).ShowDialog();
            }
        }
    }
}
