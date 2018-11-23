using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    class Nguoi
    {
        protected string sHoTen;
        protected string sCMND;
        protected string sNgaySinh;
        protected string sDiaChi;

        public Nguoi()
        {
        }

        public Nguoi(string hoten, string cmnd, string ngaysinh, string diachi)
        {
            this.sHoTen = hoten;
            this.sCMND = cmnd;
            this.sNgaySinh = ngaysinh;
            this.sDiaChi = diachi;
        }
        public virtual void Nhap()
        {
            Console.Write("Nhap ma Ho va Ten: ");

            this.sHoTen = Console.ReadLine();

            Console.Write("Nhap so CMND: ");

            this.sCMND = Console.ReadLine();

            Console.Write("Nhap ngay sinh: ");

            this.sNgaySinh = Console.ReadLine();

            Console.Write("Nhap dia chi: ");
            this.sDiaChi = Console.ReadLine();
        }
        public void Nhap(string hoten, string cmnd, string ngaysinh, string diachi)
        {
            this.sHoTen = hoten;
            this.sCMND = cmnd;
            this.sNgaySinh = ngaysinh;
            this.sDiaChi = diachi;
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Ho Ten: " + this.sHoTen);
            Console.WriteLine("So CMND " + this.sCMND);
            Console.WriteLine("Ngay Sinh: " + this.sNgaySinh);
            Console.WriteLine("Dia Chi: " + this.sDiaChi);
        }
        public virtual void a()
        { }
        public virtual void b()
        { }

    }
}
}
