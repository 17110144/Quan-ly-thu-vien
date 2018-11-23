using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    class Sach
    {
        private string _sMaSach;
        private string _sTenSach;
        private string _sGiaBan;
        private string _sTheLoai;

        public Sach()
        {
        }
        public Sach(string masach,string tensach,string giaban,string theloai)
        {
            this.SMaSach = masach;
            this.STenSach = tensach;
            this.SGiaBan = giaban;
            this.STheLoai = theloai;
        }

        public string SMaSach { get => _sMaSach; set => _sMaSach = value; }
        public string STenSach { get => _sTenSach; set => _sTenSach = value; }
        public string SGiaBan { get => _sGiaBan; set => _sGiaBan = value; }
        public string STheLoai { get => _sTheLoai; set => _sTheLoai = value; }


        public void Nhap()
        {
            Console.Write("Nhap ma sach: ");
            this.SMaSach = Console.ReadLine();
            Console.Write("Nhap ten sach: ");
            this.STenSach = Console.ReadLine();
            Console.Write("Nhap the loai: ");
            this.STheLoai = Console.ReadLine();
            Console.Write("Nhap gia ban: ");
            this.SGiaBan = Console.ReadLine();
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Ma san sach: " + this.SMaSach);
            Console.WriteLine("Ten san sach: " + this.STenSach);
            Console.WriteLine("The loai: " + this.STheLoai);
            Console.WriteLine("Gia Ban: " + this.SGiaBan);
        }
    }
}
