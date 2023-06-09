﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btkethua2
{
    internal class HinhChuNhat
    {
        public double rong;
        public double dai;
        
        public HinhChuNhat(double rong, double dai)
        {
            this.rong = rong;
            this.dai = dai;
        }
        public double getChuVi()
        {
            return (this.rong + this.dai) * 2;
        }
        public double getDienTich()
        {
            return this.rong * this.dai;
        }
        public void xuat()
        {
            Console.WriteLine("Chieu dai HCN:" + this.dai + "cm");
            Console.WriteLine("Chieu rong HCN:" + this.rong + "cm");
            Console.WriteLine("Chu vi HCN:" + getChuVi()+ "cm");
            Console.WriteLine("Dien tich HCN:" + getDienTich() + "cm2");
        }
    }
}
