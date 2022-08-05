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
    public partial class fr_NCC : Form
    {
        LinqCafeDataContext db = new LinqCafeDataContext();
        public fr_NCC()
        {
            InitializeComponent();
        }
        E_tb_NCC thucthi = new E_tb_NCC();
        ConnectDB cn = new ConnectDB();
        EC_tb_NCC ck = new EC_tb_NCC();
        bool themmoi;
        int dong = 0;

        public void setnull()
        {
            txtma.Text = "";
            txtten.Text = "";
            txtdt.Text = "";
            txtdc.Text = "";
        }
        public void locktext()
        {
            txtma.Enabled = false;
            txtten.Enabled = false;
            txtdc.Enabled = false;
            txtdt.Enabled = false;

            btmoi.Enabled = true;
            btluu.Enabled = false;
            btsua.Enabled = true;
            btxoa.Enabled = true;
        }
        public void un_locktext()
        {
            txtma.Enabled = true;
            txtten.Enabled = true;
            txtdc.Enabled = true;
            txtdt.Enabled = true;

            btmoi.Enabled = false;
            btluu.Enabled = true;
            btsua.Enabled = false;
            btxoa.Enabled = false;
        }
        public void khoitaoluoi()
        {
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Mã NCC";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 100;
            msds.Columns[1].HeaderText = "Tên NCC";
            msds.Columns[1].Width = 200;
            msds.Columns[2].HeaderText = "Địa Chỉ";
            msds.Columns[2].Width = 200;
            msds.Columns[3].HeaderText = "Điện Thoại";
            msds.Columns[3].Width = 200;

        }
        public void hienthi()
        {
            string sql = "SELECT     mancc, tenncc, diachi, sdt FROM tb_NCC";
            msds.DataSource = cn.taobang(sql);
            SqlConnection con = cn.getcon();
            con.Open();
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            finally
            {
                con.Close();
            }
        }
        private void btmoi_Click(object sender, EventArgs e)
        {
            themmoi = true;
            un_locktext();
            setnull();
            txtma.Enabled = true;
            txtma.Focus();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            int m = 0;
            int u = 0;
            try
            {
                m = Convert.ToInt32(txtdt.Text);
                u = Int32.Parse(txtdt.Text.Trim());
            }
            catch (Exception)
            {
                txtTrangThai.Text = "Sửa không thành công";
                return;
                txtdt.Focus();
            }

            if (txtten.Text == "")
            {
                txtTrangThai.Text = "Tên không được để trống";
                return;
                txtten.Focus();
            }
            
            if (txtma.Text != "")
            {
                if (themmoi == true)
                {
                    try
                    {
                        tb_NCC ncc = new tb_NCC();
                        ncc.MaNCC = txtma.Text;
                        ncc.TenNCC = txtten.Text;
                        ncc.diachi = txtdc.Text;
                        ncc.sdt = txtdt.Text;
                        db.tb_NCCs.InsertOnSubmit(ncc);
                        db.SubmitChanges();
                        var tb_NCC = from ncc1 in db.tb_NCCs
                                     select ncc1;
                        msds.DataSource = tb_NCC;
                        locktext();
                        hienthi();
                        MessageBox.Show("Đã Lưu Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    try
                    {
                        string mancc = msds.CurrentRow.Cells[0].Value.ToString();
                        tb_NCC ncc = db.tb_NCCs.Where(t => t.MaNCC == mancc).FirstOrDefault();
                        ncc.MaNCC = txtma.Text;
                        ncc.TenNCC = txtten.Text;
                        ncc.diachi = txtdc.Text;
                        ncc.sdt = txtdt.Text;
                        db.SubmitChanges();
                        var tb_NCC = from ncc1 in db.tb_NCCs
                                     select ncc1;
                        msds.DataSource = tb_NCC;
                        txtTrangThai.Text = "Sửa thành công";
                        //MessageBox.Show("Đã Sửa Thành Công Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    string mancc = msds.CurrentRow.Cells[0].Value.ToString();
                    tb_NCC ncc = db.tb_NCCs.Where(t => t.MaNCC == mancc).FirstOrDefault();
                    db.tb_NCCs.DeleteOnSubmit(ncc);
                    db.SubmitChanges();
                    var tb_NCC = from ncc1 in db.tb_NCCs
                                 select ncc1;
                    msds.DataSource = tb_NCC;
                    MessageBox.Show("Đã Xóa Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienthi();
                    setnull();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }
        private void fr_NCC_Load(object sender, EventArgs e)
        {
            var nccs = from mancc in db.tb_NCCs
                       select mancc;
            msds.DataSource = nccs;

            txtma.Text = "NCC1";
            txtdc.Enabled = false;
            txtma.Enabled = false;
            txtten.Enabled = false;
            txtdt.Enabled = false;
        }

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            try
            {
                txtma.Text = msds.Rows[dong].Cells[0].Value.ToString();
                txtten.Text = msds.Rows[dong].Cells[1].Value.ToString();
                txtdc.Text = msds.Rows[dong].Cells[2].Value.ToString();
                txtdt.Text = msds.Rows[dong].Cells[3].Value.ToString();
                locktext();
            }
            catch (Exception ex)
            {

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
