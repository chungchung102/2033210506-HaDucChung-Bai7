using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2033210506_HaDucChung_Bai7
{
    public abstract class ToaDo
    {
        private float hoanhDo;
        private float tungDo;
        private string tenToaDo;

        public float HoanhDo { get => hoanhDo; set => hoanhDo = value; }
        public float TungDo { get => tungDo; set => tungDo = value; }
        public string TenToaDo { get => tenToaDo; set => tenToaDo = value; }

        public ToaDo()
        {
            HoanhDo = 0f;
            TungDo = 0f;
            tenToaDo = "";
        }
        public abstract void NhapToaDo();
        public abstract void XuatToaDo();
    }
}