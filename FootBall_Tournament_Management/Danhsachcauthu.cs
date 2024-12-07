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
using FootBall_Tournament_Management.NewFolder1;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace FootBall_Tournament_Management
{
    public partial class Danhsachcauthu : UserControl
    {
        private static Danhsachcauthu _instance;
        public static Danhsachcauthu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Danhsachcauthu();
                return _instance;
            }
        }
        public Danhsachcauthu()
        {
            InitializeComponent();
        }
        private async void Danhsachcauthu_Load(object sender, EventArgs e)
        {
            PlayerDAO playerDAO = new PlayerDAO();
            DataTable players = await Task.Run(() => playerDAO.GetAllPlayers());

            if (players.Rows.Count > 0)
            {
                BindPlayersToGroupBoxes(players);
            }
            else
            {
                MessageBox.Show("Không có player.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BindPlayersToGroupBoxes(DataTable players)
        {
            var groupBoxAndLabels = new List<(GroupBox groupBox, Label label)>
    {
        (groupBox1, label2),
        (groupBox2, label3),
        (groupBox3, label4),
        (groupBox4, label5),
        (groupBox5, label6),
        (groupBox6, label7),
        (groupBox7, label8),
        (groupBox8, label9),
        (groupBox9, label10),
        (groupBox10, label11)
    };
            for (int i = 0; i < Math.Min(players.Rows.Count, groupBoxAndLabels.Count); i++)
            {
                var (groupBox, label) = groupBoxAndLabels[i];
                DataRow playerRow = players.Rows[i];
                int playerId = Convert.ToInt32(playerRow["PlayerID"]);
                string playerName = playerRow["PlayerName"].ToString();
                groupBox.Tag = playerId;
                label.Text = playerName;
                groupBox.Click += GroupBox_Click;
            }
        }


        private void GroupBox_Click(object sender, EventArgs e)
        {
            GroupBox clickedGroupBox = sender as GroupBox;

            if (clickedGroupBox != null && clickedGroupBox.Tag is int playerId)
            {
                PlayerDAO playerDAO = new PlayerDAO();
                Player player = playerDAO.GetOnePlayer(playerId);

                if (player != null)
                {
                    Thongtinnguoichoi detailForm = new Thongtinnguoichoi();
                    detailForm.SetPlayerDetails(player);
                    detailForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin người chơi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
