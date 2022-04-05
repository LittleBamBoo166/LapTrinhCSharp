using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString267 = "";
            float xA267 = 0f, xB267 = 0f, yA267 = 0f, yB267 = 0f;
            Console.Write("Nhap xA: ");
            inputString267 = Console.ReadLine();
            if (!float.TryParse(inputString267, out xA267))
            {
                Console.Write("So khong hop le. Ket thuc chuong trinh");
            }
            else
            {
                Console.Write("Nhap yA: ");
                inputString267 = Console.ReadLine();
                if (!float.TryParse(inputString267, out yA267))
                {
                    Console.Write("So khong hop le. Ket thuc chuong trinh");
                }
                else
                {
                    Console.Write("Nhap xB: ");
                    inputString267 = Console.ReadLine();
                    if (!float.TryParse(inputString267, out xB267))
                    {
                        Console.Write("So khong hop le. Ket thuc chuong trinh");
                    }
                    else
                    {
                        Console.Write("Nhap yB: ");
                        inputString267 = Console.ReadLine();
                        if (!float.TryParse(inputString267, out yB267))
                        {
                            Console.Write("So khong hop le. Ket thuc chuong trinh");
                        }
                        else
                        {
                            Console.Write("Khoang cach AB = " + (Math.Abs(Math.Sqrt(Math.Pow(xA267 - xB267, 2) + Math.Pow(yA267 - yB267, 2)))));
                        }
                    }
                }
            }
        }
    }
}
