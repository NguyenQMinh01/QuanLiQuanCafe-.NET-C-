using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyCafe.Business.Component;
using QuanLyCafe.Presentation;

namespace QuanLyCafe.BaoCao
{
    public partial class FormChuaBaoCao : Form
    {

        E_tb_Nhanvien nv = new E_tb_Nhanvien();
        public FormChuaBaoCao(string formname, DataTable data)
        {
            string nguoilap = nv.timTenNV(Data.manv);
            InitializeComponent();
            if (formname == "KhachHang")
            {
                //KhachHangReport baocao = new KhachHangReport();
                //crystalReportViewer1.ReportSource = baocao;
                //baocao.SetDataSource(data);
                //baocao.SetParameterValue("nguoilap", nguoilap);

                Report_DS_KhachHang bc = new Report_DS_KhachHang();
                crystalReportViewer1.ReportSource = bc;
                bc.SetDataSource(data);
                bc.SetParameterValue("NguoiLap", nguoilap);
            }
            else if (formname == "HoaDonBan")
            {
                HoaDonBanReport baocao = new HoaDonBanReport();
                crystalReportViewer1.ReportSource = baocao;
                baocao.SetDataSource(data);
                baocao.SetParameterValue("nguoilap", nguoilap);
            }
            else if (formname == "SanPham")
            {
                SanPhamReport baocao = new SanPhamReport();
                crystalReportViewer1.ReportSource = baocao;
                baocao.SetDataSource(data);
                baocao.SetParameterValue("nguoilap", nguoilap);
            }

            else if (formname == "ChiTietHoaDonBan")
            {
                Report_BC_CT_HDBan cthdb = new Report_BC_CT_HDBan();
                crystalReportViewer1.ReportSource = cthdb;
                cthdb.SetDataSource(data);
                cthdb.SetParameterValue("NguoiLap", nguoilap);
            }


            else if (formname == "ChiTietHoaDonNhap")
            {
                Report_BC_CT_HDNhap cthdn = new Report_BC_CT_HDNhap();
                crystalReportViewer1.ReportSource = cthdn;
                cthdn.SetDataSource(data);
                cthdn.SetParameterValue("NguoiLap", nguoilap);
            }

            else if (formname == "DoanhThu")
            {
                Report_BC_DoanhThu ctdt = new Report_BC_DoanhThu();
                crystalReportViewer1.ReportSource = ctdt;
                ctdt.SetDataSource(data);
                ctdt.SetParameterValue("NguoiLap", nguoilap);
            }
        }

        private void FormChuaBaoCao_Load(object sender, EventArgs e)
        {

        }
    }
}
