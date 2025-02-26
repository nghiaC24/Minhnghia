using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minhnghia
{
    // Lớp GiangVienCH kế thừa lớp cha GiangVien
     class GiangVienCH : GiangVien
    {
        public float HeSoLuong { get; set; }
        private const int LUONG_CO_BAN = 2340000;

        public GiangVienCH() { }

        public GiangVienCH(string maso, string hoten, DateTime namsinh, float hesoluong)
            : base(maso, hoten, namsinh) // Gọi constructor của lớp cha 
        {
            this.HeSoLuong = hesoluong;
        }
        // Ghì đè phương thức nhập cho GiangVienCH
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập hệ số lương: ");
            HeSoLuong = float.Parse(Console.ReadLine());
        }

        public override int TinhLuong()
        {
            return (int)(HeSoLuong * LUONG_CO_BAN);
        }

    }
}
