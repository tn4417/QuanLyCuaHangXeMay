using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangXeMay
{
    public partial class Login : Form
    {
        XuLy xl = new XuLy();

        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool MsgExit()
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thoát?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                return true;
            }
            else return false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!xl.chk_Login(txtUser.Text, txtPass.Text))
            {
                MessageBox.Show("Đăng nhập thất bại!");
                return;
            }
            else
            {
                Program.frmMain = null;
                Program.frmMain = new main();
                Program.frmMain.Show();
                this.Hide();
                txtPass.Clear();
                txtUser.Clear();
                txtUser.Select();
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnLogin_Click(sender, e);
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Program.btnExitClck)
                if (MsgExit())
                {
                    Program.btnExitClck = true;
                    Application.Exit();
                }
                else e.Cancel = true;
        }
    }
}
