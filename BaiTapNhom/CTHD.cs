using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNhom
{
    class CTHD
    {
        public string maSach { get; set; }
        public string tenSach { get; set; }
        public int soLuongMua { get; set; }
        public double thanhTien { get; set; }

        public CTHD()
        {

        }

        public CTHD(string maSach, string tenSach, int soLuongMua, double thanhTien)
        {
            this.maSach = maSach;
            this.soLuongMua = soLuongMua;
            this.thanhTien = thanhTien;
            this.tenSach = tenSach;
        }
    }
}
