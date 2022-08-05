using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.Business.EntitiesClass
{
    class EC_tb_Kho
    {
        private string manguyenlieu;
        private string tennguyenlieu;
        private int soluong;

        public int Soluong
        {
          get { return soluong; }
          set { soluong = value; }
        }
        public string MALOAI
        {
            get
            {
                return manguyenlieu;
            }
            set
            {
                manguyenlieu = value;
                if (manguyenlieu == "")
                {
                    throw new Exception("Mã không để trống");
                }
            }
        }
        public string TENLOAI
        {
            get
            {
                return tennguyenlieu;
            }
            set
            {
                tennguyenlieu = value;
            }
        }
    }
}
