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

namespace FootBall_Tournament_Management.Forms.Details_Update_Delete
{
    public partial class PlayerDetail : Form
    {
        private int playerID;
        private Main_screen screen;
        public PlayerDetail(int playerID, Main_screen screen)
        {
            InitializeComponent();
            this.playerID = playerID;
            LoadTeamList();
            Display();
            this.screen = screen;
        }

        public void Display()
        {
            PlayerDAO playerDAO = new PlayerDAO();
            Player player = playerDAO.GetPlayerByID(playerID);

            txtPlayerID.Text = player.PlayerID.ToString();
            cbbTeamName.SelectedIndex = GetItemIndex(player.TeamID);
            txtName.Text = player.PlayerName.ToString();
            cbbPos.Text = player.Position.ToString();
            dpkDob.Value = player.Dob;
            txtPhoneNumber.Text = player.PhoneNumber.ToString();
            nudJerseyNum.Value = player.JerseyNumber;
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

        private int GetItemIndex(int id)
        {
            int index = 0;
            foreach (ComboBoxItem item in cbbTeamName.Items)
            {
                if (int.Parse(item.Tag.ToString()) == id)
                {
                    return index;
                }
                index++;
            }

            return -1;
        }

        private void ckbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbUpdate.Checked)
            {
                cbbTeamName.Enabled = true;
                txtName.ReadOnly = false;
                cbbPos.Enabled = true;
                dpkDob.Enabled = true;
                txtPhoneNumber.ReadOnly = false;
                nudJerseyNum.ReadOnly = false;
                nudJerseyNum.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else
            {
                cbbTeamName.Enabled = false;
                txtName.ReadOnly = true;
                cbbPos.Enabled = false;
                dpkDob.Enabled = false;
                txtPhoneNumber.ReadOnly = true;
                nudJerseyNum.ReadOnly= true;
                nudJerseyNum.Enabled= false;
                btnUpdate.Enabled= false;

                Display();
            }
        }

        private void txtTeamID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(cbbTeamName.Text.Trim()) || string.IsNullOrWhiteSpace(txtPhoneNumber.Text.Trim()) || string.IsNullOrWhiteSpace(cbbPos.Text) || nudJerseyNum.Value == 0)
            {
                MessageBox.Show("Please enter all data !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dpkDob.Value > DateTime.Now)
            {
                MessageBox.Show("Invalid DoB !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure to update data ?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            string[] date = dpkDob.Text.Split('/');
            DateTime dt = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));

            var item = cbbTeamName.SelectedItem as ComboBoxItem;
            Player player = new Player(int.Parse(txtPlayerID.Text), int.Parse(item.Tag.ToString()), txtName.Text.Trim(), cbbPos.Text, dt, txtPhoneNumber.Text.Trim(), (int)nudJerseyNum.Value);

            PlayerDAO playerDAO = new PlayerDAO();
            try
            {
                playerDAO.UpdatePlayer(player);
            }
            catch (MySqlException)
            {
                MessageBox.Show("Team ID not found, please try again !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Data updated !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure to delete this tournament ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.No)
            {
                return;
            }

            PlayerDAO playerDAO = new PlayerDAO();
            playerDAO.DeletePlayer(playerID);

            MessageBox.Show("Player deleted !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            screen.InvokeButtonPlayerClick();
            this.Close();  
        }
    }
}
