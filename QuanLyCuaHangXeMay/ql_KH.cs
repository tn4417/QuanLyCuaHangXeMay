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
    public partial class ql_KH : Form
    {

        XuLy xl = new XuLy();
        string tb = "Khach_Hang";

        public ql_KH()
        {
            InitializeComponent();
        }

        private void ql_KH_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            xl.clearTXT(this);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string[] str = { txt_MaKH.Text, txt_HoTen.Text, txt_DiaChi.Text, txt_SDT.Text, txt_CMT.Text };
            if (xl.addRow(str, tb, xl.Da_Khach_Hang))
                MessageBox.Show("Thanh Cong!");
            else MessageBox.Show("That Bai");
        }

        private void ql_KH_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = xl.Ds_QLCHXEMAY.Tables[tb];
        }

        private void ql_KH_FormClosing(object sender, FormClosingEventArgs e)
        {
            xl.commitChanged(xl.Da_Khach_Hang, tb);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                xl.txtDataBinding(txt_STT, "STT", dataGridView1);
                xl.txtDataBinding(txt_MaKH, "MaKH", dataGridView1);
                xl.txtDataBinding(txt_HoTen, "HoTenKH", dataGridView1);
                xl.txtDataBinding(txt_DiaChi, "DiaChiKH", dataGridView1);
                xl.txtDataBinding(txt_SDT, "SDT", dataGridView1);
                xl.txtDataBinding(txt_CMT, "SoCMT", dataGridView1);
            }
            catch { }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            xl.commitChanged(xl.Da_Khach_Hang, tb);
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (xl.RemoveRow(txt_MaKH.Text, tb, xl.Da_Khach_Hang))
                MessageBox.Show("Thanh Cong!");
            else MessageBox.Show("That Bai");
        }

        private void btn_Mod_Click(object sender, EventArgs e)
        {
            string[] str = { txt_MaKH.Text, txt_HoTen.Text, txt_DiaChi.Text, txt_SDT.Text, txt_CMT.Text };
            if (xl.UpdateRow(str, tb, xl.Da_Khach_Hang))
                MessageBox.Show("Thanh Cong!");
            else MessageBox.Show("That Bai");
        }


    }
}
