using System;

namespace Bai27
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString267 = "";
            int n267, i267 = 2;
            Console.Write("Nhap n: ");
            inputString267 = Console.ReadLine();
            if (!int.TryParse(inputString267, out n267))
            {
                Console.Write("So khong hop le. Ket thuc chuong trinh");
            }
            else
            {
                while (n267 > 1)
                {
                    while (n267 % i267 != 0)
                    {
                        ++i267;
                    }
                    n267 /= i267;
                    Console.Write(n267 > 1 ? (i267 + " * ") : (i267 + "\n"));
                }
            }
        }
    }
}
