using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    class DocGia : Nguoi
    {
        protected string SMaDG;
        protected List<Sach> LSachDaMuon;

        public DocGia():base()
        { }



        public DocGia(string hoten, string cmnd, string ngaysinh, string diachi, string madg, List<Sach> sachdm)
    : base(hoten, cmnd, ngaysinh, diachi)
        {
            this.SMaDG = madg;
            this.LSachDaMuon = sachdm;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap Ma Doc Gia: ");
            this.SMaDG = Console.ReadLine();
            
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Ma Doc Gia: " + this.SMaDG);
        }
    }
}
