using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCafe.Business.EntitiesClass;
using System.Data;

namespace QuanLyCafe.DataAccess
{
    class SQL_tb_Kho
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtra(string manguyenlieu)
        {
            return cn.kiemtra("select count(*) from [tb_Nguyenlieu] where MaNL=N'" + manguyenlieu + "'");
        }
        public void themmoikho(EC_tb_Kho q)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_Nguyenlieu
                      (MaNL, TenNL,soluong) VALUES   (N'" + q.MALOAI + "',N'" + q.TENLOAI + "',"+ q.Soluong+")");
        }
        public void xoa(EC_tb_Kho q)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Nguyenlieu] WHERE [MaNL] = N'" + q.MALOAI + "'");
        }

        public void sua(EC_tb_Kho q)
        {
            string sql = (@"UPDATE tb_Nguyenlieu
            SET TenNL =N'" + q.TENLOAI + "', soluong ="+q.Soluong+", where  MaNL =N'" + q.MALOAI + "'");
            cn.ExcuteNonQuery(sql);
        }
        public DataTable docNguyenlieu()
        {
            return cn.taobang("select * from tb_Nguyenlieu");
        }
    }
}
