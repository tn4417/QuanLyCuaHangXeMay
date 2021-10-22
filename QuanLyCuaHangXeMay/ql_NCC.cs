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
    public partial class ql_NCC : Form
    {
        XuLy xl = new XuLy();
        string tb = "Nha_Cung_Cap";

        public ql_NCC()
        {
            InitializeComponent();
        }

        private void ql_NCC_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ql_NCC_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = xl.Ds_QLCHXEMAY.Tables[tb];
        }

        private void ql_NCC_FormClosing(object sender, FormClosingEventArgs e)
        {
            xl.commitChanged(xl.Da_Nha_Cung_Cap, tb);
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            xl.commitChanged(xl.Da_Khach_Hang, tb);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string[] str = { txt_MaNCC.Text, txt_TenNCC.Text, txt_DiaChi.Text, txt_SDT.Text, txt_EMail.Text };
            if (xl.addRow(str, tb, xl.Da_Nha_Cung_Cap))
                MessageBox.Show("Thanh Cong!");
            else MessageBox.Show("That Bai");
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (xl.RemoveRow(txt_MaNCC.Text, tb, xl.Da_Nha_Cung_Cap))
                MessageBox.Show("Thanh Cong!");
            else MessageBox.Show("That Bai");
        }

        private void btn_Mod_Click(object sender, EventArgs e)
        {
            string[] str = { txt_MaNCC.Text, txt_TenNCC.Text, txt_DiaChi.Text, txt_SDT.Text, txt_EMail.Text };
            if (xl.UpdateRow(str, tb, xl.Da_Nha_Cung_Cap))
                MessageBox.Show("Thanh Cong!");
            else MessageBox.Show("That Bai");
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            xl.clearTXT(this);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                xl.txtDataBinding(txt_STT, "STT", dataGridView1);
                xl.txtDataBinding(txt_MaNCC, "MaNCC", dataGridView1);
                xl.txtDataBinding(txt_TenNCC, "TenNCC", dataGridView1);
                xl.txtDataBinding(txt_DiaChi, "DiaChi", dataGridView1);
                xl.txtDataBinding(txt_SDT, "SDT", dataGridView1);
                xl.txtDataBinding(txt_EMail, "Email", dataGridView1);
            }
            catch { }
        }

    }
}
