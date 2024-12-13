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

namespace FootBall_Tournament_Management.Forms
{
    public partial class AddCoach : Form
    {
        public AddCoach()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPhoneNumber.Text) || string.IsNullOrWhiteSpace(txtForte.Text)){
                MessageBox.Show("Please enter all data !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);    
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure to add new coach ?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            string[] date = dpkDob.Text.Split('/');
            DateTime dateTime = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));

            Coach coach = new Coach(txtName.Text, dateTime, txtPhoneNumber.Text, txtForte.Text);

            CoachDAO coachDAO = new CoachDAO();
            coachDAO.AddCoach(coach);

            MessageBox.Show("Add new coach successfully !!!","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
