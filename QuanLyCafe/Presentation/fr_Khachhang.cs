using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyCafe.Business.Component;
using QuanLyCafe.Business.EntitiesClass;
using QuanLyCafe.DataAccess;

namespace QuanLyCafe.Presentation
{
    public partial class fr_Khachhang : Form
    {
        public fr_Khachhang()
        {
            InitializeComponent();
        }
        E_tb_Khachhang thucthi = new E_tb_Khachhang();
        ConnectDB cn = new ConnectDB();
        EC_tb_Khachhang ck = new EC_tb_Khachhang();
        bool themmoi;
        int dong = 0;

        public void setnull()
        {
            txtma.Text = "";
            txtten.Text = "";
            
        }
        public void locktext()
        {
            txtma.Enabled = false;
            txtten.Enabled = false;

            btmoi.Enabled = true;
            btluu.Enabled = false;
            btsua.Enabled = true;
            btxoa.Enabled = true;
        }
        public void un_locktext()
        {
            txtma.Enabled = true;
            txtten.Enabled = true;

            btmoi.Enabled = false;
            btluu.Enabled = true;
            btsua.Enabled = false;
            btxoa.Enabled = false;
        }
        public void khoitaoluoi()
        {
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Mã KH";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 150;
            msds.Columns[1].HeaderText = "Tên KH";
            msds.Columns[1].Width = 200;

        }
        public void hienthi()
        {            
            msds.DataSource = thucthi.docKhachHang();
            SqlConnection con = cn.getcon();
            con.Open();
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            //txtTrangThai.Focus();
        }
        private void btmoi_Click(object sender, EventArgs e)
        {
            themmoi = true;
            un_locktext();
            setnull();
            txtma.Enabled = true;
            txtma.Focus();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            un_locktext();
            txtma.Enabled = false;
            txtten.Focus();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa dữ liệu này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ck.MAKH = txtma.Text;

                    thucthi.xoakh(ck);
                    MessageBox.Show("Đã Xóa Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienthi();
                    setnull();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
            }
        }
        private void fr_Khachhang_Load(object sender, EventArgs e)
        {
            txtTrangThai.Focus();
            locktext();
            hienthi();
            khoitaoluoi();
            if (Data.trangThai == 0)
            {
                button1.Enabled = false;
            }
            else
                button1.Enabled = true;
        }

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            try
            {
                txtma.Text = msds.Rows[dong].Cells[0].Value.ToString();
                txtten.Text = msds.Rows[dong].Cells[1].Value.ToString();
                locktext();
            }
            catch (Exception ex)
            {

            }
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (txtma.Text != "")
            {
                if (themmoi == true)
                {
                    try
                    {
                        ck.MAKH = txtma.Text;
                        ck.TENKH = txtten.Text;
                        ck.Sdt = txtSDT.Text;

                        
                        
                        thucthi.themoikh(ck);
                        locktext();
                        hienthi();

                        txtTrangThai.Text = "Thêm Thành công";
                        //MessageBox.Show("Đã Lưu Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    try
                    {
                        ck.MAKH = txtma.Text;
                        ck.TENKH = txtten.Text;
                        ck.Sdt = txtSDT.Text;
                        
                        thucthi.suakh(ck);
                        txtTrangThai.Text = "Thêm Thất bại";
                       // MessageBox.Show("Đã Sửa Thành Công Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                txtma.Enabled = true;
                locktext();
                hienthi();
            }
            else
            {
                MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                txtma.Focus();
            }
        }

        private void msds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.frmBna.gsmaKH = txtma.Text;
            Data.frmBna.gsTen = txtten.Text;
            this.Dispose();
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
