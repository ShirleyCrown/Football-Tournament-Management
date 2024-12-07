using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootBall_Tournament_Management.NewFolder1;

namespace FootBall_Tournament_Management
{
    public partial class Thongtinnguoichoi : Form
    {
        public Thongtinnguoichoi()
        {
            InitializeComponent();
        }

        public void SetPlayerDetails(Player player)
        {
            label1.Text = $"Thông tin chi tiết";

            // Tạo DataTable để chứa thông tin người chơi
            DataTable playerDetails = new DataTable();
            playerDetails.Columns.Add("Thông tin", typeof(string));
            playerDetails.Columns.Add("Giá trị", typeof(string));

            // Thêm thông tin vào DataTable
            playerDetails.Rows.Add("Player ID", player.PlayerID.ToString());
            playerDetails.Rows.Add("Tên", player.PlayerName);
            playerDetails.Rows.Add("Đội", player.TeamID.ToString());
            playerDetails.Rows.Add("Vị trí", player.Position);
            playerDetails.Rows.Add("Ngày sinh", player.Dob.ToString("dd/MM/yyyy"));
            playerDetails.Rows.Add("Số điện thoại", player.PhoneNumber);
            playerDetails.Rows.Add("Số áo", player.JerseyNumber.ToString());
            dataGridView1.DataSource = playerDetails;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
        }

        private void Thongtinnguoichoi_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Thongtinnguoichoi_Load_1(object sender, EventArgs e)
        {

        }
    }
}
