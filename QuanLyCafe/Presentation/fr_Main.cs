using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyCafe.DataAccess;
using QuanLyCafe.BaoCao;
using QuanLyCafe.Business.Component;
using QuanLyCafe.Business.EntitiesClass;
namespace QuanLyCafe.Presentation
{
    public partial class fr_Main : Form
    {
        ConnectDB cn = new ConnectDB();
        E_tb_Khachhang kh = new E_tb_Khachhang();
        E_tb_Sanpham sp = new E_tb_Sanpham();
        E_tb_HDB hdb = new E_tb_HDB();
       
        public fr_Main()
        {
            InitializeComponent();
        }
        private Form kiemtratontai(Type formtype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == formtype)
                    return f;
            }
            return null;
        }

        private void quêQuánToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.trangThai = 0;
            
            Form frm = kiemtratontai(typeof(fr_Khachhang));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_Khachhang fr = new fr_Khachhang();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_NCC));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_NCC fr = new fr_NCC();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void loạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_Loai));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_Loai fr = new fr_Loai();
                fr.MdiParent = this;
                fr.Show();
            }
        }
        private void chiTiếtCafeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_Sanpham));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_Sanpham fr = new fr_Sanpham();
                fr.MdiParent = this;
                fr.Show();
                
            }
        }

        private void hóaĐơnNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_HDN));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_HDN fr = new fr_HDN();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void hóaĐơnXuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_HDB));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_HDB fr = new fr_HDB();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_TKHDB));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_TKHDB fr = new fr_TKHDB();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void điệnThoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_TK_SP));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_TK_SP fr = new fr_TK_SP();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_DangNhap fr = new fr_DangNhap();
            this.Hide();
            fr.Show();
        }
        private void quýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(FormChuaBaoCao));
            if (frm != null)
                frm.Activate();
            else
            {
                DataTable hdb = new E_tb_HDB().docHoaDonBan();
                FormChuaBaoCao fr = new FormChuaBaoCao("HoaDonBan", hdb);
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void quýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(FormChuaBaoCao));
            if (frm != null)
                frm.Activate();
            else
            {
                DataTable kh = new E_tb_Khachhang().docKhachHang();
                FormChuaBaoCao fr = new FormChuaBaoCao("KhachHang", kh);
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void quýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(FormChuaBaoCao));
            if (frm != null)
                frm.Activate();
            else
            {
                DataTable sp = new E_tb_Sanpham().docSanPham();
                FormChuaBaoCao fr = new FormChuaBaoCao("SanPham", sp);
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void nhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_Nhanvien));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_Nhanvien fr = new fr_Nhanvien();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void đặtBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = kiemtratontai(typeof(Ban));
                if (frm != null)
                    frm.Activate();
                else
                {
                    //Ban fr = new Ban();

                    Data.frmBna.MdiParent = this;
                    Data.frmBna.Show();
                }
            }
            catch
            {
            }
            
        }

        private void fr_Main_Load(object sender, EventArgs e)
        {

          
            string quyen = cn.ExcuteScalar("select Quyen from tb_Nhanvien where manv = '" + Data.manv + "'");
            if( quyen == "1")
            {
                nhânViênToolStripMenuItem.Enabled = true;
                //MessageBox.Show("Chào Bạn! \n Bạn đã đăng nhập với quyền admin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                đăngNhậpToolStripMenuItem.Enabled = false;
            
            }
                
            else
            {
                //MessageBox.Show("Chào Bạn! \n Bạn đã đăng nhập với quyền nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nhânViênToolStripMenuItem.Enabled = false;
                đăngNhậpToolStripMenuItem.Enabled = false;
                thốngKêToolStripMenuItem.Enabled = false;
            }

                
        }

        private void kếtNốiHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_KetNoiHeThong));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_KetNoiHeThong fr = new fr_KetNoiHeThong();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_DangNhap fr = new fr_DangNhap();
            this.Hide();
            fr.Show();
        }

        private void khoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_Kho fr = new fr_Kho();
            fr.MdiParent = this;
            fr.Show();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
             fr_DoanhThu fr = new fr_DoanhThu();
             fr.MdiParent = this;
             fr.Show();
        }

        private void aIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_AI fr = new fr_AI();
            fr.MdiParent = this;
            fr.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fr_NCC fr = new fr_NCC();
            fr.MdiParent = this;
            fr.Show();
        }
    }
}



