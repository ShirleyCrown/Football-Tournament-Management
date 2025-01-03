using DevComponents.DotNetBar;
using FootBall_Tournament_Management.DAO;
using FootBall_Tournament_Management.NewFolder1;
using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FootBall_Tournament_Management.Forms
{
    public partial class AddTeam : Form
    {
        private Main_screen screen;
        private string selectedImagePath;

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
            
            try
            {
                
                if (avatar.Image == null)
                {
                    Team team = new Team(txtName.Text.Trim(), int.Parse(item.Tag.ToString()), dt, null);
                    TeamDAO teamDAO = new TeamDAO();
                    teamDAO.addTeam(team);
                }
                else
                {
                    Team team = new Team(txtName.Text.Trim(), int.Parse(item.Tag.ToString()), dt, GetRelativePath(txtName.Text.Trim()));
                    TeamDAO teamDAO = new TeamDAO();
                    teamDAO.addTeam(team);
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Coach ID must be defined, please try again !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
                return;
            }

            MessageBox.Show("Add new team successfully !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private string GetRelativePath(string name)
        {
            string rootFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Avatars");
            string targetFolder = Path.Combine(rootFolder, "Teams");

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

            return Path.Combine("Avatars", "Teams", newFileName);
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
