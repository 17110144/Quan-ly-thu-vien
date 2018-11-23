using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    class ThuVien
    {
        private string _sTenThuVien;
        private string _sDiaChi;
        private List<NXB> _lNXB;
        private List<DocGia> _lDocGia;


        public string STenThuVien { get => _sTenThuVien; set => _sTenThuVien = value; }
        public string SDiaChi { get => _sDiaChi; set => _sDiaChi = value; }
        internal List<NXB> LNXB { get => _lNXB; set => _lNXB = value; }
        internal List<DocGia> LDocGia { get => _lDocGia; set => _lDocGia = value; }

        public ThuVien()
        {
            LNXB = new List<NXB>();
            LDocGia = new List<DocGia>();
        }

        public ThuVien(string tenthuvien, string diachi, List<NXB> nxb, List<DocGia> docgia)
        {
            this.STenThuVien = tenthuvien;
            this.SDiaChi = diachi;
            this.LNXB = nxb;
            this.LDocGia = docgia;
        }
        public void Nhap()
        {
            Console.Write("Nhap ten thu vien: ");
            this.STenThuVien = Console.ReadLine();
            int tongdocgianguoilon = 0;
            Console.WriteLine("-------------------------------------------------");
            Console.Write("Nhap tong so ti vi: ");
            tongdocgianguoilon = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < tongdocgianguoilon; i++)
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Nhap thong tin Doc Gia nguoi lon thu {0}: ", i + 1);
                DocGia dgl = new DocGia_NguoiLon();
                dgl.Nhap();
                this.LDocGia.Add(dgl);
            }

            int tongdocgiatreem = 0;
            Console.WriteLine("-------------------------------------------------");
            Console.Write("Nhap tong so dien thoai: ");
            tongdocgiatreem = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < tongdocgiatreem; i++)
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Nhap thong tin Dien Thoai thu {0}: ", i + 1);
                DocGia dgte = new DocGia_TreEm();
                dgte.Nhap();
                this.LDocGia.Add(dgte);
            }
            int tongsonxb = 0;
            Console.WriteLine("-------------------------------------------------");
            Console.Write("Nhap tong so NXB: ");
            tongsonxb = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < tongsonxb; i++)
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Nhap thong tin NXB thu {0}: ", i + 1);
                NXB nxb = new NXB();
                nxb.Nhap();
                this.LNXB.Add(nxb);
            }
        }

    }
}
