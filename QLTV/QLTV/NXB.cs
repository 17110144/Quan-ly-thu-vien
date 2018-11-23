using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    class NXB
    {
        private string _sTenNXB;
        private List<TacGia> _lTacGia;
        private List<Sach> _lSach;

        public string STenNXB { get => _sTenNXB; set => _sTenNXB = value; }
        internal List<TacGia> LTacGia { get => _lTacGia; set => _lTacGia = value; }
        internal List<Sach> LSach { get => _lSach; set => _lSach = value; }
        public NXB()
        {
            LTacGia = new List<TacGia>();
            LSach = new List<Sach>();
        }
        public NXB(string tennxb, List<TacGia> tacgia, List<Sach> sach)
        {
            this.STenNXB = tennxb;
            this.LTacGia = tacgia;
            this.LSach = sach;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap ten nha xuat ban: ");
            this.STenNXB = Console.ReadLine();
            int tongsotacgia = 0;
            Console.WriteLine("-------------------------------------------------");
            Console.Write("Nhap tong so tac gia: ");
            tongsotacgia = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < tongsotacgia; i++)
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Nhap thong tin tac gia thu {0}: ", i + 1);
                TacGia tg = new TacGia();
                this.LTacGia.Add(tg);
            }
            int tongsosach = 0;
            Console.WriteLine("-------------------------------------------------");
            Console.Write("Nhap tong so sach: ");
            tongsosach = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < tongsosach; i++)
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Nhap thong tin cuon sach thu {0}: ", i + 1);
                Sach sa = new Sach();
                sa.Nhap();
                this.LSach.Add(sa);
            }

        }
    }
}
