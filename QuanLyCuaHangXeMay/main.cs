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
    public partial class main : Form
    {
        public about frmAbout = null;
        public ql_KH frm_ql_KH = null;
        public ql_NCC frm_ql_NCC = null;
        public ql_BH frm_ql_BH = null;
        public ql_HDBH frm_ql_HDBH = null;
        public ql_HDTT frm_ql_HDTT = null;
        public ql_NhomXe frm_ql_NhomXe = null;
        public ql_NV frm_ql_NV = null;
        public ql_PhieuNhap frm_ql_PhieuNhap = null;
        public ql_XE frm_ql_XE = null;

        public tk_HDBH frm_tk_HDBH = null;
        public tk_HDTT frm_tk_HDTT = null;
        public tk_KH frm_tk_KH = null;
        public tk_NCC frm_tk_NCC = null;
        public tk_NV frm_tk_NV = null;
        public tk_PhieuNhap frm_tk_PhieuNhap = null;



        public main()
        {
            InitializeComponent();
        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.frmMain.Dispose();
            Program.frmMain = null;
            Program.frmLogin.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout = null;
            frmAbout = new about();
            frmAbout.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void show_frm_ql_From(Form frm)
        {
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }
      
        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_ql_KH == null)
            {
                frm_ql_KH = new ql_KH();
                show_frm_ql_From(frm_ql_KH);
            }
            else
            {
                if (frm_ql_KH.IsDisposed)
                {
                    frm_ql_KH = null;
                    frm_ql_KH = new ql_KH();
                    show_frm_ql_From(frm_ql_KH);
                }
                else
                {
                    show_frm_ql_From(frm_ql_KH);
                }
            }
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_ql_NCC == null)
            {
                frm_ql_NCC = new ql_NCC();
                show_frm_ql_From(frm_ql_NCC);
            }
            else
            {
                if (frm_ql_NCC.IsDisposed)
                {
                    frm_ql_NCC = null;
                    frm_ql_NCC = new ql_NCC();
                    show_frm_ql_From(frm_ql_NCC);
                }
                else
                {
                    show_frm_ql_From(frm_ql_NCC);
                }
            }
        }

        private void quảnLýXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_ql_XE == null)
            {
                frm_ql_XE = new ql_XE();
                show_frm_ql_From(frm_ql_XE);
            }
            else
            {
                if (frm_ql_XE.IsDisposed)
                {
                    frm_ql_XE = null;
                    frm_ql_XE = new ql_XE();
                    show_frm_ql_From(frm_ql_XE);
                }
                else
                {
                    show_frm_ql_From(frm_ql_XE);
                }
            }
        }

        private void hoáĐơnThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_ql_HDTT == null)
            {
                frm_ql_HDTT = new ql_HDTT();
                show_frm_ql_From(frm_ql_HDTT);
            }
            else
            {
                if (frm_ql_HDTT.IsDisposed)
                {
                    frm_ql_HDTT = null;
                    frm_ql_HDTT = new ql_HDTT();
                    show_frm_ql_From(frm_ql_HDTT);
                }
                else
                {
                    show_frm_ql_From(frm_ql_HDTT);
                }
            }
        }

        private void hoáĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_ql_HDBH == null)
            {
                frm_ql_HDBH = new ql_HDBH();
                show_frm_ql_From(frm_ql_HDBH);
            }
            else
            {
                if (frm_ql_HDBH.IsDisposed)
                {
                    frm_ql_HDBH = null;
                    frm_ql_HDBH = new ql_HDBH();
                    show_frm_ql_From(frm_ql_HDBH);
                }
                else
                {
                    show_frm_ql_From(frm_ql_HDBH);
                }
            }
        }

        private void nhómXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_ql_NhomXe == null)
            {
                frm_ql_NhomXe = new ql_NhomXe();
                show_frm_ql_From(frm_ql_NhomXe);
            }
            else
            {
                if (frm_ql_NhomXe.IsDisposed)
                {
                    frm_ql_NhomXe = null;
                    frm_ql_NhomXe = new ql_NhomXe();
                    show_frm_ql_From(frm_ql_NhomXe);
                }
                else
                {
                    show_frm_ql_From(frm_ql_NhomXe);
                }
            }
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_ql_PhieuNhap == null)
            {
                frm_ql_PhieuNhap = new ql_PhieuNhap();
                show_frm_ql_From(frm_ql_PhieuNhap);
            }
            else
            {
                if (frm_ql_PhieuNhap.IsDisposed)
                {
                    frm_ql_PhieuNhap = null;
                    frm_ql_PhieuNhap = new ql_PhieuNhap();
                    show_frm_ql_From(frm_ql_PhieuNhap);
                }
                else
                {
                    show_frm_ql_From(frm_ql_PhieuNhap);
                }
            }
        }

        private void bảoHànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_ql_BH == null)
            {
                frm_ql_BH = new ql_BH();
                show_frm_ql_From(frm_ql_BH);
            }
            else
            {
                if (frm_ql_BH.IsDisposed)
                {
                    frm_ql_BH = null;
                    frm_ql_BH = new ql_BH();
                    show_frm_ql_From(frm_ql_BH);
                }
                else
                {
                    show_frm_ql_From(frm_ql_BH);
                }
            }
        }

        private void nhânVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_ql_NV == null)
            {
                frm_ql_NV = new ql_NV();
                show_frm_ql_From(frm_ql_NV);
            }
            else
            {
                if (frm_ql_NV.IsDisposed)
                {
                    frm_ql_NV = null;
                    frm_ql_NV = new ql_NV();
                    show_frm_ql_From(frm_ql_NV);
                }
                else
                {
                    show_frm_ql_From(frm_ql_NV);
                }
            }
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frm_tk_KH == null)
            {
                frm_tk_KH = new tk_KH();
                show_frm_ql_From(frm_tk_KH);
            }
            else
            {
                if (frm_tk_KH.IsDisposed)
                {
                    frm_tk_KH = null;
                    frm_tk_KH = new tk_KH();
                    show_frm_ql_From(frm_tk_KH);
                }
                else
                {
                    show_frm_ql_From(frm_tk_KH);
                }
            }
        }

        private void nhàCungCấpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frm_tk_NCC == null)
            {
                frm_tk_NCC = new tk_NCC();
                show_frm_ql_From(frm_tk_NCC);
            }
            else
            {
                if (frm_tk_NCC.IsDisposed)
                {
                    frm_tk_NCC = null;
                    frm_tk_NCC = new tk_NCC();
                    show_frm_ql_From(frm_tk_NCC);
                }
                else
                {
                    show_frm_ql_From(frm_tk_NCC);
                }
            }
        }

        private void hoáĐơnThanhToánToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frm_tk_HDTT == null)
            {
                frm_tk_HDTT = new tk_HDTT();
                show_frm_ql_From(frm_tk_HDTT);
            }
            else
            {
                if (frm_tk_HDTT.IsDisposed)
                {
                    frm_tk_HDTT = null;
                    frm_tk_HDTT = new tk_HDTT();
                    show_frm_ql_From(frm_tk_HDTT);
                }
                else
                {
                    show_frm_ql_From(frm_tk_HDTT);
                }
            }
        }

        private void hoáĐơnBánHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frm_tk_HDBH == null)
            {
                frm_tk_HDBH = new tk_HDBH();
                show_frm_ql_From(frm_tk_HDBH);
            }
            else
            {
                if (frm_tk_HDBH.IsDisposed)
                {
                    frm_tk_HDBH = null;
                    frm_tk_HDBH = new tk_HDBH();
                    show_frm_ql_From(frm_tk_HDBH);
                }
                else
                {
                    show_frm_ql_From(frm_tk_HDBH);
                }
            }
        }

        private void phiếuNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frm_tk_PhieuNhap == null)
            {
                frm_tk_PhieuNhap = new tk_PhieuNhap();
                show_frm_ql_From(frm_tk_PhieuNhap);
            }
            else
            {
                if (frm_tk_PhieuNhap.IsDisposed)
                {
                    frm_tk_PhieuNhap = null;
                    frm_tk_PhieuNhap = new tk_PhieuNhap();
                    show_frm_ql_From(frm_tk_PhieuNhap);
                }
                else
                {
                    show_frm_ql_From(frm_tk_PhieuNhap);
                }
            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_tk_NV == null)
            {
                frm_tk_NV = new tk_NV();
                show_frm_ql_From(frm_tk_NV);
            }
            else
            {
                if (frm_tk_NV.IsDisposed)
                {
                    frm_tk_NV = null;
                    frm_tk_NV = new tk_NV();
                    show_frm_ql_From(frm_tk_NV);
                }
                else
                {
                    show_frm_ql_From(frm_tk_NV);
                }
            }
        }

        private void main_Load(object sender, EventArgs e)
        {
            if (Program.a > 1)
                aboutToolStripMenuItem_Click(sender, e);
            else return;
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Program.btnExitClck)
            {
                if (MessageBox.Show("Bạn có muốn đăng xuất?", "Đăng xuất?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Program.frmLogin = null;
                    Program.frmLogin = new Login();
                    Program.frmLogin.Show();
                    Program.frmLogin.Focus();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thoát?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Program.btnExitClck = true;
                Application.Exit();
            }
        }
    }
}
