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
        string[] list;
        public AddPlayer()
        {
            InitializeComponent();
            list = new string[cbbPos.Items.Count];
        }

        private void AddPlayer_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtTeamID.Text) || string.IsNullOrWhiteSpace(txtPhoneNumber.Text) || string.IsNullOrWhiteSpace(cbbPos.Text) || nudJerseyNum.Value == 0) 
            {
                MessageBox.Show("Please enter all data !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure to add new coach ?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            string[] date = dpkDob.Text.Split('/');
            DateTime dt = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));

            Player player = new Player(int.Parse(txtTeamID.Text), txtName.Text, cbbPos.Text, dt, txtPhoneNumber.Text, (int) nudJerseyNum.Value);

            PlayerDAO playerDAO = new PlayerDAO();
            try
            {
                playerDAO.AddPlayer(player);
            }
            catch (MySqlException)
            {
                MessageBox.Show("Team ID not found, please try again !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTeamID.Clear();
                return;
            }

            txtTeamID.Clear();
            txtName.Clear();
            txtPhoneNumber.Clear();
            cbbPos.Text = string.Empty;
            dpkDob.Value = DateTime.Now;
            nudJerseyNum.Value = 0;
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
    }
}
