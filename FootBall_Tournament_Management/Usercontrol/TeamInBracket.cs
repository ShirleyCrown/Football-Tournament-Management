using FootBall_Tournament_Management.Forms.Details_Update_Delete;
using FootBall_Tournament_Management.Object;
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

namespace FootBall_Tournament_Management
{
    public partial class TeamInBracket : UserControl
    {
        private int teamID;
        private int matchID;
        public TeamInBracket(int teamID, string teamName, int matchID)
        {
            InitializeComponent();
            this.TeamID = teamID;
            this.MatchID = matchID;
        }

        public TeamInBracket()
        {
            InitializeComponent ();
        }

        public string TeamName
        {
            get { return ckbTeamName.Text; }
            set { ckbTeamName.Text = value; }
        }

        public bool IsCheck
        {
            get { return ckbTeamName.Checked; }
            set { ckbTeamName.Checked = value; }
        }

        public bool IsEnabled
        {
            get { return ckbTeamName.Enabled;}
            set { ckbTeamName.Enabled = value;}
        }

        public int TeamID { get => teamID; set => teamID = value; }
        public int MatchID { get => matchID; set => matchID = value; }

        private void TeamInBracket_Load(object sender, EventArgs e)
        {
            ckbTeamName.Left = (this.ClientSize.Width - ckbTeamName.Width) / 2;
            ckbTeamName.Top = (this.ClientSize.Height - ckbTeamName.Height) / 2;

            this.MouseDown += (s, ev) =>
            {
                if (ev.Button == MouseButtons.Right) 
                {
                    detail.Show(this, ev.Location); 
                }
            };

            ckbTeamName.MouseDown += (s, ev) =>
            {
                if (ev.Button == MouseButtons.Right)
                {
                    detail.Show(ckbTeamName, ev.Location);
                }
            };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int borderRadius = 20;
            Graphics g = e.Graphics;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(this.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(this.Width - borderRadius, this.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, this.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);

                using (Pen pen = new Pen(Color.Black, 2)) 
                {
                    g.DrawPath(pen, path);
                }
            }

            
        }

        private void showDetail_Click(object sender, EventArgs e)
        {
            if (matchID == 0) return;
            new MatchDetails(matchID).ShowDialog();   
        }

        
    }
}
