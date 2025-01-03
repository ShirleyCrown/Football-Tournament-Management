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
    public partial class AddTournament : Form
    {
        Main_screen screen;
        private string selectedImagePath;
        private readonly string user;
        public AddTournament(string user, Main_screen screen)
        {
            InitializeComponent();
            this.user = user;
            this.screen = screen;
        }

        public AddTournament()
        {
        }

        public void InvokeButtonClick()
        {
            btnAdd.PerformClick();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please insert all data !!!");
                return;
            }

            if (dpkStart.Value > dpkEnd.Value)
            {
                MessageBox.Show("Invalid start date !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure to add new tournament ?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            string[] sDate = dpkStart.Text.Split('/');
            DateTime sDateTime = new DateTime(int.Parse(sDate[2]), int.Parse(sDate[1]), int.Parse(sDate[0]));

            string[] eDate = dpkEnd.Text.Split('/');
            DateTime eDateTime = new DateTime(int.Parse(eDate[2]), int.Parse(eDate[1]), int.Parse(eDate[0]));

            if (avatar.Image == null)
            {
                Tournament tournament = new Tournament(user, txtName.Text.Trim(), sDateTime, eDateTime, txtLocation.Text.Trim(), null);

                TournamentDAO tournamentDAO = new TournamentDAO();
                tournamentDAO.addTournament(tournament);
            }
            else
            {
                Tournament tournament = new Tournament(user, txtName.Text.Trim(), sDateTime, eDateTime, txtLocation.Text.Trim(), GetRelativePath(txtName.Text.Trim()));

                TournamentDAO tournamentDAO = new TournamentDAO();
                tournamentDAO.addTournament(tournament);
            }

            MessageBox.Show("Add new coach successfully !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            screen.InvokeButtonTournamentClick();
            this.Close();
        }

        private string GetRelativePath(string name)
        {
            string rootFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Avatars");
            string targetFolder = Path.Combine(rootFolder, "Tournaments");

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

            return Path.Combine("Avatars", "Tournaments", newFileName);
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
