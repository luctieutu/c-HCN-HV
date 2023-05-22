using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace btkethua2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HinhChuNhat hcn = new HinhChuNhat(4, 5);
            HinhVuong hv = new HinhVuong(3);
            hcn.xuat();
            hv.xuat();
        }
    }
}
