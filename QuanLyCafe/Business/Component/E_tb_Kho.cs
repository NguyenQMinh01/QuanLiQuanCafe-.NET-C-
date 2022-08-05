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
    class E_tb_Kho
    {

        SQL_tb_Kho ksql = new SQL_tb_Kho();
        public void themoik(EC_tb_Kho k)
        {
            if (!ksql.Equals(k.MALOAI))
            {
                ksql.themmoikho(k);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suak(EC_tb_Kho k)
        {
            ksql.sua(k);
        }
        public void xoak(EC_tb_Kho k)
        {
            ksql.xoa(k);
        }
        public DataTable docnguyenlieu()
        {
            return ksql.docNguyenlieu();
        }
    }
}
