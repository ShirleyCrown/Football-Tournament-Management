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
    public partial class Main_screen : Form
    {
        public Main_screen()
        {
            InitializeComponent();
        }

        private void Main_screen_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnAthle_Click(object sender, EventArgs e)
        {
            if (!panelUserControl.Controls.Contains(Danhsachcauthu.Instance))
            { 
                panelUserControl.Controls.Add(Danhsachcauthu.Instance);
                Danhsachcauthu.Instance.Dock = DockStyle.Fill;  // Đảm bảo UserControl chiếm toàn bộ diện tích của panel
                Danhsachcauthu.Instance.BringToFront();  // Đảm bảo UserControl hiển thị trên cùng
            }
            else
            {
                // Nếu đã có, chỉ cần đưa nó lên trên cùng
                Danhsachcauthu.Instance.BringToFront();
            }
        }

        private void Main_screen_Load(object sender, EventArgs e)
        {

        }
    }
}
