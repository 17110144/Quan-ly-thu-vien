using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    class DocGia_TreEm : DocGia
    {
        protected string sMaGiamGia;

        public DocGia_TreEm() : base()
        {

        }
        public DocGia_TreEm(string hoten, string cmnd, string ngaysinh, string diachi, string madg, List<Sach> sachdm, string magiamgia)
            : base(hoten, cmnd, ngaysinh, diachi, madg, sachdm)
        {
            this.sMaGiamGia = magiamgia;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap email: ");
            this.sMaGiamGia = Console.ReadLine();
        }


    }
}
