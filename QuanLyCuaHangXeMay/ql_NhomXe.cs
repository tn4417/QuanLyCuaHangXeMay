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
    public partial class ql_NhomXe : Form
    {
        XuLy xl = new XuLy();
        string tb = "Nhom_Xe";

        public ql_NhomXe()
        {
            InitializeComponent();
        }

        private void ql_NhomXe_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ql_NhomXe_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = xl.Ds_QLCHXEMAY.Tables[tb];
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            xl.clearTXT(this);
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (xl.RemoveRow(txt_MaNX.Text, tb, xl.Da_Nhom_Xe))
                MessageBox.Show("Thanh Cong!");
            else MessageBox.Show("That Bai");
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string[] str = { txt_MaNX.Text, txt_HSX.Text, txt_DonGia.Text, txt_SoLuong.Text };
            if (xl.addRow(str, tb, xl.Da_Nhom_Xe))
                MessageBox.Show("Thanh Cong!");
            else MessageBox.Show("That Bai");
        }

        private void btn_Mod_Click(object sender, EventArgs e)
        {
            string[] str = { txt_MaNX.Text, txt_HSX.Text, txt_DonGia.Text, txt_SoLuong.Text };
            if (xl.UpdateRow(str, tb, xl.Da_Nhom_Xe))
                MessageBox.Show("Thanh Cong!");
            else MessageBox.Show("That Bai");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                xl.txtDataBinding(txt_STT, "STT", dataGridView1);
                xl.txtDataBinding(txt_MaNX, "MaNX", dataGridView1);
                xl.txtDataBinding(txt_HSX, "HangSX", dataGridView1);
                xl.txtDataBinding(txt_DonGia, "DonGia", dataGridView1);
                xl.txtDataBinding(txt_SoLuong, "SoLuong", dataGridView1);
            }
            catch { }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            xl.commitChanged(xl.Da_Nhom_Xe, tb);
        }

        private void ql_NhomXe_FormClosing(object sender, FormClosingEventArgs e)
        {
            xl.commitChanged(xl.Da_Nhom_Xe, tb);
        }
    }
}
