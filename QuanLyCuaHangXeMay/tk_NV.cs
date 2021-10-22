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
    public partial class tk_NV : Form
    {
        XuLy xl = new XuLy();
        string tb = "Nhan_Vien";
        public tk_NV()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tk_NV_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataBindings.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = xl.tk_Table(txt_MaNV.Text, tb, "MaNV");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataBindings.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = xl.tk_Table(txt_HoTenNV.Text, tb, "HoTenNV");
        }
    }
}
