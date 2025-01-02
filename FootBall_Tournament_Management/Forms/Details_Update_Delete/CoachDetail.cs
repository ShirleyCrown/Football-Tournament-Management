using FootBall_Tournament_Management.DAO;
using FootBall_Tournament_Management.NewFolder1;
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
    public partial class CoachDetail : Form
    {
        private int coachID;
        Main_screen screen;
        public CoachDetail(int coachID, Main_screen screen)
        {
            InitializeComponent();
            this.coachID = coachID;
            this.screen = screen;
            Display();
        }   

        public void Display()
        {
            CoachDAO coachDAO = new CoachDAO();
            Coach coach = coachDAO.GetCoachByID(coachID);

            txtCoachID.Text = coach.CoachID.ToString();
            txtName.Text = coach.CoachName;
            dpkDob.Value = coach.Dob;
            txtPhoneNumber.Text = coach.PhoneNumber;
            txtForte.Text = coach.Forte;
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) 
            {
                e.Handled = true;
            }
        }

        private void ckbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbUpdate.Checked)
            {
                txtName.ReadOnly = false;
                txtPhoneNumber.ReadOnly = false;
                txtForte.ReadOnly = false;
                dpkDob.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else
            {
                txtName.ReadOnly = true;
                txtPhoneNumber.ReadOnly = true;
                txtForte.ReadOnly = true;
                dpkDob.Enabled = false;
                btnUpdate.Enabled = false;

                Display();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPhoneNumber.Text) || string.IsNullOrWhiteSpace(txtForte.Text))
            {
                MessageBox.Show("Please enter all data !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dpkDob.Value > DateTime.Now)
            {
                MessageBox.Show("Invalid DoB !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure to add new coach ?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            string[] date = dpkDob.Text.Split('/');
            DateTime dateTime = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));

            Coach coach = new Coach(int.Parse(txtCoachID.Text), txtName.Text.Trim(), dateTime, txtPhoneNumber.Text.Trim(), txtForte.Text.Trim());

            CoachDAO coachDAO = new CoachDAO();
            coachDAO.UpdateCoach(coach);

            MessageBox.Show("Add new coach successfully !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure to delete this tournament ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.No)
            {
                return;
            }

            CoachDAO coachDAO=new CoachDAO();
            coachDAO.DeleteCoach(coachID);

            MessageBox.Show("Coach deleted !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            screen.InvokeButtonCoachClick();
            this.Close();
        }
    }
}
