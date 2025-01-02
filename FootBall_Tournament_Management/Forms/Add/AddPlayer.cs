using DevComponents.DotNetBar;
using FootBall_Tournament_Management.DAO;
using FootBall_Tournament_Management.NewFolder1;
using Google.Protobuf.WellKnownTypes;
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
    public partial class AddPlayer : Form
    {
        Main_screen screen;

        string[] list;
        public AddPlayer(Main_screen screen)
        {
            InitializeComponent();
            list = new string[cbbPos.Items.Count];
            this.screen = screen;
            
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(cbbTeamName.Text) || string.IsNullOrWhiteSpace(txtPhoneNumber.Text) || string.IsNullOrWhiteSpace(cbbPos.Text) || nudJerseyNum.Value == 0) 
            {
                MessageBox.Show("Please enter all data !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dpkDob.Value > DateTime.Now)
            {
                MessageBox.Show("Invalid DoB !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure to add new player ?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            string[] date = dpkDob.Text.Split('/');
            DateTime dt = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));

            var item = cbbTeamName.SelectedItem as ComboBoxItem;
            Player player = new Player(int.Parse(item.Tag.ToString()), txtName.Text.Trim(), cbbPos.Text, dt, txtPhoneNumber.Text.Trim(), (int) nudJerseyNum.Value);

            PlayerDAO playerDAO = new PlayerDAO();
            try
            {
                playerDAO.AddPlayer(player);
                MessageBox.Show("Add new player successfully !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException)
            {
                MessageBox.Show("Team ID not found, please try again !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return;
            }

            screen.InvokeButtonPlayerClick();
            this.Close();
        }

        private void txtTeamID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void LoadTeamList()
        {
            cbbTeamName.DataSource = null;
            cbbTeamName.Items.Clear();    

            TeamDAO teamDAO = new TeamDAO();
            DataTable dt = teamDAO.GetAllTeams();

            List<ComboBoxItem> items = dt.AsEnumerable()
                .Select(row => new ComboBoxItem
                {
                    Tag = row[0].ToString(),
                    Text = teamDAO.GetNameByID(int.Parse(row[0].ToString())).Trim()
                })
                .ToList();

            cbbTeamName.DisplayMember = "Text"; 
            cbbTeamName.ValueMember = "Tag";   
            cbbTeamName.DataSource = items;    
        }


        private void AddPlayer_Load(object sender, EventArgs e)
        {
            LoadTeamList();
        }
    }
}
