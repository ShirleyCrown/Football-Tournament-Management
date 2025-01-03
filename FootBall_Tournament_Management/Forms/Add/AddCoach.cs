using DevComponents.DotNetBar;
using DevComponents.Editors;
using FootBall_Tournament_Management.DAO;
using FootBall_Tournament_Management.NewFolder1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootBall_Tournament_Management.Forms
{
    public partial class AddCoach : Form
    {
        Main_screen screen;
        private string selectedImagePath;

        public AddCoach(Main_screen screen)
        {
            InitializeComponent();

            this.screen = screen;
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPhoneNumber.Text) || string.IsNullOrWhiteSpace(txtForte.Text)){
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

            
            if (avatar.Image == null)
            {
                Coach coach = new Coach(txtName.Text.Trim(), dateTime, txtPhoneNumber.Text.Trim(), txtForte.Text.Trim(), "");
                CoachDAO coachDAO = new CoachDAO();
                coachDAO.AddCoach(coach);
            }
            else
            {
                Coach coach = new Coach(txtName.Text.Trim(), dateTime, txtPhoneNumber.Text.Trim(), txtForte.Text.Trim(), GetRelativePath(txtName.Text.Trim()));
                CoachDAO coachDAO = new CoachDAO();
                coachDAO.AddCoach(coach);
            }
           

            MessageBox.Show("Add new coach successfully !!!","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            screen.InvokeButtonCoachClick();
            this.Close();
        }

        private string GetRelativePath(string name)
        {
            string rootFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Avatars");
            string targetFolder = Path.Combine(rootFolder, "Coachs");

            int i = 1;
            const int maxRetries = 100; 
            string newFileName = "";
            string fileExtension = Path.GetExtension(selectedImagePath);
            bool success = false;

            while (i <= maxRetries)
            {
                try
                {
                    newFileName = i == 1 ? $"{name}{fileExtension}" : $"{name}{i}{fileExtension}";
                    string savedImagePath = Path.Combine(targetFolder, newFileName);

                    if (!File.Exists(savedImagePath))
                    {
                        File.Copy(selectedImagePath, savedImagePath);
                        success = true;
                        break;
                    }

                    i++;
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"File is being used by another process: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    i++;
                }
            }

            if (!success)
            {
                throw new IOException("Unable to save the image after multiple attempts.");
            }

            return Path.Combine("Avatars", "Coachs", newFileName);
        }


        private void avatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                avatar.Image = new Bitmap(selectedImagePath);
            }
        }
    }
}
