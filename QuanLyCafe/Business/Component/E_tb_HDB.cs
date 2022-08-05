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
    class E_tb_HDB
    {
        SQL_tb_HDB hdbsql = new SQL_tb_HDB();
        public void themoihdb(EC_tb_HDB hdb)
        {
            if (!hdbsql.kiemtraHDB(hdb.MAHDB))
            {
                hdbsql.themmoiHDB(hdb);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suahdb(EC_tb_HDB hdb)
        {
            hdbsql.suaHDB(hdb);
        }


        public void deleteHDBtheoma(string hdb)
        {
            hdbsql.deleteHDBtheoma(hdb);
        }
        public void xoahdb(EC_tb_HDB hdb)
        {
            hdbsql.xoaHDB(hdb);
        }
        //load nv
        public void loadmanv(ComboBox cbnv)
        {
            hdbsql.loadmanv(cbnv);
        }
        public string loadtennv(string Tennv, string Manv)
        {
            Tennv = hdbsql.Loadtennv(Tennv, Manv);
            return Tennv;
        }
        //load khách
        public void loadmakh(ComboBox cbkh)
        {
            hdbsql.loadmakhach(cbkh);
        }
        public string loadtenkh(string Tenk, string Mak)
        {
            Tenk = hdbsql.Loadtenkhach(Tenk, Mak);
            return Tenk;
        }
        public DataTable docHoaDonBan()
        {
            return hdbsql.docHoaDonBan();
        }

        public DataTable docThongTinHoaDonBan(string mahdb)
        {
            return hdbsql.docThongTinHoaDonBan(mahdb);
        }
        public DataTable timHoaDonTheoNgay(string ngay)
        {
            return hdbsql.timHoaDonTheoNgay(ngay);
        }
        public DataTable timHoaDonTheoMaSP(string MaSP)
        {
            return hdbsql.timHoaDonTheoMaSP(MaSP);
        }
        public DataTable timHoaDonTheoMaNV(string MaNV)
        {
            return hdbsql.timHoaDonTheoMaNV(MaNV);
        }
        public string timMaHoaDonTheoBan(int ban)
        {
            return hdbsql.timMaHoaDonTheoBan(ban);
        }

        public string timMaHoaDonTop1()
        {
            return hdbsql.laymaHoaDonBanMax();
        }

        public string timMaKhachHang(string mahd)
        {
            return hdbsql.laymaKhachHangTheoMaHoaDon(mahd);
        }

        public string layHoaDonTheoBan(int ban)
        {
            return hdbsql.hienMaHoaDonBanTheoBan(ban);
        }

        public void updateHDB(string mahdb)
        {
            hdbsql.updateHDB(mahdb);
        }
        public void chuyenBan(string mahdb, string maban)
        {
            hdbsql.chuyenBan(mahdb, maban);
        }
        public string layTongTien(string mahdb)
        {
            return hdbsql.layTongTien(mahdb);
        }
        public string kiemTraSLTon(string maSP)
        {
            return hdbsql.kiemtraSLTon(maSP);
        }

      
    }

}
