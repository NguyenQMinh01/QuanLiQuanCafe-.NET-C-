using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyCafe.DataAccess;
using System.Data.SqlClient;
using QuanLyCafe.Business.Component;
using QuanLyCafe.Business.EntitiesClass;

namespace QuanLyCafe.Presentation
{
    public partial class fr_TK_SP : Form
    {
        public fr_TK_SP()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();
        E_tb_Sanpham tbSP = new E_tb_Sanpham();
        EC_tb_Sanpham sp = new EC_tb_Sanpham();

        public void khoitaoluoi()
        {
            //RepositoryItemPictureEdit image = msds.RepositoryItems.Add("PictureEdit") as RepositoryItemPictureEdit;
            try
            {
                msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                msds.Columns[0].HeaderText = "Mã Sản Phẩm";
                msds.Columns[0].Frozen = true;
                msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                msds.Columns[0].Width = 200;

                msds.Columns[1].HeaderText = "Tên Sản Phẩm";
                msds.Columns[1].Width = 200;

                msds.Columns[2].HeaderText = "Mã Loại";
                msds.Columns[2].Width = 200;

                msds.Columns[3].HeaderText = "Giá Bán";
                msds.Columns[3].Width = 200;

                msds.Columns[4].HeaderText = "Hình Ảnh";
                msds.Columns[4].Width = 200;

                msds.Columns[5].HeaderText = "Mã Nguyên Liệu";
                msds.Columns[5].Width = 200;
            }
            catch (Exception ex)
            {
                
            }


        }
        public void hienthi()
        {
            string sql = "SELECT masp, tensp, maloai, giaban, hinhanh FROM tb_Sanpham";
            msds.DataSource = cn.taobang(sql);
            SqlConnection con = cn.getcon();
            con.Open();
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void txtthongtin_TextChanged(object sender, EventArgs e)
        {
            khoitaoluoi();
            if (op1.Checked)
            {
                msds.DataSource = tbSP.timKiemSanPhamTheoLoai(txtthongtin.Text);

            }
            if (op2.Checked)
            {
                int gia = 0;
                try
                {
                    gia = int.Parse(txtthongtin.Text);
                    msds.DataSource = tbSP.timKiemSanPhamTheoGia(gia);
                }
                catch
                {
                    fr_TK_SP_Load(sender, e);
                }                                              
            }
            if (op4.Checked)
            {                
                msds.DataSource = tbSP.timKiemSanPhamTheoTen(txtthongtin.Text);
            }
        }

        private void fr_TK_SP_Load(object sender, EventArgs e)
        {
            khoitaoluoi();
            msds.DataSource = tbSP.docSanPham();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
