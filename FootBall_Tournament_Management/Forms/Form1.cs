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
using FootBall_Tournament_Management.DAO;

namespace FootBall_Tournament_Management.Forms
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

            foreach (DataRow row in dt.Rows)
            {
                MessageBox.Show($"ID: {row["PlayerID"]}, Name: {row["PlayerName"]}, Position: {row["Position"]}");

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
