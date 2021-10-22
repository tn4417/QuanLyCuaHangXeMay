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
    public partial class tk_NCC : Form
    {
        XuLy xl = new XuLy();
        string tb = "Nha_Cung_Cap";
        public tk_NCC()
        {
            InitializeComponent();
        }

        private void tk_NCC_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataBindings.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = xl.tk_Table(txt_MaNCC.Text, tb, "MaNCC");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataBindings.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = xl.tk_Table(txt_TenNCC.Text, tb, "TenNCC");
        }
    }
}
