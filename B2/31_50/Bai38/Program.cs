using System;

namespace Bai38
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString267 = "";
            int n267, i267, a267, b267, c267;
            Console.Write("Nhap n (nghin dong, n > 5): ");
            inputString267 = Console.ReadLine();
            if (!int.TryParse(inputString267, out n267))
            {
                Console.Write("So khong hop le. Ket thuc chuong trinh");
            }
            else if (n267 <= 5)
            {
                Console.Write("So khong hop le. Ket thuc chuong trinh");
            }
            else
            {
                for (i267 = 1; i267 <= n267; i267++)
                    for (a267 = 0; a267 <= i267; a267++)
                        for (b267 = 0; b267 <= i267; b267++)
                            for (c267 = 0; c267 <= i267; c267++)
                                if (a267 + b267 + c267 == i267)
                                    if (a267 + 2 * b267 + 5 * c267 == n267)
                                        if (2 * b267 > i267)
                                        {
                                            Console.Write(a267 + " to 1000 + " + b267 + " to 2000 + " + c267 + " to 5000 = " + (a267 + b267 + c267) + " to");
                                            goto endLoop;
                                        }
                                    endLoop:
                Console.Write("\n");
            }
        }
    }
}
