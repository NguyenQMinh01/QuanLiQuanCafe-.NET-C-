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
using QuanLyCafe.BaoCao;


namespace QuanLyCafe.Presentation
{
    public partial class fr_DoanhThu : Form
    {
        
        ConnectDB cn = new ConnectDB();
        E_tb_Sanpham tbSP = new E_tb_Sanpham();
        EC_tb_Sanpham sp = new EC_tb_Sanpham();
        public fr_DoanhThu()
        {
            InitializeComponent();
        }


        public void khoitaoluoi()
        {
            //RepositoryItemPictureEdit image = msds.RepositoryItems.Add("PictureEdit") as RepositoryItemPictureEdit;
            try
            {
                msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                msds.Columns[0].HeaderText = "Tên Sản Phẩm";
                msds.Columns[0].Frozen = true;
                msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                msds.Columns[0].Width = 200;

                msds.Columns[1].HeaderText = "Tổng Tiền Bán";
                msds.Columns[1].Width = 200;

                msds.Columns[2].HeaderText = "Tổng Tiền Nhập";
                msds.Columns[2].Width = 200;

                msds.Columns[3].HeaderText = "Tổng Doanh Thu";
                msds.Columns[3].Width = 200;

               
            }
            catch (Exception ex)
            {

            }


        }

        private void fr_DoanhThu_Load(object sender, EventArgs e)
        {
            

            int min = int.Parse(DateTime.Now.Year.ToString()) - 10;
            for (int i = min; i < int.Parse(DateTime.Now.Year.ToString()) + 1; i++)
            {
                comboBox2.Items.Add(i);
            }
            khoitaoluoi();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            khoitaoluoi();
            int nam = int.Parse(comboBox2.Text);
            int thang = int.Parse(comboBox1.Text);
            msds.DataSource = tbSP.timDoanhThuTheoThang(thang,nam);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            int nam = int.Parse(comboBox2.Text);
            int thang = int.Parse(comboBox1.Text);
            DataTable ctdt =tbSP.timDoanhThuTheoThang(thang,nam);
            FormChuaBaoCao fr = new FormChuaBaoCao("DoanhThu", ctdt);
            fr.Show();
        }
    }
}
