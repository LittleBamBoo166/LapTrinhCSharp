using System;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            long tienGuiBD;
            Console.Write("So tien gui ban dau: ");
            if (!long.TryParse(Console.ReadLine(), out tienGuiBD)) {
                Console.WriteLine("Exit");
            } else {
                double laiSuat;
                Console.Write("Lai suat %: ");
                if (!double.TryParse(Console.ReadLine(), out laiSuat)) {
                    Console.WriteLine("Exit");
                } else {
                    int soNam;
                    Console.Write("So nam gui tien: ");
                    if (!int.TryParse(Console.ReadLine(), out soNam)) {
                        Console.WriteLine("Exit");
                    } else {
                        double tienNhanDuoc;
                        tienNhanDuoc = tienGuiBD * Math.Pow(1 + laiSuat / 100, soNam);
                        Console.Write("So tien nhan duoc: " + tienNhanDuoc);
                    }
                }
            }
        }
    }
}
