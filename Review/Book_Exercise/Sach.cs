﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Exercise
{
    public abstract class Sach
    {
        private string maSach;
        private string tenSach;
        private string tacGia;
        private int soTrang;
        private double giaBan;
        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }
        public string TenSach
        {
            get { return tenSach; }
            set { tenSach = value; }
        }
        public string TacGia
        {
            get { return tacGia; }
            set { tacGia = value; }
        }
        public int SoTrang
        {
            get { return soTrang; }
            set { soTrang = value; }
        }
        public double GiaBan
        {
            get { return giaBan; }
            set
            {
                if(value < 10000)
                {
                    throw new ArgumentException("Giá sách phải lớn hơn 10 000");
                }
                else
                {
                    giaBan = value;
                }
            }
        }
        static double tiLeThue = 0.03;
        public Sach()
        {
            maSach = "S001";
            tenSach = "Hướng đối tượng";
            tacGia = "Nguyễn Cửu Đàm";
            soTrang = 100;
            giaBan = 40000;
        }
        public Sach(string maSach, string tenSach, string tacGia, int soTrang, double giaBan)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.tacGia = tacGia;
            this.soTrang = soTrang;
            this.giaBan = giaBan;
        }
        public void xuatThongTin()
        {
            Console.WriteLine("{0,10}, {1,20}, {3, 20}, {4,10}, {5, 10}", maSach, tenSach, tacGia, soTrang, giaBan);
        }
        public double thueSanXuat()
        {
            return giaBan * tiLeThue;
        }
        public double tienNhuanButCuaTacGia()
        {
            return giaBan * 0.2;
        }
        public abstract double chiPhi();
        public double loiNhuan()
        {
            return giaBan - chiPhi() - thueSanXuat() - tienNhuanButCuaTacGia();
        }
    }
}
