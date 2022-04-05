using System;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString267 = "";
            float xC267 = 0f, yC267 = 0f, r267 = 0f, xM267 = 0f, yM267 = 0f;
            Console.Write("Nhap toa do tam C\nxC: ");
            inputString267 = Console.ReadLine();
            if (!float.TryParse(inputString267, out xC267))
            {
                Console.Write("So khong hop le. Ket thuc chuong trinh");
            }
            else
            {
                Console.Write("yC: ");
                inputString267 = Console.ReadLine();
                if (!float.TryParse(inputString267, out yC267))
                {
                    Console.Write("So khong hop le. Ket thuc chuong trinh");
                }
                else
                {
                    Console.Write("Nhap ban kinh R: ");
                    inputString267 = Console.ReadLine();
                    if (!float.TryParse(inputString267, out r267))
                    {
                        Console.Write("So khong hop le. Ket thuc chuong trinh");
                    }
                    else
                    {
                        Console.Write("Nhap toa do M\nxM: ");
                        inputString267 = Console.ReadLine();
                        if (!float.TryParse(inputString267, out xM267))
                        {
                            Console.Write("So khong hop le. Ket thuc chuong trinh");
                        }
                        else
                        {
                            Console.Write("yM: ");
                            inputString267 = Console.ReadLine();
                            if (!float.TryParse(inputString267, out yM267))
                            {
                                Console.Write("So khong hop le. Ket thuc chuong trinh");
                            }
                            else
                            {
                                double d;
                                d = r267 - Math.Sqrt(Math.Pow(xM267 - xC267, 2) + Math.Pow(yM267 - yC267, 2));
                                if (d > 0)
                                {
                                    Console.Write("M nam trong C()");
                                }
                                else if (d < 0)
                                {
                                    Console.Write("M nam ngoai C()");
                                }
                                else
                                {
                                    Console.Write("M nam tren C()");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
