using System;

namespace Bai18
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString267 = "";
            long hours267;
            Console.Write("Nhap so gio: ");
            inputString267 = Console.ReadLine();
            if (!long.TryParse(inputString267, out hours267))
            {
                Console.Write("So khong hop le. Ket thuc chuong trinh");
            }
            else
            {
                Console.Write((hours267 / (24 * 7)) + " tuan, " + ((hours267 % (24 * 7)) / 24) + " ngay, " + ((hours267 % (24 * 7)) % 24) + " gio.");
            }
        }
    }
}
