using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar;
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

namespace FootBall_Tournament_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatabaseHelper helper = new DatabaseHelper();
            DataTable dt = helper.GetAllPlayers();

            foreach(DataRow row in dt.Rows)
            {
                MessageBox.Show($"ID: {row["PlayerID"]}, Name: {row["PlayerName"]}, Position: {row["Position"]}");
                
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBoxEx1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
