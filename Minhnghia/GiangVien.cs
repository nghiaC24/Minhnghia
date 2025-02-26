using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minhnghia
{
    // Lớp Cha GiangVien 
    internal class GiangVien
    {
        public string Maso { get; set; }
        public string Hoten { get; set; }
        public DateTime Namsinh { get; set; }

        // Constructỏ không tham số 
        public GiangVien() { }

        // Constructor có tham số 
        public GiangVien(string maso, string hoten, DateTime namsinh)
        {
            this.Maso = maso;
            this.Hoten = hoten;
            this.Namsinh = namsinh;
        }
        // Phương thức nhập thông tin giảng viên 
        public virtual void Nhap()
        {
            Console.Write("Nhập mã số giảng viên: ");
            Maso = Console.ReadLine();
            Console.Write("Nhập họ tên giảng viên: ");
            Hoten = Console.ReadLine();
            Console.Write("Nhập năm sinh: ");
            Namsinh = DateTime.Parse(Console.ReadLine());
        }
        // Pt  ảo tính lương (ghì đè ở lớp con ) 
        public virtual int TinhLuong()
        {
            return 0; // Lớp cha không có cách tính lương cụ thể
        }
        // Xuất thông tin giảng viên
        public void Xuat()
        {
            Console.WriteLine($"Mã số: {Maso} | Họ tên: {Hoten} | Năm sinh: {Namsinh} | Lương: {TinhLuong():N0} VND");
        }
    }
}
