using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCafe.Business.Component;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyCafe.DataAccess
{
    class SQL_tb_Ban
    {
        ConnectDB cn = new ConnectDB();
        
        public void suaBan(int maban,int trangThai)
        {
            
            string sql = "update tb_Ban set TrangThai = " + trangThai + " where maban = " + maban + "";
             cn.ExcuteNonQuery(sql);
        }
        public bool xuatTrangThi(string maban)
        {
            SqlCommand sql = new SqlCommand();
            bool kq = cn.returnscalarbool( "select TrangThai from tb_Ban where maban = '" + maban + "'");
            return kq;
        }
    }
}
