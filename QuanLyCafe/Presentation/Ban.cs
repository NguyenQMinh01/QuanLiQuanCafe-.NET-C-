using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyCafe.DataAccess;
using QuanLyCafe.Business.EntitiesClass;
using QuanLyCafe.Business.Component;
using System.Data.SqlClient;

namespace QuanLyCafe.Presentation
{
    public partial class Ban : Form
    {
        public static string sqlCon = @" server =MMTNGUYENQUANGM\SQLEXPRESS; database=QL_Quancaphe; Integrated Security = false; uid =sa; pwd =123;";
        SqlConnection con = new SqlConnection(sqlCon);

        E_tb_HDB thucthi = new E_tb_HDB();

        ConnectDB cn = new ConnectDB();
        EC_tb_HDB ck = new EC_tb_HDB();


    
        E_tb_Sanpham tblsp = new E_tb_Sanpham();
        
        E_tb_Khachhang tblKH = new E_tb_Khachhang();
        EC_tb_Khachhang kh = new EC_tb_Khachhang();
     
       
        E_tb_CTHDB tblCTHDB = new E_tb_CTHDB();
        EC_tb_CTHDB cthdb = new EC_tb_CTHDB();
        SQL_tb_Ban sqlBan = new SQL_tb_Ban();
     

        DataTable tbSanPham;
        DataColumn[] keySP = new DataColumn[1];
        DataTable tbLoai;
        DataColumn[] keyLoai = new DataColumn[1];

        DataTable dt = new DataTable();
        DataTable dtBan = new DataTable();

        List<Button> lsBtn = new List<Button>();
        public Ban()
        {
            InitializeComponent();
            
        }

        private void Ban_Load(object sender, EventArgs e)
        {
           
            loadCbChuyen();
            
            comboboxLoai_Load();
            comboboxTen_Load();
            comboboxBan_Load();

            loadBtn();

            btnHuy.Enabled = false;
            btnDat.Enabled = false;
            btnGoiMon.Enabled = false;
            btnThanhToan.Enabled = false;
            cbboxBan.Text = "";


        }
        void comboboxLoai_Load()
        {
            tbLoai = cn.taobang("SELECT * FROM tb_Loai");
            cbboxLoai.DataSource = tbLoai;
            cbboxLoai.DisplayMember = "tenloai";
            cbboxLoai.ValueMember = "maloai";

        }
        void comboboxTen_Load()
        {
            tbSanPham = cn.taobang("SELECT * FROM tb_SanPham WHERE maloai = '" + cbboxLoai.SelectedValue.ToString() + "'");
            cbboxTen.DataSource = tbSanPham;
            cbboxTen.DisplayMember = "tensp";
            cbboxTen.ValueMember = "masp";


        }
        void comboboxBan_Load()
        {
            dtBan = cn.taobang("SELECT * FROM tb_Ban");
            cbboxBan.DataSource = dtBan;
            cbboxBan.DisplayMember = "tenban";
            cbboxBan.ValueMember = "maban";
        }
        void loadSanPham()
        {
            txtGia.Text = "" + tblsp.loadGia(cbboxTen.SelectedValue.ToString());
            upDown_SL.Value = 1;
        }
        private void cbboxTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadSanPham();
            string hinhanh = tblsp.xuatHinhAnh(cbboxTen.SelectedValue.ToString());
            //pictureBox1.Image = Image.FromFile(@"../../Resources/" + hinhanh);
            pictureBox1.BackgroundImage = Image.FromFile(@"../../Resources/" + hinhanh);

        }
        private void cbboxLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxTen_Load();
        }

        private void btnDat_Click(object sender, EventArgs e)
        {
            try
            {
                btnHuy.Enabled = true;
                btnDat.Enabled = false;
                if (txtMaKH.Text != "")
                {
                    string makh = txtMaKH.Text;

                    if (makh == "")
                    {
                        MessageBox.Show("Không tìm thấy khách hàng vui lòng thêm khác hàng mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        new fr_Khachhang().Show();
                    }
                    else
                    {

                        ck.MAHDB = (int.Parse(thucthi.timMaHoaDonTop1())+1).ToString();
                        txtMaHDB.Text = ck.MAHDB;
                        //ck.MANV = Data.manv;
                        ck.MANV = "nv01";
                        ck.NGAYBAN = DateTime.Now.ToString();
                        
                        //MessageBox.Show(ck.NGAYBAN);
                        ck.MAKH = txtMaKH.Text ;
                        ck.TONGTIEN = "0";
                        ck.MABAN = int.Parse(cbboxBan.SelectedValue.ToString());
                        thucthi.themoihdb(ck);
                        int tenBan = int.Parse(cbboxBan.SelectedValue.ToString());
                        lsBtn[tenBan - 1].BackColor = Color.PaleGreen;

                        sqlBan.suaBan(tenBan,1);


                        //MessageBox.Show("" + ck.MABAN);
                        //MessageBox.Show("" + ck.MAHDB);
                        //MessageBox.Show("" + ck.MANV);
                        //MessageBox.Show("" + ck.MAKH);
                        //MessageBox.Show("" + ck.NGAYBAN);
                        txtDatBan.Text = "Đặt bàn thành công";
                        
                       

                        //MessageBox.Show("thành công");


                        //MessageBox.Show("" + ck.TONGTIEN);

                        
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập tên Khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaKH.Focus();
                    btnDat.Enabled = true;
                    btnHuy.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Thao tác không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

         
          
        }

        void loadBtn()
        {
            load(btn1);
            load(btn2);
            load(btn3);
            load(btn4);
            load(btn5);
            load(btn6);
            load(btn7);
            load(btn8);
            load(btn9);
            load(btn10);
            load(btn11);
            load(btn12);
            lsBtn.Add(btn1);
            lsBtn.Add(btn2);
            lsBtn.Add(btn3);
            lsBtn.Add(btn4);
            lsBtn.Add(btn5);
            lsBtn.Add(btn6);
            lsBtn.Add(btn7);
            lsBtn.Add(btn8);
            lsBtn.Add(btn9);
            lsBtn.Add(btn10);
            lsBtn.Add(btn11);
            lsBtn.Add(btn12);
        }
        void load(Button btn)
        {
            int sl = cn.returnscalarnumber("select count(*) from tb_Ban");
            //for(int i = 1; i <= sl; i++)
            //{
            bool tt = sqlBan.xuatTrangThi(btn.Text.ToString());
            if (tt == true)
            {
                btn.BackColor = Color.PaleGreen;
                btnDat.Enabled = false;
                btnGoiMon.Enabled = true;
            }
            //}
        }
        void macDinh()
        {

            //txtMaKH.Text = tblKH.timMaKHNULL(txtMaKH.Text);
            //txtTenKH.Text =tblKH.timTenKHNULL(txtTenKH.Text);
            //MessageBox.Show(txtMaKH.Text);
            //MessageBox.Show(txtTenKH.Text);
            
               
                btnlaydsKH.Enabled = true;
                txtMaHDB.Text = "";
                btnChuyen.Enabled = false;
                cbChuyenBan.Enabled = false;
                btnThanhToan.Enabled = false;
                btnHuy.Enabled = false;
                txtMaKH.Text = "GUEST";
                txtTenKH.Text = "";
                dataGridView1.DataSource = null;
                btnDat.Enabled = true;
                btnGoiMon.Enabled = false;


           
            
        }
        void hienThi()
        {

            btnlaydsKH.Enabled = false;
            txtMaKH.Text = thucthi.timMaKhachHang(txtMaHDB.Text);
            txtTenKH.Text = "";
        }
        private void btnBan1_Click(object sender, EventArgs e)
        {
           

            if (btn1.BackColor == Color.PaleGreen)
            {

                txtMaHDB.Text = thucthi.layHoaDonTheoBan(1);
                
                btnDat.Enabled = false;
                btnGoiMon.Enabled = true;
                hienThi();
                loadgirdviewCthdb();
            }
            else
                macDinh();
            
            cbboxBan.SelectedIndex = 0;
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.BackColor == Color.PaleGreen)
            {
                txtMaHDB.Text = thucthi.layHoaDonTheoBan(2);
                btnDat.Enabled = false;
                btnGoiMon.Enabled = true;
                hienThi();
                loadgirdviewCthdb();
            }
            else
                macDinh();

            cbboxBan.SelectedIndex = 1;
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.BackColor == Color.PaleGreen)
            {
                txtMaHDB.Text = thucthi.layHoaDonTheoBan(3);
                btnDat.Enabled = false;
                btnGoiMon.Enabled = true;
                hienThi();
                loadgirdviewCthdb();
            }
            else
            {
                
                macDinh();
               
            }
            
                cbboxBan.SelectedIndex = 2;
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.BackColor == Color.PaleGreen)
            {
                txtMaHDB.Text = thucthi.layHoaDonTheoBan(4);
                btnDat.Enabled = false;
                btnGoiMon.Enabled = true;
                hienThi();
                loadgirdviewCthdb();
            }
            else
                macDinh();
                cbboxBan.SelectedIndex = 3;
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn5.BackColor == Color.PaleGreen)
            {

                txtMaHDB.Text = thucthi.layHoaDonTheoBan(5);
                btnDat.Enabled = false;
                btnGoiMon.Enabled = true;
                hienThi();
                loadgirdviewCthdb();
            }
            else
                macDinh();
                cbboxBan.SelectedIndex = 4;
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn6.BackColor == Color.PaleGreen)
            {
                txtMaHDB.Text = thucthi.layHoaDonTheoBan(6);
                btnDat.Enabled = false;
                btnGoiMon.Enabled = true;
                hienThi();
                loadgirdviewCthdb();
            }
            else
                macDinh();
                cbboxBan.SelectedIndex = 5;
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn7.BackColor == Color.PaleGreen)
            {
                txtMaHDB.Text = thucthi.layHoaDonTheoBan(7);
                btnDat.Enabled = false;
                btnGoiMon.Enabled = true;
                hienThi();
                loadgirdviewCthdb();
            }
            else
                macDinh();
                cbboxBan.SelectedIndex = 6;
        }
        private void btn8_Click(object sender, EventArgs e)
        {

            if (btn8.BackColor == Color.PaleGreen)
            {
                txtMaHDB.Text = thucthi.layHoaDonTheoBan(8);
                btnDat.Enabled = false;
                btnGoiMon.Enabled = true;
                hienThi();
                loadgirdviewCthdb();
            }
            else
                macDinh();
                cbboxBan.SelectedIndex = 7;
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (btn9.BackColor == Color.PaleGreen)
            {
                txtMaHDB.Text = thucthi.layHoaDonTheoBan(9);
                btnDat.Enabled = false;
                btnGoiMon.Enabled = true;
                hienThi();
                loadgirdviewCthdb();
            }
            else
                macDinh();
                cbboxBan.SelectedIndex = 8;
        }
        private void btn10_Click(object sender, EventArgs e)
        {
            if (btn10.BackColor == Color.PaleGreen)
            {
                txtMaHDB.Text = thucthi.layHoaDonTheoBan(10);
                btnDat.Enabled = false;
                btnGoiMon.Enabled = true;
                hienThi();
                loadgirdviewCthdb();
            }
            else
                macDinh();
                cbboxBan.SelectedIndex = 9;
        }
        private void btn11_Click(object sender, EventArgs e)
        {
            if (btn11.BackColor == Color.PaleGreen)
            {
                txtMaHDB.Text = thucthi.layHoaDonTheoBan(11);
                btnDat.Enabled = false;
                btnGoiMon.Enabled = true;
                hienThi();
                loadgirdviewCthdb();
            }
            else
                macDinh();
                cbboxBan.SelectedIndex = 10;
        }
        private void btn12_Click(object sender, EventArgs e)
        {
            if (btn12.BackColor == Color.PaleGreen)
            {
                txtMaHDB.Text = thucthi.layHoaDonTheoBan(12);
                btnDat.Enabled = false;
                btnGoiMon.Enabled = true;
                hienThi();
                loadgirdviewCthdb();
            }
            else
                macDinh();
                cbboxBan.SelectedIndex = 11;
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnGoiMon_Click(object sender, EventArgs e)
        {
            string maSP = tblsp.timkiemMaSptheoTen(cbboxTen.Text) + "";

            try
            {
                

                if (int.Parse(thucthi.kiemTraSLTon(maSP)) - int.Parse(upDown_SL.Value.ToString()) < 0)
                {
                    txtGoiMon.Text = "Gọi món không thành công";
                    MessageBox.Show("ko du sl trong kho");

                    return;
                }
            }
            catch (Exception)
            {
                
               
            }
           

            btnThanhToan.Enabled = false;
            cthdb.MAHDB = txtMaHDB.Text;
            cthdb.MASP = maSP;
            cthdb.KHUYENMAI = "0";
            cthdb.THANHTIEN = txtGia.Text;
            cthdb.SOLUONG = upDown_SL.Text;

            tblCTHDB.themoicthdb(cthdb);
            loadgirdviewCthdb();
            txtGoiMon.Text = "Gọi món thành công";
           

        }
        void loadgirdviewCthdb()
        {
            chuyenBan();
            btnHuy.Enabled = true;
            dtBan = cn.taobang("select mahdb,tensp,FORMAT(thanhtien, '#,0' ) as thanhtien,soluong from tb_CTHDB,tb_Sanpham where mahdb = '" + txtMaHDB.Text + "' and tb_CTHDB.masp = tb_Sanpham.masp");
            
            dataGridView1.DataSource = dtBan;
            btnThanhToan.Enabled = true;
        }
        void chuyenBan()
        {
            cbChuyenBan.Enabled = true;
            btnChuyen.Enabled = true;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            txtTongTienThanhToan.Text = thucthi.layTongTien(txtMaHDB.Text) + "";
            if (txtTienKhachDua.Text != "")
            {
                if (int.Parse(txtTienKhachDua.Text) >= int.Parse(txtTongTienThanhToan.Text))
                {
                    txtTrangThai.Text = "Thanh toán thành công";
                    int tenBan = int.Parse(cbboxBan.SelectedValue.ToString());

                    lsBtn[tenBan - 1].BackColor = Color.Honeydew;
                    sqlBan.suaBan(tenBan, 0);






                    MessageBox.Show("Tổng Tiền Là:" + thucthi.layTongTien(txtMaHDB.Text));

                    fr_CTHDB fr = new fr_CTHDB();
                    fr.SOHDB = txtMaHDB.Text;
                    fr.Show();
                    macDinh();
                }
                else
                {
                    txtTrangThai.Text = "Thanh toán không thành công";
                    return;
                }
            }
            else
            {
                txtTrangThai.Text = "Thanh toán không thành công";
                return;
            }
           
            
           

         
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnlaydsKH_Click(object sender, EventArgs e)
        {
            Data.trangThai = 1;
            fr_Khachhang fr = new fr_Khachhang();
            fr.Show();
            
        }



        public string gsmaKH
        {
            get
            {
                return this.txtMaKH.Text;
            }
            set
            {
                this.txtMaKH.Text = value;
            }
        }
        public string gsTen
        {
            get
            {
                return this.txtTenKH.Text;
            }
            set
            {
                this.txtTenKH.Text = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows[0].Cells[0].Value != null)
            {
                txtHuyBan.Text = "Hủy bàn không thành công";
                MessageBox.Show("không thể hủy");
                return;
            }

            btnDat.Enabled = true;
            btnHuy.Enabled = false;
            thucthi.deleteHDBtheoma(txtMaHDB.Text.ToString());

            int tenBan = int.Parse(cbboxBan.SelectedValue.ToString());

            lsBtn[tenBan - 1].BackColor = Color.Honeydew;
            sqlBan.suaBan(tenBan, 0);
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtHuyBan.Text = "Hủy bàn thành công";
            


        }
        void loadCbChuyen()
        {
            for (int i = 1; i < 13; i++)
            {
                cbChuyenBan.Items.Add(i + "");
            }
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            if (cbChuyenBan.Text == "")
            {
                MessageBox.Show("vui lòng chọn bàn cần chuyển");
                return;
            }

            int tenBan1 = int.Parse(cbChuyenBan.Text);
            if( lsBtn[tenBan1 - 1].BackColor == Color.Honeydew)
            {
            thucthi.chuyenBan(txtMaHDB.Text, cbChuyenBan.Text);
            int tenBan = int.Parse(cbboxBan.SelectedValue.ToString());

            lsBtn[tenBan - 1].BackColor = Color.Honeydew;
            sqlBan.suaBan(tenBan, 0);

            

            lsBtn[tenBan1 - 1].BackColor = Color.PaleGreen;
            sqlBan.suaBan(tenBan1, 1);
            }
            else{
                MessageBox.Show("bàn đã có người đặt");
            }


        }

        private void txtTenKH_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMaHDB_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
