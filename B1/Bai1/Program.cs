using System;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap mot so: ");
            string inputString = Console.ReadLine();
            int num = 0;
            if (int.TryParse(inputString, out num))
            {
                if (num >= 0)
                {
                    Console.WriteLine("Day la so nguyen duong.");
                }
                else
                {
                    Console.WriteLine("Day la so nguyen am.");
                }
            }
            else
            {
                Console.WriteLine("Day khong phai mot so.");
            }
        }
    }
}
