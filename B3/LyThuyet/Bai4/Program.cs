using System;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap n: ");
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Exit");
            }
            else
            {
                int i, j;
                int nn = n;
                for (i = 1; i < n; i++)
                {
                    --nn;
                    for (j = 1; j <= nn; ++j)
                        Console.Write(" ");
                    Console.Write("*");
                    for (j = 1; j <= 2 * i - 3; ++j)
                        Console.Write(" ");
                    Console.Write(i != 1 ? "*\n" : "\n");
                }
                for (i = 1; i <= 2 * n - 1; ++i)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
