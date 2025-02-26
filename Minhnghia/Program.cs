using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minhnghia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            QuanLyGV qlgv = new QuanLyGV();
            int choice;

            do
            {
                Console.WriteLine("\n==== QUẢN LÝ GIẢNG VIÊN ====");
                Console.WriteLine("1. Nhập danh sách giảng viên");
                Console.WriteLine("2. Hiển thị danh sách giảng viên");
                Console.WriteLine("3. Tính tổng lương nhà trường phải trả");
                Console.WriteLine("4. Thoát");
                Console.Write("Nhập lựa chọn: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        qlgv.NhapDS();
                        break;
                    case 2:
                        qlgv.XuatDS();
                        break;
                    case 3:
                        Console.WriteLine($"\nTổng lương nhà trường phải trả: {qlgv.TongLuong():N0} VND");
                        break;
                    case 4:
                        Console.WriteLine("Thoát chương trình.");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ! Vui lòng nhập lại.");
                        break;
                }

            } while (choice != 4);
        }
    }
}
