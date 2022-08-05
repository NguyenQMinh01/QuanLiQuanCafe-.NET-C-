using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCafe.Business.EntitiesClass
{
    class EC_tb_Nhanvien
    {
        private string manv;
        private string tennv;
        private string diachi;
        private string gioitinh;
        private string ngaysinh;
        private string tenque;
        private string sdt;
        private string password;
        private string quyen;

        public string MANV
        {
            get
            {
                return manv;
            }
            set
            {
                manv = value;
                if (manv == "")
                {
                    throw new Exception("Mã không để trống");

                    
                }
            }
        }
        public string TENNV
        {
            get
            {
                return tennv;
            }
            set
            {
                tennv = value;
            }
        }
        public string DIACHI
        {
            get
            {
                return diachi;
            }
            set
            {
                diachi = value;
            }
        }
        public string GIOITINH
        {
            get
            {
                return gioitinh;
            }
            set
            {
                gioitinh = value;
            }
        }
        public string NGAYSINH
        {
            get
            {
                return ngaysinh;
            }
            set
            {
                ngaysinh = value;
            }
        }
        public string TENQUE
        {
            get
            {
                return tenque;
            }
            set
            {
                tenque = value;
                if (tenque == "")
                {
                    throw new Exception("Mã không được để trống");
                }
            }
        }
        public string SDT
        {
            get
            {
                return sdt;
            }
            set
            {
                sdt = value;
            }
        }
        public string PASSWORD
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                if (password == "")
                {
                    throw new Exception("Password không được để trống");
                }
            }
        }
        public string QUYEN
        {
            get
            {
                return quyen;
            }
            set
            {
                quyen = value;
                if (quyen == "")
                {
                    throw new Exception("Mã không được để trống");
                }
            }
        }
    }
}
