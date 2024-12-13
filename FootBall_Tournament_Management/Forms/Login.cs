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
using MySql.Data.MySqlClient;

namespace FootBall_Tournament_Management.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtLogin.Text = "admin1";
            TxtPassword.Text = "password123";
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.KeyPreview = true;
            this.KeyDown += Login_KeyDown;
            
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                

                if (e.KeyCode == Keys.Enter && !String.IsNullOrEmpty(txtLogin.Text.Trim()))
                {
                    e.SuppressKeyPress = true;
                    TxtPassword.Focus();
                }
                else if (TxtPassword.Focused) // Nếu đang nhập mật khẩu
                {
                    btnLogin_Click(sender, e); // Thực hiện đăng nhập
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtLogin.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập usename!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Focus();
                return;
            }
            if (String.IsNullOrEmpty(TxtPassword.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập password!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtPassword.Focus();
                return;
            }

            AccountDAO accountDAO = new AccountDAO();
            string username = txtLogin.Text.Trim();
            string password = TxtPassword.Text.Trim();

            if (accountDAO.IsExisted(username, password))
            {
                Main_screen main_Screen = new Main_screen(txtLogin.Text.Trim());
                main_Screen.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtPassword.Clear();
                TxtPassword.Focus();
            }

        }

        

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (result == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
            Application.Exit();
        }

       
    }
}