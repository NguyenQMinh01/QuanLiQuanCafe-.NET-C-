using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCafe.Business.EntitiesClass;
using QuanLyCafe.DataAccess;
using System.Windows.Forms;
using System.Data;

namespace QuanLyCafe.Business.Component
{
    class E_tb_Sanpham
    {
        SQL_tb_Sanpham spsql = new SQL_tb_Sanpham();
        public void themoi(EC_tb_Sanpham lg)
        {
            if (!spsql.kiemtraHang(lg.MASP))
            {
                spsql.themmoiHang(lg);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            
        }
        public void sua(EC_tb_Sanpham lg)
        {
            spsql.suaHang(lg);
        }
        public void xoa(EC_tb_Sanpham lg)
        {
            spsql.xoaHang(lg);
        }
        //load công việc
        public void loadmal(ComboBox cbl)
        {
            spsql.loadmaloai(cbl);
        }
        public string loadtenl(string Tenl, string Mal)
        {
            Tenl = spsql.Loadtenloai(Tenl, Mal);
            return Tenl;
        }
        //load loại
        public void loadmacd(ComboBox cbcd)
        {
            spsql.loadcd(cbcd);
        }
        public string loadtencd(string Tencd, string Macd)
        {
            Tencd = spsql.Loadtencd(Tencd, Macd);
            return Tencd;
        }
        public string loadGia(string masp)
        {
            string gia = spsql.LoadGia(masp);
            return gia;
        }
        public int loadGiaBan(string masp)
        {
            return spsql.loadGiaSP(masp);
        }
        public string xuatHinhAnh(string masp)
        {
            return spsql.xuatHinhAnh(masp);
        }
        public DataTable docSanPham()
        {
            return spsql.docSanPham();
        }
        public DataTable timKiemSanPhamTheoTen(string tensp)
        {
            return spsql.timKiemTheoTenSP(tensp);
        }
        public DataTable timKiemSanPhamTheoLoai(string maloai)
        {
            return spsql.timKiemTheoLoaiSP(maloai);
        }
        public DataTable timKiemSanPhamTheoGia(int gia)
        {
            return spsql.timKiemTheoGia(gia);
        }
        public string timkiemMaSptheoTen(string ten)
        {
            return spsql.timKiemMaSPtheoTen(ten);
        }

        public DataTable timDoanhThuTheoThang(int thang, int nam)
        {
            return spsql.timDoanhThuTheoThang(thang,nam);
        }
    }
}
