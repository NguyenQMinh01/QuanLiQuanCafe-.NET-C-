using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCafe.Business.EntitiesClass;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using QuanLyCafe.DataAccess;
namespace QuanLyCafe.DataAccess
{
    class SQL_tb_Sanpham
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtraHang(string mahang)
        {
            return cn.kiemtra("select count(*) from [tb_Sanpham] where masp=N'" + mahang + "'");
        }

      
        public void themmoiHang(EC_tb_Sanpham hang)
        {
            SqlConnection con = cn.getcon();
            try
            {

                con.Open();
                string sql = @"INSERT INTO tb_Sanpham  (masp, tensp, maloai, giaban, hinhanh) VALUES (N'" + hang.MASP + "',N'" + hang.TENSP + "',N'" + hang.MALOAI + "',N'" + hang.GIABAN + "','" + hang.HINHANH + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void xoaHang(EC_tb_Sanpham hang)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Sanpham] WHERE  masp=N'" + hang.MASP + "'");
        }

        public void suaHang(EC_tb_Sanpham hang)
        {
            SqlConnection con = cn.getcon();
            try
            {
                con.Open();
                string sql = @"UPDATE    tb_Sanpham
                SET  tensp =N'" + hang.TENSP + "', maloai =N'" + hang.MALOAI + "', giaban =N'" + hang.GIABAN + "',hinhanh ='"+hang.HINHANH+"' where masp=N'" + hang.MASP + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        //load loại
        public void loadmaloai(ComboBox maloai)
        {
            cn.LoadLenCombobox(maloai, "SELECT     maloai FROM tb_Loai", 0);
        }
        public string Loadtenloai(string tenloai, string maloai)
        {
            tenloai = cn.LoadLable("SELECT [tenloai] From [tb_Loai] where maloai= N'" + maloai + "'");
            return tenloai;
        }
        public string LoadGia( string masp)
        {
            string tenloai = cn.LoadLable("SELECT [giaban] From [tb_SanPham] where masp= N'" + masp + "'");
            return tenloai;
        }
        //load công dụng
        public void loadcd(ComboBox macd)
        {
            cn.LoadLenCombobox(macd, "SELECT macongdung FROM tb_Congdung", 0);
        }
        public string Loadtencd(string tenm, string mam)
        {
            tenm = cn.LoadLable("SELECT [tencongdung] From [tb_Congdung] where macongdung= N'" + mam + "'");
            return tenm;
        }
        public int loadGiaSP(string masp)
        {
            int gia = cn.returnscalarnumber("SELECT giaban FROM tb_SanPham WHERE masp = '" + masp + "'");
            return gia;
        }
        public string xuatHinhAnh(string masp)
        {            
            return cn.ExcuteScalar("select hinhanh from tb_Sanpham where masp = '" + masp + "'");
        }
        public DataTable docSanPham()
        {
            return cn.taobang("select * from tb_Sanpham");
        }
        public DataTable timKiemTheoTenSP(string tensp)
        {
            return cn.taobang("select * from tb_Sanpham where tensp LIKE '%" + tensp + "%'");
        }
        public string timKiemMaSPtheoTen(string tensp)
        {
            return cn.ExcuteScalar("select tb_Sanpham.masp from tb_Sanpham where tensp = N'"+tensp+"'");
        }
        public DataTable timKiemTheoLoaiSP(string maloai)
        {
            return cn.taobang("select * from tb_Sanpham where maloai LIKE '%" + maloai + "%'");
        }
        public DataTable timKiemTheoGia(int gia)
        {
            return cn.taobang("select * from tb_Sanpham where giaban = " + gia + "");
        }

        public DataTable timDoanhThuTheoThang(int thang, int nam)
        {
            return cn.taobang(string.Format("exec show_BC_DoanhThu {0},{1}",thang, nam));
        }
    }
}
