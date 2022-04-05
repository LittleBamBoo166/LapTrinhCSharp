using System;

namespace Bai15
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString267 = "";
            int day267, month267, year267;
            Console.Write("Ngay: ");
            inputString267 = Console.ReadLine();
            if (!int.TryParse(inputString267, out day267))
            {
                Console.Write("So khong hop le. Ket thuc chuong trinh");
            }
            else
            {
                Console.Write("Thang: ");
                inputString267 = Console.ReadLine();
                if (!int.TryParse(inputString267, out month267))
                {
                    Console.Write("So khong hop le. Ket thuc chuong trinh");
                }
                else
                {
                    Console.Write("Nam: ");
                    inputString267 = Console.ReadLine();
                    if (!int.TryParse(inputString267, out year267))
                    {
                        Console.Write("So khong hop le. Ket thuc chuong trinh");
                    }
                    else
                    {
                        int s267;
                        s267 = day267;
                        for (int i = 1; i < month267; i++)
                        {
                            switch (i)
                            {
                                case 4:
                                case 6:
                                case 9:
                                case 11:
                                    s267 += 30;
                                    break;
                                case 2:
                                    s267 += 28;
                                    if ((year267 % 4 == 0 & year267 % 100 == 0) || (year267 % 400 == 0))
                                    {
                                        s267++;
                                    }
                                    break;
                                default:
                                    s267 += 31;
                                    break;
                            }
                        }
                        Console.Write("Ngay thu: " + s267);
                    }
                }
            }
        }
    }
}
