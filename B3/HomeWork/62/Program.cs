using System;

namespace _62
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
                int i, j, le = 0, chan = 0;
                Random random = new Random();
                mang = new int[n + 1];
                ori = new int[n + 1];
                for (i = 1; i <= n; ++i)
                {
                    mang[i] = random.Next(10) + 10;
                    ori[i] = mang[i];
                    if (i % 2 == 0)
                        chan += mang[i];
                    else
                        le += mang[i];
                }
                Console.WriteLine("Xuat mang:");
                for (i = 0; i < n; ++i)
                    Console.Write(mang[i + 1] + "  ");
                if (le == chan)
                    Console.WriteLine("\nTong le bang tong chan");
                else
                    Console.WriteLine("\nTong le khac tong chan");
                for (i = 1; i < n; ++i)
                    for (j = i + 1; j <= n; ++j)
                        if (ucln(ori[i], ori[j]) == 1)
                            Console.WriteLine("(" + ori[i] + ", " + ori[j] + ")");
            }
        }

        static int ucln(int a, int b)
        {
            while (a != b)
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            return b;
        }
    }
}
