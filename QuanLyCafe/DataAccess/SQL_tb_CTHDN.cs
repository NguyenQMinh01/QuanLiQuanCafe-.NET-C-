using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCafe.Business.EntitiesClass;
using System.Windows.Forms;
using System.Data;


namespace QuanLyCafe.DataAccess
{
    class SQL_tb_CTHDN
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtratb_CTHDN(string macthdn, string MaNL)
        {
            return cn.kiemtra("select count(*) from [tb_CTHDN] where macthdn=N'" + macthdn + "'and MaNL=N'" + MaNL + "'");
            
        }
        public void themmoicthdn(EC_tb_CTHDN cthdn)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_CTHDN
                      (macthdn,mahdn, MaNL, soluong, thanhtien, khuyenmai) VALUES   (N'" + cthdn.MACTHDN + "','" + cthdn.MAHDN + "',N'" + cthdn.MASP + "',N'" + cthdn.SOLUONG + "',N'" + cthdn.THANHTIEN + "',N'" + cthdn.KHUYENMAI + "')");
        }
        public void xoacthdn(EC_tb_CTHDN cthdn)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_CTHDN] WHERE  macthdn=N'" + cthdn.MACTHDN + "' and MaNL=N'" + cthdn.MASP + "' and mahdn = '"+cthdn.MAHDN+"' ");
        }

        public void suacthdn(EC_tb_CTHDN cthdn)
        {
            string sql = (@"UPDATE tb_CTHDN
            SET soluong ='" + cthdn.SOLUONG + "', khuyenmai = '" + cthdn.KHUYENMAI + "', thanhtien = '" + cthdn.THANHTIEN + "' where macthdn ='"+cthdn.MACTHDN+"' and mahdn='" + cthdn.MAHDN + "' and MaNL=N'" + cthdn.MASP + "'");
            cn.ExcuteNonQuery(sql);
        }

        public void updateCTHDN(EC_tb_CTHDN cthdn)
        {
            string sql = (@"UPDATE tb_CTHDN
            SET MaNL = '"+ cthdn.MASP +"',soluong =N'" + cthdn.SOLUONG + "', khuyenmai = N'" + cthdn.KHUYENMAI + "', thanhtien = N'" + cthdn.THANHTIEN + "' where  macthdn=N'" + cthdn.MAHDN + "' and mahdn=N'" + cthdn.DONGIA + "'");
            cn.ExcuteNonQuery(sql);
        }
        //load sp

        public void loadmaNL(ComboBox manl)
        {
            cn.LoadLenCombobox(manl, "SELECT MaNL FROM tb_Nguyenlieu", 0);
        }

        public string Loadtenhang(string tenhang, string MaNL)
        {
            tenhang = cn.LoadLable("SELECT [MaNL] From [tb_Sanpham] where MaNL= N'" + MaNL + "'");
            return tenhang;
        }
        //load THD
        public void loadmacthdn(ComboBox macthdn)
        {
            cn.LoadLenCombobox(macthdn, "SELECT  macthdn FROM tb_CTHDN ", 0);
        }
        //load đơn giá bán
        public string Loaddgb(string dg, string MaNL)
        {
            dg = cn.LoadLable("SELECT [gianhap] From [tb_Sanpham] where MaNL= N'" + MaNL + "'");
            return dg;
        }

         public DataTable docThongTinCChungCTHDN(string mahdn)
        {
            return cn.taobang(string.Format("exec show_BC_HDNhap {0}", mahdn));
        }

         public string laymaCTHoaDonNhapMax(string mahdn)
         {
             return cn.ExcuteScalar("select count(*) from tb_CTHDN where mahdn ="+mahdn+" ");
         }

        
    }
}
