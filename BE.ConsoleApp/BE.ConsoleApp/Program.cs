using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.ConsoleApp
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("1. Them san pham");
                Console.WriteLine("2. Xoa san pham");
                Console.WriteLine("3. Thoat");
                Console.WriteLine("Nhap lua chon: ");
                n = int.Parse(Console.ReadLine()); 
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Them thanh cong");
                        break;
                    case 2:
                        Console.WriteLine("Xoa thanh cong");
                        break;
                    case 3:
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Bớt nhập ngu lại");
                        break;
                }
            } while (n >= 1 && n <= 3);
        }
    }
}
