using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyCafe.DataAccess;
using System.Data.SqlClient;
using QuanLyCafe.Business.Component;
using QuanLyCafe.Business.EntitiesClass;
namespace QuanLyCafe.Presentation
{
    public partial class fr_TKHDB : Form
    {
        public fr_TKHDB()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();
        E_tb_HDB tbHDB = new E_tb_HDB();
        EC_tb_HDB hdb = new EC_tb_HDB();
        public void khoitaoluoi()
        {
            try
            {
                msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                msds.Columns[0].HeaderText = "Số HDB";
                msds.Columns[0].Frozen = true;
                msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                msds.Columns[0].Width = 130;
                msds.Columns[1].HeaderText = "Ngày Bán";
                msds.Columns[1].Width = 120;
                msds.Columns[2].HeaderText = "Nhân Viên";
                msds.Columns[2].Width = 230;
                msds.Columns[3].HeaderText = "Khách Hàng";
                msds.Columns[3].Width = 120;
                msds.Columns[4].HeaderText = "Tổng Tiền";
                msds.Columns[4].Width = 120;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Chưa có hóa đơn!", ex.Message);
            }

        }
        public void hienthi()
        {            
            msds.DataSource = tbHDB.docHoaDonBan();
        }

        private void txtthongtin_TextChanged(object sender, EventArgs e)
        {
                khoitaoluoi();
            if (txtthongtin.Text == "")
            {
                fr_TKHDB_Load(sender, e);
                return;
            }
            try
            {
                if (op1.Checked)         
                msds.DataSource = tbHDB.timHoaDonTheoMaSP(txtthongtin.Text);
            if (op2.Checked)                
                    msds.DataSource = tbHDB.timHoaDonTheoNgay(txtthongtin.Text);                
            if (op3.Checked)
                msds.DataSource =  tbHDB.timHoaDonTheoMaNV(txtthongtin.Text);
            }
            catch
            {
                fr_TKHDB_Load(sender, e);
            }
        }

        private void fr_TKHDB_Load(object sender, EventArgs e)
        {
            khoitaoluoi();
            msds.DataSource = tbHDB.docHoaDonBan();
        }
    }
}
