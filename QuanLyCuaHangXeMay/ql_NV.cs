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
    public partial class ql_NV : Form
    {
        XuLy xl = new XuLy();
        string tb = "Nhan_Vien";

        public ql_NV()
        {
            InitializeComponent();
        }

        private void ql_NV_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ql_NV_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = xl.Ds_QLCHXEMAY.Tables[tb];
        }

        private void ql_NV_FormClosing(object sender, FormClosingEventArgs e)
        {
            xl.commitChanged(xl.Da_Nhan_Vien, tb);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                xl.txtDataBinding(txt_STT, "STT", dataGridView1);
                xl.txtDataBinding(txt_MaNV, "MaNV", dataGridView1);
                xl.txtDataBinding(txt_TenNV, "HoTenNV", dataGridView1);
                xl.txtDataBinding(txt_CMT, "SoCMT", dataGridView1);
                xl.txtDataBinding(txt_DiaChi, "DiaChi", dataGridView1);
                xl.txtDataBinding(txt_ChuyenMon, "ChuyenMon", dataGridView1);
                xl.txtDataBinding(txt_Luong, "Luong", dataGridView1);
            }
            catch { }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            xl.commitChanged(xl.Da_Nhan_Vien, tb);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] str = { txt_MaNV.Text, txt_TenNV.Text, txt_CMT.Text, txt_DiaChi.Text, txt_ChuyenMon.Text, txt_Luong.Text };
            if (xl.addRow(str, tb, xl.Da_Nhan_Vien))
                MessageBox.Show("Thanh Cong!");
            else MessageBox.Show("That Bai");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (xl.RemoveRow(txt_MaNV.Text, tb, xl.Da_Nhan_Vien))
                MessageBox.Show("Thanh Cong!");
            else MessageBox.Show("That Bai");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] str = { txt_MaNV.Text, txt_TenNV.Text, txt_CMT.Text, txt_DiaChi.Text, txt_ChuyenMon.Text, txt_Luong.Text };
            if (xl.UpdateRow(str, tb, xl.Da_Nhan_Vien))
                MessageBox.Show("Thanh Cong!");
            else MessageBox.Show("That Bai");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            xl.clearTXT(this);
        }
    }
}
