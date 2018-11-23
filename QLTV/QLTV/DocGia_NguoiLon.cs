using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    class DocGia_NguoiLon : DocGia
    {
        protected string sEmail;
        protected string sSDT;

        public DocGia_NguoiLon():base()
        {

        }
        public DocGia_NguoiLon(string hoten, string cmnd, string ngaysinh, string diachi, string madg, List<Sach> sachdm, string email, string sdt)
            : base(hoten, cmnd, ngaysinh, diachi, madg, sachdm)
        {
            this.sEmail = email;
            this.sSDT = sdt;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap email: ");
            this.sEmail = Console.ReadLine();
            Console.Write("Nhap SDT: ");
            this.sSDT = Console.ReadLine();
        }



    }
}
