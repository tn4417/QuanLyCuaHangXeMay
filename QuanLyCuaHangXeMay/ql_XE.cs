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
    public partial class ql_XE : Form
    {

        XuLy xl = new XuLy();

        string tb = "Xe";
        public ql_XE()
        {
            InitializeComponent();
        }

        private void ql_XE_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ql_XE_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = xl.Ds_QLCHXEMAY.Tables[tb];
        }

        private void ql_XE_FormClosing(object sender, FormClosingEventArgs e)
        {
            xl.commitChanged(xl.Da_Xe, tb);
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            xl.commitChanged(xl.Da_Xe, tb);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            xl.clearTXT(this);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                xl.txtDataBinding(txt_STT, "STT", dataGridView1);
                xl.txtDataBinding(txt_MaNX, "MaNX", dataGridView1);
                xl.txtDataBinding(txt_MauSac, "MauSac", dataGridView1);
                xl.txtDataBinding(txt_SoKhung, "SoKhung", dataGridView1);
                xl.txtDataBinding(txt_SoMay, "SoMay", dataGridView1);
                xl.txtDataBinding(txt_DonGia, "DonGia", dataGridView1);
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] str = { txt_MaNX.Text, txt_SoKhung.Text, txt_SoMay.Text, txt_MauSac.Text, txt_DonGia.Text };
            if (xl.addRow(str, tb, xl.Da_Xe))
                MessageBox.Show("Thanh Cong!");
            else MessageBox.Show("That Bai");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] str = { txt_MaNX.Text, txt_SoKhung.Text, txt_SoMay.Text, txt_MauSac.Text, txt_DonGia.Text };
            if (xl.UpdateRow(str, tb, xl.Da_Xe))
                MessageBox.Show("Thanh Cong!");
            else MessageBox.Show("That Bai");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (xl.RemoveRow(txt_MaNX.Text, tb, xl.Da_Xe))
                MessageBox.Show("Thanh Cong!");
            else MessageBox.Show("That Bai");
        }
    }
}
