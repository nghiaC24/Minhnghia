using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minhnghia
{
    internal class QuanLyGV
    {
        private List<GiangVien> dsGV;

        public QuanLyGV()
        {
            dsGV = new List<GiangVien>();
        }

        public void NhapDS()
        {
            Console.Write("Nhập số lượng giảng viên: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập thông tin giảng viên thứ {i + 1}:");
                Console.Write("Chọn loại giảng viên (1 - Cơ hữu, 2 - Thỉnh giảng): ");
                int loaiGV = int.Parse(Console.ReadLine());

                GiangVien gv;
                if (loaiGV == 1)
                {
                    gv = new GiangVienCH();
                }
                else
                {
                    gv = new GiangVienTG();
                }

                gv.Nhap();
                dsGV.Add(gv);
            }
        }

        public void XuatDS()
        {
            Console.WriteLine("\nDanh sách giảng viên:");
            foreach (var gv in dsGV)
            {
                gv.Xuat();
                Console.WriteLine(new string('-', 50));
            }
        }

        public int TongLuong()
        {
            int tongLuong = 0;
            foreach (var gv in dsGV)
            {
                tongLuong += gv.TinhLuong();
            }
            return tongLuong;
        }
    }
}
