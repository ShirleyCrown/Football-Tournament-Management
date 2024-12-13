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
        public PlayerDetail(int playerID)
        {
            InitializeComponent();
            this.playerID = playerID;
            Display();
        }

        public void Display()
        {
            PlayerDAO playerDAO = new PlayerDAO();
            Player player = playerDAO.GetPlayerByID(playerID);

            txtPlayerID.Text = player.PlayerID.ToString();
            txtTeamID.Text = player.TeamID.ToString();
            txtName.Text = player.PlayerName.ToString();
            cbbPos.Text = player.Position.ToString();
            dpkDob.Value = player.Dob;
            txtPhoneNumber.Text = player.PhoneNumber.ToString();
            nudJerseyNum.Value = player.JerseyNumber;
        }

        private void ckbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbUpdate.Checked)
            {
                txtTeamID.ReadOnly = false;
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
                txtTeamID.ReadOnly = true;
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
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtTeamID.Text) || string.IsNullOrWhiteSpace(txtPhoneNumber.Text) || string.IsNullOrWhiteSpace(cbbPos.Text) || nudJerseyNum.Value == 0)
            {
                MessageBox.Show("Please enter all data !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure to update data ?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            string[] date = dpkDob.Text.Split('/');
            DateTime dt = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));

            Player player = new Player(int.Parse(txtPlayerID.Text), int.Parse(txtTeamID.Text), txtName.Text, cbbPos.Text, dt, txtPhoneNumber.Text, (int)nudJerseyNum.Value);

            PlayerDAO playerDAO = new PlayerDAO();
            try
            {
                playerDAO.UpdatePlayer(player);
            }
            catch (MySqlException)
            {
                MessageBox.Show("Team ID not found, please try again !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTeamID.Clear();
                return;
            }

            MessageBox.Show("Data updated !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
