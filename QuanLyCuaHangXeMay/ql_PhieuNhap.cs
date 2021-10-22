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
    public partial class ql_PhieuNhap : Form
    {

        XuLy xl = new XuLy();
        string tb = "Phieu_Nhap";
        public ql_PhieuNhap()
        {
            InitializeComponent();
        }

        private void ql_PhieuNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ql_PhieuNhap_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = xl.Ds_QLCHXEMAY.Tables[tb];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                xl.txtDataBinding(txt_STT, "STT", dataGridView1);
                xl.txtDataBinding(txt_MaPN, "MaPN", dataGridView1);
                xl.txtDataBinding(txt_MaNV, "MaNV", dataGridView1);
                xl.txtDataBinding(txt_MaNCC, "MaNCC", dataGridView1);
                xl.txtDataBinding(txt_MaNX, "MaNX", dataGridView1);
                xl.txtDataBinding(txt_DonGia, "DonGia", dataGridView1);
                xl.txtDataBinding(txt_SoLuong, "SoLuong", dataGridView1);
                xl.txtDataBinding(txt_ThanhTien, "ThanhTien", dataGridView1);
                xl.txtDataBinding(txt_NgayLap, "NgayLap", dataGridView1);
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] str = { txt_MaPN.Text, txt_MaNV.Text, txt_MaNCC.Text, txt_MaNX.Text, txt_DonGia.Text, txt_SoLuong.Text,
                             txt_ThanhTien.Text, xl.convrtDateTime(txt_NgayLap.Text.ToString()) };
            if (xl.addRow(str, tb, xl.Da_Phieu_Nhap))
                MessageBox.Show("Thanh Cong!");
            else MessageBox.Show("That Bai");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (xl.RemoveRow(txt_MaPN.Text, tb, xl.Da_Phieu_Nhap))
                MessageBox.Show("Thanh Cong!");
            else MessageBox.Show("That Bai");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] str = { txt_MaPN.Text, txt_MaNV.Text, txt_MaNCC.Text, txt_MaNX.Text, txt_DonGia.Text, txt_SoLuong.Text,
                             txt_ThanhTien.Text, xl.convrtDateTime(txt_NgayLap.Text.ToString()) };
            if (xl.UpdateRow(str, tb, xl.Da_Phieu_Nhap))
                MessageBox.Show("Thanh Cong!");
            else MessageBox.Show("That Bai");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            xl.clearTXT(this);
        }

        private void ql_PhieuNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            xl.commitChanged(xl.Da_Phieu_Nhap, tb);
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            xl.commitChanged(xl.Da_Phieu_Nhap, tb);
        }
    }
}
