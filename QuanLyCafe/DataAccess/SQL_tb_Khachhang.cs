using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCafe.Business.EntitiesClass;
using System.Data;

namespace QuanLyCafe.DataAccess
{
    class SQL_tb_Khachhang
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtra(string makh)
        {
            return cn.kiemtra("select count(*) from [tb_Khachhang] where makh=N'" + makh + "'");
        }
        public void themmoi(EC_tb_Khachhang q)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_Khachhang
                      (makh, tenkh,sdt) VALUES   (N'" + q.MAKH + "',N'" + q.TENKH + "',"+q.Sdt+")");
        }
        public void xoa(EC_tb_Khachhang q)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Khachhang] WHERE [makh] = N'" + q.MAKH + "'");
        }

        public void sua(EC_tb_Khachhang q)
        {
            string sql = (@"UPDATE tb_Khachhang
            SET tenkh =N'" + q.TENKH + "' where  makh =N'" + q.MAKH + "'");
            cn.ExcuteNonQuery(sql);
        }
        public string timMaKH(string tenkh)
        {
            return cn.ExcuteScalar("select makh from tb_Khachhang where tenkh = N'" + tenkh + "'");
        }

        public string laymaKhachHangNULL(string makh)
        {
            return cn.ExcuteScalar("select makh from tb_Khachhang where makh = N'"+makh+"'");
        }

        public string laytenKhachHangNULL(string tenkh)
        {
            return cn.ExcuteScalar("select tenkh from tb_Khachhang where makh = N'" + tenkh + "'");
        }

        public DataTable docKhachHang()
        {
            return cn.taobang("select * from tb_Khachhang");
        }
        public string timTenKH(string makh)
        {
            return cn.ExcuteScalar("select tenkh from tb_Khachhang where makh = '" + makh + "'");
        }
    }
}
