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
    class E_tb_CTHDN
    {
        SQL_tb_CTHDN cthdnsql = new SQL_tb_CTHDN();
        public void themoicthdn(EC_tb_CTHDN cthdn)
        {
            if (!cthdnsql.kiemtratb_CTHDN(cthdn.MAHDN, cthdn.MASP))
            {
                cthdnsql.themmoicthdn(cthdn);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suacthdn(EC_tb_CTHDN cthdn)
        {
            cthdnsql.suacthdn(cthdn);
        }
        public void updateCThdn(EC_tb_CTHDN cthdn)
        {
            cthdnsql.updateCTHDN(cthdn);
        }
        public void xoacthdn(EC_tb_CTHDN cthdn)
        {
            cthdnsql.xoacthdn(cthdn);
        }
        //load hóa đơn
        public void loadmacthdn(ComboBox cbhd)
        {
            cthdnsql.loadmacthdn(cbhd);
        }
        //load hóa đơn
      
        public string loadtensp(string Tensp, string Masp)
        {
            Tensp = cthdnsql.Loadtenhang(Tensp, Masp);
            return Tensp;
        }


        public void loadmaNL(ComboBox cbnl)
        {
            cthdnsql.loadmaNL(cbnl);
        }

        public DataTable docThongTinCTHoaDonNhap(string mahdn)
        {
            return cthdnsql.docThongTinCChungCTHDN(mahdn);
        }
        public string laymatop1CTHDN(string mahdn)
        {
            return cthdnsql.laymaCTHoaDonNhapMax(mahdn);
        }
    }
}
