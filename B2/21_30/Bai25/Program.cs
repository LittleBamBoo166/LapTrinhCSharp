using System;

namespace Bai25
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString267 = "";
            int a267, b267, ucln267, bcnn267;
            Console.Write("a = ");
            inputString267 = Console.ReadLine();
            if (!int.TryParse(inputString267, out a267))
            {
                Console.Write("So khong hop le. Ket thuc chuong trinh");
            }
            else
            {
                Console.Write("b = ");
                inputString267 = Console.ReadLine();
                if (!int.TryParse(inputString267, out b267))
                {
                    Console.Write("So khong hop le. Ket thuc chuong trinh");
                }
                else
                {
                    ucln267 = a267;
                    while (a267 % ucln267 != 0 || b267 % ucln267 != 0)
                    {
                        ucln267--;
                    }
                    Console.WriteLine("Uoc chung lon nhat: " + ucln267);
                    bcnn267 = a267 * b267 / ucln267;
                    Console.Write("Boi chung nho nhat: " + bcnn267);
                }
            }
        }
    }
}
