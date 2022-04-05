using System;

namespace Bai36
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString267 = "";
            int n267, k267, count267, i267;
            Console.Write("Nhap n: ");
            inputString267 = Console.ReadLine();
            if (!int.TryParse(inputString267, out n267))
            {
                Console.Write("So khong hop le. Ket thuc chuong trinh");
            }
            else
            {
                k267 = 2;
                count267 = 0;
                while (count267 < n267)
                {
                    for (i267 = 2; i267 * i267 <= k267; i267++)
                        if (k267 % i267 == 0)
                            break;
                    if (i267 * i267 > k267)
                    {
                        Console.Write(k267 + " ");
                        count267++;
                    }
                    k267++;
                }
            }
        }
    }
}
