using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangXeMay
{
    public partial class tk_HDBH : Form
    {
        XuLy xl = new XuLy();
        string tb = "Hoa_Don_Ban_Xe";
        public tk_HDBH()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tk_HDBH_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void btn_TK_HD_Click(object sender, EventArgs e)
        {
            dataGridView1.DataBindings.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = xl.tk_Table(txt_MaHD.Text, tb, "MaHD");

        }

        private void btn_TK_KH_Click(object sender, EventArgs e)
        {
            dataGridView1.DataBindings.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = xl.tk_Table(txt_MaKH.Text, tb, "MaKH");
        }
    }
}
