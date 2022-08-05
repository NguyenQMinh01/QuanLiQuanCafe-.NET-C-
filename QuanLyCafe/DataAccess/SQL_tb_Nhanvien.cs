using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCafe.Business.EntitiesClass;
using System.Windows.Forms;

namespace QuanLyCafe.DataAccess
{
    class SQL_tb_Nhanvien
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtranv(string manv)
        {
            return cn.kiemtra("select count(*) from [tb_Nhanvien] where manv=N'" + manv + "'");
        }
        public void themmoinv(EC_tb_Nhanvien nv)
        {
            string sql = @"INSERT INTO tb_Nhanvien
                      (manv, tennv, diachi, gioitinh, ngaysinh, tenque, sdt,Passwords,quyen)
                        VALUES   (N'" + nv.MANV + "',N'" + nv.TENNV + "',N'" + nv.DIACHI + "',N'" + nv.GIOITINH + "',N'" + nv.NGAYSINH + "',N'" + nv.TENQUE + "',N'" + nv.SDT + "','" + nv.PASSWORD + "','" + nv.QUYEN + "')";
            cn.ExcuteNonQuery(sql);
        }
        public void xoanv(EC_tb_Nhanvien nv)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Nhanvien] WHERE manv=N'" + nv.MANV + "'");
        }

        public void suanv(EC_tb_Nhanvien nv)
        {
            string sql = (@"UPDATE    tb_Nhanvien
                    SET tennv =N'" + nv.TENNV + "', gioitinh =N'" + nv.GIOITINH + "', ngaysinh =N'" + nv.NGAYSINH + "', sdt =N'" + nv.SDT + "', diachi =N'" + nv.DIACHI + "',tenque =N'" + nv.TENQUE + "',sdt =N'" + nv.SDT + "' ,Passwords =N'" + nv.PASSWORD + "',Quyen =N'" + nv.QUYEN + "'   where manv=N'" + nv.MANV + "'");
            cn.ExcuteNonQuery(sql);
        }
        //load quê
        public void loadmaque(ComboBox maq)
        {
            cn.LoadLenCombobox(maq, "SELECT     maque FROM tb_Que", 0);
        }
        public string Loadtenq(string tenq, string maq)
        {
            tenq = cn.LoadLable("SELECT [tenque] From [tb_Que] where maque= N'" + maq + "'");
            return tenq;
        }

        public bool Kiemtrauser(EC_tb_Nhanvien nv)
        {
            string sql = "select count(*) from tb_NhanVien where manv ='" + nv.MANV + "' and Passwords = '" + nv.PASSWORD + "'";
            return cn.KiemtraUsername(sql);
        }
        public string timTenNV(string manv)
        {
            return cn.ExcuteScalar("select tennv from tb_Nhanvien where manv = '" + manv + "'");
        }
    }
}
