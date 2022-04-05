using System;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "";
            float a = 0f, b = 0f, c = 0f;
            Console.Write("Nhap 3 so thuc: \na: ");
            inputString = Console.ReadLine();
            if (!float.TryParse(inputString, out a))
            {
                Console.WriteLine("So khong hop le. Ket thuc chuong trinh.");
            }
            else
            {
                Console.Write("b: ");
                inputString = Console.ReadLine();
                if (!float.TryParse(inputString, out b))
                {
                    Console.WriteLine("So khong hop le. Ket thuc chuong trinh.");
                }
                else
                {
                    Console.Write("c: ");
                    inputString = Console.ReadLine();
                    if (!float.TryParse(inputString, out c))
                    {
                        Console.WriteLine("So khong hop le. Ket thuc chuong trinh.");
                    }
                    else 
                    {
                        if (a <= 0 || b <= 0 || c <= 0) {
                            Console.WriteLine("Gia tri am khong hop le. Ket thuc chuong trinh.");
                        }
                        else
                        {
                            if (a + b > c && b + c > a && a + c > b) 
                            {
                                Console.WriteLine("Day la 3 canh cua tam giac.");
                            }
                            else 
                            {
                                Console.WriteLine("Day khong phai la 3 canh cua tam giac.");
                            }
                        }
                    }
                }
            }
        }
    }
}
