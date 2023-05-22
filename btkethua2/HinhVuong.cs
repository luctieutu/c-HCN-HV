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
            this.dai = canh;
        }
        public void xuat()
        {
            Console.WriteLine("Canh hinh vuong:" + this.dai + "cm");
            Console.WriteLine("Chu vi hinh Vuong:"+getChuVi()+ "cm");
            Console.WriteLine("Dien tich hinh vuong:" + getDienTich() + "cm2");
        }
    }
}
