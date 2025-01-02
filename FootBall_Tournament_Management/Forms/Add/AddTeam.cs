using DevComponents.DotNetBar;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FootBall_Tournament_Management.Forms
{
    public partial class AddTeam : Form
    {
        private Main_screen screen;

        public AddTeam(Main_screen screen)
        {
            InitializeComponent();
            this.screen = screen;
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(cbbCoachName.Text))
            {
                MessageBox.Show("Please enter all data !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dpkEDate.Value > DateTime.Now)
            {
                MessageBox.Show("Invalid date !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure to add new team ?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            string[] date = dpkEDate.Text.Split('/');
            DateTime dt = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));

            var item = cbbCoachName.SelectedItem as ComboBoxItem;
            Team team = new Team(txtName.Text.Trim(), int.Parse(item.Tag.ToString()), dt);

            TeamDAO teamDAO = new TeamDAO();
            try
            {
                teamDAO.addTeam(team);
                MessageBox.Show("Add new team successfully !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException)
            {
                MessageBox.Show("Coach ID must be defined, please try again !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
                return;
            }

            screen.InvokeButtonTeamClick();
            this.Close();
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

        private void AddTeam_Load(object sender, EventArgs e)
        {
            LoadCoachList();
        }
    }
}
