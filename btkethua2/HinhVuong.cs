using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btkethua2
{
    internal class HinhVuong : HinhChuNhat
    {
        public HinhVuong(double canh) : base(canh, canh)
        {
        }
        public void xuat()
        {
            Console.WriteLine("Chu vi hinh Vuong:"+getChuVi());
            Console.WriteLine("Dien tich hinh vuong:" + getDienTich());
        }
    }
}
