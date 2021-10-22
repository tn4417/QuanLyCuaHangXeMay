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
    public partial class ql_HDTT : Form
    {
        XuLy xl = new XuLy();
        string tb = "Hoa_Don_Thanh_Toan";

        public ql_HDTT()
        {
            InitializeComponent();
        }

        private void ql_HDTT_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            xl.clearTXT(this);
        }

        private void ql_HDTT_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = xl.Ds_QLCHXEMAY.Tables[tb];
        }

        private void ql_HDTT_FormClosing(object sender, FormClosingEventArgs e)
        {
            xl.commitChanged(xl.Da_Hoa_Don_Thanh_Toan, tb);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                xl.txtDataBinding(txt_STT, "STT", dataGridView1);
                xl.txtDataBinding(txt_MaTT, "MaTT", dataGridView1);
                xl.txtDataBinding(txt_MaNCC, "MaNCC", dataGridView1);
                xl.txtDataBinding(txt_TongTien, "TongTien", dataGridView1);
                xl.txtDataBinding(txt_NgayLap, "NgayLap", dataGridView1);
            }
            catch { }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string[] str = { txt_MaTT.Text, txt_MaNCC.Text, txt_TongTien.Text, txt_NgayLap.Text };
            if (xl.addRow(str, tb, xl.Da_Hoa_Don_Thanh_Toan))
                MessageBox.Show("Thanh Cong!");
            else MessageBox.Show("That Bai");
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            xl.commitChanged(xl.Da_Hoa_Don_Thanh_Toan, tb);
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (xl.RemoveRow(txt_MaTT.Text, tb, xl.Da_Hoa_Don_Thanh_Toan))
                MessageBox.Show("Thanh Cong!");
            else MessageBox.Show("That Bai");
        }

        private void btn_Mod_Click(object sender, EventArgs e)
        {
            string[] str = { txt_MaTT.Text, txt_MaNCC.Text, txt_TongTien.Text, txt_NgayLap.Text };
            if (xl.UpdateRow(str, tb, xl.Da_Hoa_Don_Thanh_Toan))
                MessageBox.Show("Thanh Cong!");
            else MessageBox.Show("That Bai");
        }
    }
}
