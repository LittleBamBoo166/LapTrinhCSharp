using System;

namespace _60
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
            else if (n % 2 != 0)
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
                    mang[i] = random.Next(n);
                    ori[i] = mang[i];
                }
                Console.WriteLine("Xuat mang:");
                for (i = 0; i < n; ++i)
                    Console.Write(mang[i] + "  ");

                Console.WriteLine("\nTron hoan hao:");
                perfect_shuffle(mang, n);

                for (i = 1; i <= n; ++i)
                    Console.Write(mang[i] + "  ");

                while (true)
                {
                    perfect_shuffle(mang, n);
                    d = 0;
                    for (i = 1; i <= n; ++i)
                        if (mang[i] == ori[i])
                            ++d;
                    count++;
                    if (d == n)
                        break;
                }

                Console.WriteLine("\nCan " + d + " lan shuffle de lam mang tro ve ban dau.");
            }
        }

        static void perfect_shuffle(int[] m, int n)
        {
            int i, j, k, tg;
            for (i = 1, j = n / 2 + 1; i < n - 1; i += 2, ++j)
            {
                tg = m[j];
                for (k = j; k >= i + 2; --k)
                    m[k] = m[k - 1];
                m[i + 1] = tg;
            }
        }
    }
}
