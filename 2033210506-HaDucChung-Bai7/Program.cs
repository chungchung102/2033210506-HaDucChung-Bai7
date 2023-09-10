using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2033210506_HaDucChung_Bai7
{
    static class Program
    {
        static void Main(string[] arg)
        {

            HinhTron hinhTron = new HinhTron(5, 5, "Diem A", 10.5f);

            hinhTron.NhapToaDo();
            hinhTron.XuatToaDo();

            Console.ReadLine();
        }

    }

}
