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
using System.IO;
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
        private string selectedImagePath;

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
            
            try
            {

                if (avatar.Image == null)
                {
                    Player player = new Player(int.Parse(item.Tag.ToString()), txtName.Text.Trim(), cbbPos.Text, dt, txtPhoneNumber.Text.Trim(), (int)nudJerseyNum.Value, null);
                    PlayerDAO playerDAO = new PlayerDAO();
                    playerDAO.AddPlayer(player);
                }
                else
                {
                    Player player = new Player(int.Parse(item.Tag.ToString()), txtName.Text.Trim(), cbbPos.Text, dt, txtPhoneNumber.Text, (int)nudJerseyNum.Value, GetRelativePath(txtName.Text.Trim()));
                    PlayerDAO playerDAO = new PlayerDAO();
                    playerDAO.AddPlayer(player);
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Team ID not found, please try again !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return;
            }

            MessageBox.Show("Add new player successfully !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            screen.InvokeButtonPlayerClick();
            this.Close();
        }

        private string GetRelativePath(string name)
        {
            string rootFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Avatars");
            string targetFolder = Path.Combine(rootFolder, "Players");

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

            return Path.Combine("Avatars", "Players", newFileName);
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
