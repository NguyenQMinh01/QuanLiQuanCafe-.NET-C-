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
using System.IO;

namespace QuanLyCafe.Presentation
{
    public partial class fr_Sanpham : Form
    {
        public fr_Sanpham()
        {
            InitializeComponent();
        }
        E_tb_Sanpham thucthi = new E_tb_Sanpham();
        ConnectDB cn = new ConnectDB();
        EC_tb_Sanpham ck = new EC_tb_Sanpham();
        bool themmoi;
        int dong = 0;


        private byte[] hinhanh;
        public byte[] HINHANH
        {
            get
            {
                return hinhanh;
            }
            set
            {
                hinhanh = value;
            }
        }
        public void setnull()
        {
            txtma.Text = "";
            txtten.Text = "";
            txtdgb.Text = "0";

            txtngay.Text = "";
            //imghinhanh.Image = QuanLyCuaHangTivi.Properties.Resources.no;
        }
        public void locktext()
        {
            txtma.Enabled = false;
            txtten.Enabled = false;
            txtngay.Enabled = false;


            btmoi.Enabled = true;
            btluu.Enabled = false;
            btsua.Enabled = true;
            btxoa.Enabled = true;
            //imghinhanh.Image = Image.FromFile(@"../../Resources/Close.png");
        }
        public void un_locktext()
        {
            txtma.Enabled = true;
            txtten.Enabled = true;
            txtngay.Enabled = true;

            btmoi.Enabled = false;
            btluu.Enabled = true;
            btsua.Enabled = false;
            btxoa.Enabled = false;
        }
        public void khoitaoluoi()
        {
            //RepositoryItemPictureEdit image = msds.RepositoryItems.Add("PictureEdit") as RepositoryItemPictureEdit;            
            Font font = new Font("Microsoft Sans Serif", 15);
            msds.Font = font;

            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Mã Sản Phẩm";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 100;

            msds.Columns[1].HeaderText = "Tên Sản Phẩm";
            msds.Columns[1].Width = 200;

            msds.Columns[2].HeaderText = "Mã Loại";
            msds.Columns[2].Width = 50;

            msds.Columns[3].HeaderText = "Giá Bán";
            msds.Columns[3].Width = 200;


            msds.Columns[4].HeaderText = "Ảnh";
            msds.Columns[4].Width = 200;

        }
        public void hienthi()
        {

            msds.DataSource = thucthi.docSanPham();
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
        private void btmoi_Click(object sender, EventArgs e)
        {
            themmoi = true;
            un_locktext();
            setnull();
            txtma.Enabled = true;
            txtma.Focus();
            imghinhanh.Image = Image.FromFile(@"../../Resources/Close.png");

        }
        private void btluu_Click(object sender, EventArgs e)
        {
            int txt = 0;
            int u = 0;
            try
            {
                txt = Convert.ToInt32(txtdgb.Text);
                u = Int32.Parse(txtdgb.Text.Trim());


            }
            catch (Exception)
            {
                MessageBox.Show("gia tri phai nhap la so");

            }

            if (txt > 0 && txt == u)
            {
                if (txtma.Text != "")
                {
                    if (cbloai.Text != "")
                    {

                        if (themmoi == true)
                        {
                            try
                            {
                                string[] s = lbimgpath.Text.ToString().Split('\\');

                                ck.MASP = txtma.Text;
                                ck.TENSP = txtten.Text;
                                ck.MALOAI = cbloai.Text;
                                ck.GIABAN = txtdgb.Text;

                                ck.HINHANH = s[s.Length - 1];

                                thucthi.themoi(ck);
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
                                string[] s = lbimgpath.Text.ToString().Split('\\');
                                ck.MASP = txtma.Text;
                                ck.TENSP = txtten.Text;
                                ck.MALOAI = cbloai.Text;
                                ck.GIABAN = txtdgb.Text;

                                ck.HINHANH = s[s.Length - 1];

                                thucthi.sua(ck);
                                MessageBox.Show("Đã Sửa Thành Công Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        cbloai.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                    txtma.Focus();
                }
            }
            else
            {
                MessageBox.Show("Gía bán không nhập âm và không nhập chữ");
                return;
                txtdgb.Focus();
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
                    ck.MASP = txtma.Text;

                    thucthi.xoa(ck);
                    MessageBox.Show("Đã Xóa Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienthi();
                    setnull();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
            }
            imghinhanh.Image = Image.FromFile(@"../../Resources/Close.png");
        }
        private void fr_Sanpham_Load(object sender, EventArgs e)
        {
            imghinhanh.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            {
                //Get image data from gridview column.
                byte[] imageData = hinhanh;

                //Initialize image variable
                Image newImage;
                //Read image data into a memory stream
                using (MemoryStream ms = new MemoryStream(imageData, 0, imageData.Length))
                {
                    ms.Write(imageData, 0, imageData.Length);

                    //Set image variable value using memory stream.
                    newImage = Image.FromStream(ms, true);
                }

                //set picture
                imghinhanh.Image = newImage;
            }
            catch
            {

            }
            thucthi.loadmal(cbloai);

            locktext();
            hienthi();
            khoitaoluoi();
        }
        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string s = msds.Rows[dong].Cells[4].Value.ToString();
                dong = e.RowIndex;
                txtma.Text = msds.Rows[dong].Cells[0].Value.ToString();
                txtten.Text = msds.Rows[dong].Cells[1].Value.ToString();
                cbloai.Text = msds.Rows[dong].Cells[2].Value.ToString();


                txtdgb.Text = msds.Rows[dong].Cells[3].Value.ToString();
                imghinhanh.Image = Image.FromFile(@"../../Resources/" + msds.Rows[dong].Cells[4].Value.ToString());
                locktext();
            }
            catch
            {

            }


            //imghinhanh.Image = QuanLyCuaHangTivi.Properties.Resources.no;

        }
        byte[] ReadFile(string sPath)
        {

            byte[] data = null;

            //sử dụng FileInfo để lấy kích thước file.
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;

            //Đọc file
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            //Sử dụng BinaryReader để đọc file vào mảng byte.
            BinaryReader br = new BinaryReader(fStream);
            data = br.ReadBytes((int)numBytes);
            return data;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();

                dlg.Filter = "Image File (*.jpg;*.jpeg;*.bmp;*.gif;*.png)|*.jpg;*.jpeg;*.bmp;*.gif;*.png";
                dlg.Title = "Chọn Hình";

                DialogResult dlgRes = dlg.ShowDialog();
                if (dlgRes != DialogResult.Cancel)
                {
                    //Gán hình vào Picture box
                    imghinhanh.ImageLocation = dlg.FileName;
                    imghinhanh.SizeMode = PictureBoxSizeMode.StretchImage;
                    //Gán đường dẫn ảnh vào lbimgpath
                    lbimgpath.Text = dlg.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void cbloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl.Text = thucthi.loadtenl(lbl.Text, cbloai.Text);
        }

        private void imghinhanh_Click(object sender, EventArgs e)
        {

        }

        private void msds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbimgpath_Click(object sender, EventArgs e)
        {

        }
    }
}
