using System;

namespace _61
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] mang, ori;
            Console.Write("Nhap n: ");
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Exit");
            }
            else
            {
                int i, count = 0, d;
                Random random = new Random();
                mang = new int[n + 1];
                ori = new int[n + 1];
                for (i = 1; i <= n; ++i)
                {
                    mang[i] = random.Next(n) - n;
                    ori[i] = mang[i];
                    if (mang[i] > 0)
                        count += mang[i];
                }
                Console.WriteLine("Xuat mang:");
                for (i = 0; i < n; ++i)
                    Console.Write(mang[i + 1] + "  ");
                Console.WriteLine("\nTong cac so nguyen duong: " + count);
                Console.Write("Nhap chi so: ");
                if (!int.TryParse(Console.ReadLine(), out d))
                    Console.Write("Exit");
                else
                {
                    i = d;
                    while (i < n)
                    {
                        mang[i] = mang[i + 1];
                        ++i;
                    }
                    n--;
                    Console.Write("Xuat mang: \n");
                    for (i = 0; i < n; ++i)
                        Console.Write(mang[i + 1] + "  ");
                }
            }
        }
    }
}
