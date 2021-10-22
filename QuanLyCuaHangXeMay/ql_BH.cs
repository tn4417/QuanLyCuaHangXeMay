using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyCuaHangXeMay
{
    public partial class ql_BH : Form
    {

        XuLy xl = new XuLy();

        string tb = "Bao_Hanh";

        public ql_BH()
        {
            InitializeComponent();
        }

        private void ql_BH_FormClosed(object sender, FormClosedEventArgs e)
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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string[] str = { txt_MaBH.Text, txt_MaKH.Text, txt_SoKhung.Text, txt_SoMay.Text };
            if (xl.addRow(str, tb, xl.Da_Bao_Hanh))
                MessageBox.Show("Thanh Cong!");
            else MessageBox.Show("That Bai");
        }

        private void ql_BH_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = xl.Ds_QLCHXEMAY.Tables[tb];
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            xl.commitChanged(xl.Da_Bao_Hanh, tb);
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (xl.RemoveRow(txt_MaBH.Text, tb, xl.Da_Bao_Hanh))
                MessageBox.Show("Thanh Cong!");
            else MessageBox.Show("That Bai");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                xl.txtDataBinding(txt_STT, "STT", dataGridView1);
                xl.txtDataBinding(txt_MaBH, "MaBH", dataGridView1);
                xl.txtDataBinding(txt_MaKH, "MaKH", dataGridView1);
                xl.txtDataBinding(txt_SoKhung, "SoKhung", dataGridView1);
                xl.txtDataBinding(txt_SoMay, "SoMay", dataGridView1);
            }
            catch { }
        }

        private void btn_Mod_Click(object sender, EventArgs e)
        {
            string[] str = { txt_MaBH.Text, txt_MaKH.Text, txt_SoKhung.Text, txt_SoMay.Text };
            if (xl.UpdateRow(str, tb, xl.Da_Bao_Hanh))
                MessageBox.Show("Thanh Cong!");
            else MessageBox.Show("That Bai");
        }

        private void ql_BH_FormClosing(object sender, FormClosingEventArgs e)
        {
            xl.commitChanged(xl.Da_Bao_Hanh, tb);
        }


    }
}
