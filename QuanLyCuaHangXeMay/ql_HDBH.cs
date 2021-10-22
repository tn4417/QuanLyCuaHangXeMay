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
    public partial class ql_HDBH : Form
    {
        XuLy xl = new XuLy();
        string tb = "Hoa_Don_Ban_Xe";
        public ql_HDBH()
        {
            InitializeComponent();
        }

        private void ql_HDBH_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Clear_Click(object sender, EventArgs e)
        {
            xl.clearTXT(this);
        }

        private void ql_HDBH_FormClosing(object sender, FormClosingEventArgs e)
        {
            xl.commitChanged(xl.Da_Hoa_Don_Ban_Xe, tb);
        }

        private void ql_HDBH_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = xl.Ds_QLCHXEMAY.Tables[tb];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                xl.txtDataBinding(txt_STT, "STT", dataGridView1);
                xl.txtDataBinding(txt_MaHD, "MaHD", dataGridView1);
                xl.txtDataBinding(txt_MaKH, "MaKH", dataGridView1);
                xl.txtDataBinding(txt_MaNhomXe, "MaNX", dataGridView1);
                xl.txtDataBinding(txt_MaNV, "MaNV", dataGridView1);
                xl.txtDataBinding(txt_SoKhung, "SoKhung", dataGridView1);
                xl.txtDataBinding(txt_SoMay, "SoMay", dataGridView1);
                xl.txtDataBinding(txt_MauXe, "MauXe", dataGridView1);
                xl.txtDataBinding(txt_Gia, "DonGia", dataGridView1);
                xl.txtDataBinding(txt_SoLuong, "SoLuong", dataGridView1);
                xl.txtDataBinding(txt_TongTien, "TongTien", dataGridView1);
                xl.txtDataBinding(txt_NgayLap, "NgayLap", dataGridView1);
            }
            catch { }
        }


        private void btn_Add_Click(object sender, EventArgs e)
        {
            string[] str = { txt_MaHD.Text, txt_MaKH.Text, txt_MaNhomXe.Text, txt_MaNV.Text, txt_SoKhung.Text, txt_SoMay.Text,
                             txt_MauXe.Text, txt_Gia.Text, txt_SoLuong.Text, txt_TongTien.Text, xl.convrtDateTime(txt_NgayLap.Text.ToString()) };
            if (xl.addRow(str, tb, xl.Da_Hoa_Don_Ban_Xe))
                MessageBox.Show("Thanh Cong!");
            else MessageBox.Show("That Bai");
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (xl.RemoveRow(txt_MaHD.Text, tb, xl.Da_Hoa_Don_Ban_Xe))
                MessageBox.Show("Thanh Cong!");
            else MessageBox.Show("That Bai");
        }

        private void btn_Mod_Click(object sender, EventArgs e)
        {
            string[] str = {  txt_MaHD.Text, txt_MaKH.Text, txt_MaNhomXe.Text, txt_MaNV.Text, txt_SoKhung.Text, txt_SoMay.Text,
                             txt_MauXe.Text, txt_Gia.Text, txt_SoLuong.Text, txt_TongTien.Text, xl.convrtDateTime(txt_NgayLap.Text.ToString()) };
            if (xl.UpdateRow(str, tb, xl.Da_Hoa_Don_Ban_Xe))
                MessageBox.Show("Thanh Cong!");
            else MessageBox.Show("That Bai");
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            xl.commitChanged(xl.Da_Hoa_Don_Ban_Xe, tb);
        }



    }
}
