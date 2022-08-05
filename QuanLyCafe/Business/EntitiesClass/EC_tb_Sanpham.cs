using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCafe.Business.EntitiesClass
{
    class EC_tb_Sanpham
    {
        private string masp;
        private string tensp;
        private string maloai;

        private string giaban;

       
        private string hinhanh;

       
        


        public string MASP
        {
            get
            {
                return masp;
            }
            set
            {
                masp = value;
                if (masp == "")
                {
                    throw new Exception("Mã không để trống");
                }
            }
        }
        public string TENSP
        {
            get
            {
                return tensp;
            }
            set
            {
                tensp = value;
            }
        }
        public string MALOAI
        {
            get
            {
                return maloai;
            }
            set
            {
                maloai = value;
                if (maloai == "")
                {
                    throw new Exception("Mã không để trống");
                }
            }
        }
     
        public string GIABAN
        {
            get
            {
                return giaban;
            }
            set
            {
                giaban = value;
            }
        }
        

        public string HINHANH
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
    }
}
