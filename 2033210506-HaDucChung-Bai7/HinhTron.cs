using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2033210506_HaDucChung_Bai7
{
    public class HinhTron : ToaDo
    {
        private float banKinh;

        public float BanKinh { get => banKinh; set => banKinh = value; }

        public HinhTron(float hoanhDo, float tungDo, string tenToaDo, float banKinh) : base()
        {
            this.banKinh = banKinh;
        }
        public override void NhapToaDo()
        {
            Console.Write("Nhap hoanh do: ");
            HoanhDo = float.Parse(Console.ReadLine());
            Console.Write("Nhap tung do: ");
            TungDo = float.Parse(Console.ReadLine());
            Console.Write("Nhap ten toa do: ");
            TenToaDo = Console.ReadLine();
            Console.Write("Nhap ban kinh: ");
            
            BanKinh = float.Parse(Console.ReadLine());
        }

        public override void XuatToaDo()
        {
            Console.WriteLine($"{TenToaDo} ({HoanhDo}, {TungDo}) - Ban kinh: {BanKinh}");
            Console.WriteLine($"Chu vi: {tinhChuVi()}");
            Console.WriteLine($"Dien tich: {tinhDienTich()}");
        }
        public double tinhChuVi()
        {
            return 2 * Math.PI * banKinh;
        }
        public double tinhDienTich()
        {
            return banKinh * banKinh * Math.PI;
        }


    }
}
