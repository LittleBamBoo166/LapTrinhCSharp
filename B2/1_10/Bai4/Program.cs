using System;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString267 = "";
            float a267, b267, c267;
            Console.Write("Nhap 3 canh tam giac\na: ");
            inputString267 = Console.ReadLine();
            if (!float.TryParse(inputString267, out a267))
            {
                Console.Write("So khong hop le. Ket thuc chuong trinh");
            }
            else
            {
                Console.Write("b: ");
                inputString267 = Console.ReadLine();
                if (!float.TryParse(inputString267, out b267))
                {
                    Console.Write("So khong hop le. Ket thuc chuong trinh");
                }
                else
                {
                    Console.Write("c: ");
                    inputString267 = Console.ReadLine();
                    if (!float.TryParse(inputString267, out c267))
                    {
                        Console.Write("So khong hop le. Ket thuc chuong trinh");
                    }
                    else
                    {
                        if (a267 > 0 && b267 > 0 && c267 > 0 && a267 + b267 > c267 && b267 + c267 > a267 && a267 + c267 > b267)
                        {
                            float p267;
                            int flag267 = 0;
                            if (a267 == b267 || b267 == c267 || c267 == a267)
                            {
                                flag267 += 1;
                            }
                            if (a267 == b267 && b267 == c267)
                            {
                                flag267 += 1;
                            }
                            if (a267 * a267 + b267 * b267 == c267 * c267 || b267 * b267 + c267 * c267 == a267 * a267 || a267 * a267 + c267 * c267 == b267 * b267)
                            {
                                flag267 += 3;
                            }
                            switch (flag267)
                            {
                                case 0:
                                    Console.WriteLine("Tam giac thuong.");
                                    break;
                                case 1:
                                    Console.WriteLine("Tam giac can.");
                                    break;
                                case 2:
                                    Console.WriteLine("Tam giac deu.");
                                    break;
                                case 3:
                                    Console.WriteLine("Tam giac vuong.");
                                    break;
                                case 4:
                                    Console.WriteLine("Tam giac vuong can.");
                                    break;
                                default:
                                    Console.WriteLine("Loi xac dinh loai tam giac.");
                                    break;
                            }
                            p267 = (a267 + b267 + c267) / 2;
                            Console.Write("Dien tich S = " + (Math.Sqrt(p267 * (p267 - a267) * (p267 - b267) * (p267 - c267))));
                        }
                        else
                        {
                            Console.Write("3 canh khong hop le.");
                        }
                    }
                }
            }
        }
    }
}
