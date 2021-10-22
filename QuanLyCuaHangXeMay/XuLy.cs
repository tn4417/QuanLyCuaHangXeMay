using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCuaHangXeMay
{
    public class XuLy
    {

        #region KhaiBao & LoadData
        private SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_CUAHANGXEMAYConnectionString"].ConnectionString.ToString());

        public SqlConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }
        private DataSet ds_QLCHXEMAY = new DataSet();

        public DataSet Ds_QLCHXEMAY
        {
            get { return ds_QLCHXEMAY; }
            set { ds_QLCHXEMAY = value; }
        }

        private SqlDataAdapter da_Bao_Hanh = null, da_Dang_Nhap = null, da_Hoa_Don_Ban_Xe = null,
                               da_Hoa_Don_Thanh_Toan = null, da_Khach_Hang = null, da_Nha_Cung_Cap = null,
                               da_Nhan_Vien = null, da_Nhom_Xe = null, da_Phieu_Nhap = null, da_Xe = null;

        public SqlDataAdapter Da_Phieu_Nhap
        {
            get { return da_Phieu_Nhap; }
            set { da_Phieu_Nhap = value; }
        }

        public SqlDataAdapter Da_Nhom_Xe
        {
            get { return da_Nhom_Xe; }
            set { da_Nhom_Xe = value; }
        }

        public SqlDataAdapter Da_Nhan_Vien
        {
            get { return da_Nhan_Vien; }
            set { da_Nhan_Vien = value; }
        }

        public SqlDataAdapter Da_Nha_Cung_Cap
        {
            get { return da_Nha_Cung_Cap; }
            set { da_Nha_Cung_Cap = value; }
        }

        public SqlDataAdapter Da_Khach_Hang
        {
            get { return da_Khach_Hang; }
            set { da_Khach_Hang = value; }
        }

        public SqlDataAdapter Da_Hoa_Don_Thanh_Toan
        {
            get { return da_Hoa_Don_Thanh_Toan; }
            set { da_Hoa_Don_Thanh_Toan = value; }
        }

        public SqlDataAdapter Da_Hoa_Don_Ban_Xe
        {
            get { return da_Hoa_Don_Ban_Xe; }
            set { da_Hoa_Don_Ban_Xe = value; }
        }

        public SqlDataAdapter Da_Dang_Nhap
        {
            get { return da_Dang_Nhap; }
            set { da_Dang_Nhap = value; }
        }

        public SqlDataAdapter Da_Bao_Hanh
        {
            get { return da_Bao_Hanh; }
            set { da_Bao_Hanh = value; }
        }

        public SqlDataAdapter Da_Xe
        {
            get { return da_Xe; }
            set { da_Xe = value; }
        }

        public XuLy()
        {
            da_Xe = addTable("Xe");
            da_Hoa_Don_Ban_Xe = addTable("Hoa_Don_Ban_Xe");
            da_Bao_Hanh = addTable("Bao_Hanh");
            da_Dang_Nhap = addTable("Dang_Nhap");
            da_Hoa_Don_Thanh_Toan = addTable("Hoa_Don_Thanh_Toan");
            da_Khach_Hang = addTable("Khach_Hang");
            da_Nha_Cung_Cap = addTable("Nha_Cung_Cap");
            da_Nhan_Vien = addTable("Nhan_Vien");
            da_Nhom_Xe = addTable("Nhom_Xe");
            da_Phieu_Nhap = addTable("Phieu_Nhap");

        }


        public SqlDataAdapter addTable(string tb)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from " + tb, conn);
                da.Fill(ds_QLCHXEMAY, tb);
                if (tb.Equals("Xe"))//|| tb == "Bao_Hanh" || tb == "Hoa_Don_Thanh_Toan"
                {
                    DataColumn[] prmkey = new DataColumn[2];
                    for (int i = 0; i < prmkey.Count(); i++)
                        prmkey[i] = ds_QLCHXEMAY.Tables[tb].Columns[i + 1];

                    ds_QLCHXEMAY.Tables[tb].PrimaryKey = prmkey;
                    ds_QLCHXEMAY.Tables[tb].Columns[0].DataType = System.Type.GetType("System.Int32");
                    ds_QLCHXEMAY.Tables[tb].Columns[0].AutoIncrement = true;
                    ds_QLCHXEMAY.Tables[tb].Columns[0].AutoIncrementSeed = ds_QLCHXEMAY.Tables[tb].Rows.Count + 1;
                    ds_QLCHXEMAY.Tables[tb].Columns[0].AutoIncrementStep = 1;
                }
                //else if (tb == "Hoa_Don_Ban_Xe" || tb == "Phieu_Nhap")
                //{
                //    DataColumn[] prmkey = new DataColumn[4];
                //    for (int i = 0; i < prmkey.Count(); i++)
                //        prmkey[i] = ds_QLCHXEMAY.Tables[tb].Columns[i + 1];

                //    ds_QLCHXEMAY.Tables[tb].PrimaryKey = prmkey;
                //    ds_QLCHXEMAY.Tables[tb].Columns[0].DataType = System.Type.GetType("System.Int32");
                //    ds_QLCHXEMAY.Tables[tb].Columns[0].AutoIncrement = true;
                //    ds_QLCHXEMAY.Tables[tb].Columns[0].AutoIncrementSeed = ds_QLCHXEMAY.Tables[tb].Rows.Count + 1;
                //    ds_QLCHXEMAY.Tables[tb].Columns[0].AutoIncrementStep = 1;
                //}
                else
                {
                    DataColumn[] prmkey = new DataColumn[1];
                    prmkey[0] = ds_QLCHXEMAY.Tables[tb].Columns[1];
                    ds_QLCHXEMAY.Tables[tb].PrimaryKey = prmkey;

                    ds_QLCHXEMAY.Tables[tb].Columns[0].DataType = System.Type.GetType("System.Int32");
                    ds_QLCHXEMAY.Tables[tb].Columns[0].AutoIncrement = true;
                    ds_QLCHXEMAY.Tables[tb].Columns[0].AutoIncrementSeed = ds_QLCHXEMAY.Tables[tb].Rows.Count + 1;
                    ds_QLCHXEMAY.Tables[tb].Columns[0].AutoIncrementStep = 1;
                }
                return da;
            }
            catch { return null; }
        }

        public bool chk_Login(string user, string pass)
        {
            DataRow dr_DN = ds_QLCHXEMAY.Tables["Dang_Nhap"].Rows.Find(user);
            if (dr_DN == null)
                return false;
            else
            {
                if (!dr_DN["PassWord"].ToString().Equals(pass))
                    return false;
                else
                {
                    return true;
                }
            }
        }

        public void clearTXT(Control item)
        {
            if (item.GetType() == typeof(RadioButton))
            {
                RadioButton rdb = (RadioButton)item;
                rdb.DataBindings.Clear();
                rdb.Checked = false;
                return;
            }
            else if (item.GetType() == typeof(TextBox))
            {
                TextBox txt = (TextBox)item;
                txt.DataBindings.Clear();
                txt.Text = null;
                return;
            }
            foreach (Control it in item.Controls)
            {
                clearTXT(it);
            }
        }

        public void txtDataBinding(TextBox t, string column, DataGridView dgv)
        {
            t.DataBindings.Clear();
            t.DataBindings.Add("Text", dgv.DataSource, column);
        }

        public string convrtDateTime(string date)
        {
            DateTime d = new DateTime();
            d = Convert.ToDateTime(date);
            return d.ToLongDateString();
        }
        #endregion

        public bool commitChanged(SqlDataAdapter da, string tb)
        {
            try
            {
                SqlCommandBuilder build = new SqlCommandBuilder(da);
                da.Update(ds_QLCHXEMAY, tb);
                return true;
            }
            catch { return false; }


        }

        public bool addRow(string[] columns, string tb, SqlDataAdapter da)
        {
            try
            {
                DataRow dr_add = ds_QLCHXEMAY.Tables[tb].NewRow();
                for (int i = 0; i < ds_QLCHXEMAY.Tables[tb].Columns.Count - 1; i++)
                    dr_add[i + 1] = columns[i].ToString();

                ds_QLCHXEMAY.Tables[tb].Rows.Add(dr_add);
                return true & commitChanged(da, tb);
            }
            catch { return false; }
        }

        public bool RemoveRow(string find_str, string tb, SqlDataAdapter da)
        {
            try
            {
                DataRow dr_remv = Ds_QLCHXEMAY.Tables[tb].Rows.Find(find_str);
                if (dr_remv != null)
                {
                    dr_remv.Delete();

                    return true & commitChanged(da, tb);
                }
                else return false;
            }
            catch { return false; }
        }
        public bool UpdateRow(string[] find_str, string tb, SqlDataAdapter da)
        {
            try
            {
                DataRow dr_UD = ds_QLCHXEMAY.Tables[tb].Rows.Find(find_str[0]);
                if (dr_UD != null)
                {
                    for (int i = 0; i < ds_QLCHXEMAY.Tables[tb].Columns.Count - 1; i++)
                        dr_UD[i + 1] = find_str[i].ToString();
                    return true & commitChanged(da, tb);
                }
                else return false;
            }
            catch { return false; }
        }

        public DataTable tk_Table(string key_search, string tb, string columnName)
        {
            DataSet ds_TK = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * From " + tb.Trim()
                    + " Where " + columnName.Trim() + " LIKE '%" + key_search.Trim() + "%' ORDER BY STT", conn);
                da.Fill(ds_TK, tb);
                return ds_TK.Tables[tb];
            }
            catch { return null; }
        }

        public DataTable tk_TableMore(string key_search1, string tb, string columnName1,
                                                    string key_search2, string columnName2)
        {
            DataSet ds_TK = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * From " + tb.Trim() + " Where " + columnName1.Trim()
                    + " LIKE '%" + key_search1.Trim() + "%' AND " + columnName2.Trim()
                    + " LIKE '%" + key_search2.Trim() + "%' ORDER BY STT", conn);
                da.Fill(ds_TK, tb);
                return ds_TK.Tables[tb];
            }
            catch { return null; }
        }
    }
}
