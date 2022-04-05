using System;

namespace _63
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
                int i, count = 0;
                Random random = new Random();
                mang = new int[n + 1];
                ori = new int[n + 1];
                for (i = 1; i <= n; ++i)
                {
                    mang[i] = 100 - random.Next(100);
                    ori[i] = mang[i];
                    if (mang[i] % 4 == 0)
                        if (mang[i] % 10 == 6)
                            count++;
                    if (mang[i] % 2 != 0)
                        ori[i] *= 2;
                }
                Console.WriteLine("Xuat mang:");
                for (i = 0; i < n; ++i)
                    Console.Write(mang[i + 1] + "  ");
                Console.WriteLine("\nCo " + count + " phan tu chia het cho 4, tan cung 6");
                Console.WriteLine("Nhan doi phan tu le");
                for (i = 0; i < n; ++i)
                    Console.Write(ori[i + 1] + "  ");
            }
        }
    }
}
