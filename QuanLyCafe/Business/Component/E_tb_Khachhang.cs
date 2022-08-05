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
    class E_tb_Khachhang
    {
        SQL_tb_Khachhang khsql = new SQL_tb_Khachhang();
        public void themoikh(EC_tb_Khachhang kh)
        {
            if (!khsql.kiemtra(kh.MAKH))
            {
                khsql.themmoi(kh);
            }
            else
            {
               DialogResult result = MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               if (result == DialogResult.OK)
               {
                   return;
               }
               else
               {
               }
            }
        }
        public void suakh(EC_tb_Khachhang kh)
        {
            khsql.sua(kh);
        }
        public void xoakh(EC_tb_Khachhang kh)
        {
            khsql.xoa(kh);
        }
        public string timMakh (string tenkh)
        {
            return khsql.timMaKH(tenkh);
        }
        public DataTable docKhachHang()
        {
            return khsql.docKhachHang();
        }
        public string timTenKH(string makh)
        {
            return khsql.timTenKH(makh);
        }

        public string timMaKHNULL(string makh)
        {
            return khsql.laymaKhachHangNULL(makh);
        }

        public string timTenKHNULL(string tenkh)
        {
            return khsql.laytenKhachHangNULL(tenkh);
        }
    } 
}
