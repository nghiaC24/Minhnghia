using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minhnghia
{
    internal class GiangVienTG : GiangVien
    {
        public int SoTietDay { get; set; }
        private const int LUONG_MOT_TIET = 120000;

        public GiangVienTG() { }

        public GiangVienTG(string maso, string hoten, DateTime namsinh, int sotietday)
            : base(maso, hoten, namsinh)
        {
            this.SoTietDay = sotietday;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập số tiết dạy: ");
            SoTietDay = int.Parse(Console.ReadLine());
        }

        public override int TinhLuong()
        {
            return SoTietDay * LUONG_MOT_TIET;
        }

    }
}
