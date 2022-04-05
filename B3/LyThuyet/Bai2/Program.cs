using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so tu nhien n: ");
            if (!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Exit");
            } else {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write(i + "  ");
                }
            }
        }
    }
}
