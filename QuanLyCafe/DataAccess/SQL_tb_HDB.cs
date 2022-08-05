using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCafe.Business.EntitiesClass;
using System.Windows.Forms;
using System.Data;

namespace QuanLyCafe.DataAccess
{
    class SQL_tb_HDB
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtraHDB(string mahdb)
        {
            return cn.kiemtra("select count(*) from [tb_HDB] where mahdb=N'" + mahdb + "'");
        }
        public void themmoiHDB(EC_tb_HDB hdb)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_HDB
                      (ngayban, manv, makh, tongtien, maban) VALUES   ('" + hdb.NGAYBAN + "','" + hdb.MANV + "','" + hdb.MAKH + "'," + hdb.TONGTIEN + ", " + hdb.MABAN + ")");
        }
        public void xoaHDB(EC_tb_HDB hdb)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_HDB] WHERE [mahdb] = N'" + hdb.MAHDB + "'");
        }

        public void deleteHDBtheoma(string hdb)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_HDB] WHERE [mahdb] = N'" + hdb + "'");
        }

        public void suaHDB(EC_tb_HDB hdb)
        {
            string sql = (@"UPDATE tb_HDB
            SET manv =N'" + hdb.MANV + "',ngayban =N'" + hdb.NGAYBAN + "',makh =N'" + hdb.MAKH + "' where  mahdb =N'" + hdb.MAHDB + "'");
            cn.ExcuteNonQuery(sql);
        }
        //load nhân viên
        public void loadmanv(ComboBox manv)
        {
            cn.LoadLenCombobox(manv, "SELECT     manv FROM tb_Nhanvien", 0);
        }
        public string Loadtennv(string tennv, string manv)
        {
            tennv = cn.LoadLable("SELECT [tennv] From [tb_Nhanvien] where manv= N'" + manv + "'");
            return tennv;
        }
        //load mã khách hàng
        public void loadmakhach(ComboBox mak)
        {
            cn.LoadLenCombobox(mak, "SELECT     makh FROM tb_Khachhang", 0);
        }
        public string Loadtenkhach(string tenk, string mak)
        {
            tenk = cn.LoadLable("SELECT [tenkh] From [tb_Khachhang] where makh= N'" + mak + "'");
            return tenk;
        }
        public DataTable docHoaDonBan()
        {
            return cn.taobang("select mahdb , ngayban, manv,makh,FORMAT(tongtien, '#,0.00' ) as tongtien, maban from tb_HDB");
        }

        public DataTable docThongTinHoaDonBan(string mahdb)
        {
            return cn.taobang("SELECT tb_HDB.mahdb, tb_Khachhang.tenkh,tb_HDB.ngayban, tb_Nhanvien.tennv FROM  tb_CTHDB INNER tb_HDB ON tb_CTHDB.mahdb = tb_HDB.mahdb INNER tb_Khachhang ON tb_HDB.makh = tb_Khachhang.makh INNER tb_Nhanvien ON tb_HDB.manv = tb_Nhanvien.manv where tb_HDB.mahdb = '" +mahdb + "'");
        }

        public DataTable timHoaDonTheoMaSP(string masp)
        {
            return cn.taobang("select * from tb_HDB,tb_CTHDB where tb_HDB.mahdb = tb_CTHDB.mahdb AND masp LIKE '%" + masp + "%'");
        }
        public DataTable timHoaDonTheoMaNV(string manv)
        {
            return cn.taobang("select * from tb_HDB where manv LIKE '%" + manv + "%'");
        }
        public DataTable timHoaDonTheoNgay(string ngay)
        {
            return cn.taobang("select * from tb_HDB where ngayban = '" + ngay + "'");
        }
        public string timMaHoaDonTheoBan(int ban)
        {            
            return cn.ExcuteScalar("select mahdb from tb_HDB, tb_Ban where tb_Ban.maban = tb_HDB.maban and tb_Ban.maban = " + ban + " and TrangThai = 1 ");
        }
        public string hienMaHoaDonBanTheoBan(int ban)
        {
            return cn.ExcuteScalar("select TOP 1 tb_HDB.mahdb from tb_HDB,tb_Ban where tb_HDB.maban = " + ban + " and tb_Ban.TrangThai = 1 order by tb_HDB.mahdb DESC");
        }

        public string laymaHoaDonBanMax()
        {
            return cn.ExcuteScalar("select top 1 mahdb from tb_HDB Order by tb_HDB.mahdb Desc");
        }

        public string laymaKhachHangTheoMaHoaDon(string mahd)
        {
            return cn.ExcuteScalar("select makh from tb_HDB where tb_HDB.mahdb = '" + mahd + "'");
        }

        

        public string layTongTien(string mahdb)
        {
            string sql = (@"Select tongtien from tb_HDB WHERE tb_HDB.mahdb = " + mahdb + "");
            return cn.ExcuteScalar(sql);
        }


        public void updateHDB(string mahdb)
        {
            string sql = (@"UPDATE tb_HDB SET tongtien = (select SUM(thanhtien) from tb_CTHDB,tb_Sanpham where tb_CTHDB.mahdb = " + mahdb + " and tb_CTHDB.masp = tb_Sanpham.masp) WHERE tb_HDB.mahdb = " + mahdb + "");
            cn.ExcuteNonQuery(sql);
        }
        public void chuyenBan(string mahdb,string maban)
        {
            string sql = (@"UPDATE tb_HDB SET maban = "+maban+" where mahdb = "+mahdb+"");
            cn.ExcuteNonQuery(sql);
        }
        public string kiemtraSLTon(string maSP)
        {
            string sql = (@"select soluong from tb_Nguyenlieu where tb_Nguyenlieu.MaNL = (select MaNL from tb_Sanpham where masp = '"+maSP+"')");
            return cn.ExcuteScalar(sql);
        }


        //code this

    }
}
