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
    public partial class fr_Kho : Form
    {

        E_tb_Kho thucthi = new E_tb_Kho();
        ConnectDB cn = new ConnectDB();
        EC_tb_Kho ck = new EC_tb_Kho();
        bool themmoi;
        int dong = 0;
        public fr_Kho()
        {
            InitializeComponent();
        }


        public void setnull()
        {
            txtmaNL.Text = "";
            txttenNL.Text = "";
            txtSL.Text = "";
        }
        public void locktext()
        {
            txtmaNL.Enabled = false;
            txttenNL.Enabled = false;
            txtSL.Enabled = false;
            btmoi.Enabled = true;
            btluu.Enabled = false;
            btsua.Enabled = true;
            btxoa.Enabled = true;
        }
        public void un_locktext()
        {
            txtmaNL.Enabled = true;
            txttenNL.Enabled = true;
            txtSL.Enabled = true;
            btmoi.Enabled = false;
            btluu.Enabled = true;
            btsua.Enabled = false;
            btxoa.Enabled = false;
        }
        public void khoitaoluoi()
        {
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Mã Nguyên Liệu";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 150;
            msds.Columns[1].HeaderText = "Tên Nguyên Liệu";
            msds.Columns[1].Width = 200;
            msds.Columns[2].HeaderText = "Số Lượng";
            msds.Columns[2].Width = 100;

        }
        public void hienthi()
        {
            msds.DataSource = thucthi.docnguyenlieu();
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
        }
   

        private void btxoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Xóa dữ liệu này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ck.MALOAI = txtmaNL.Text;

                    thucthi.xoak(ck);
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

        private void fr_Kho_Load(object sender, EventArgs e)
        {
            locktext();
            hienthi();
            khoitaoluoi();
        }

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dong = e.RowIndex;
                txtmaNL.Text = msds.Rows[dong].Cells[0].Value.ToString();
                txttenNL.Text = msds.Rows[dong].Cells[1].Value.ToString();
                txtSL.Text = msds.Rows[dong].Cells[2].Value.ToString();
                locktext();
            }
            catch
            {
            }
        }

        private void btmoi_Click(object sender, EventArgs e)
        {
            themmoi = true;
            un_locktext();
            setnull();
            txtmaNL.Enabled = true;
            txtmaNL.Focus();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            un_locktext();
            txtmaNL.Enabled = false;
            txttenNL.Focus();
        }

        private void btluu_Click(object sender, EventArgs e)
        {

            if (txtmaNL.Text != "")
            {
                if (themmoi == true)
                {
                    try
                    {
                        ck.MALOAI = txtmaNL.Text;
                        ck.TENLOAI = txttenNL.Text;
                        ck.Soluong = int.Parse(txtSL.Text);
                        thucthi.themoik(ck);
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
                        ck.MALOAI = txtmaNL.Text;
                        ck.TENLOAI = txttenNL.Text;
                        ck.Soluong = int.Parse(txtSL.Text);
                        thucthi.suak(ck);
                        MessageBox.Show("Đã Sửa Thành Công Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                string upsl = "UPDATE tb_Nguyenlieu SET soluong = '" + txtSL.Text + "' where MaNL='" + txtmaNL.Text + "'";
                cn.ExcuteNonQuery(upsl);
                
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

        private void msds_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //dong = e.RowIndex;
            //fr_CTHDN fr = new fr_CTHDN();

            //this.Close();
            //fr.Show();
        }
    }
}
