using System;

namespace Bai20
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString267 = "";
            int kw267;
            long cost267;
            Console.Write("Nhap so kW tieu thu: ");
            inputString267 = Console.ReadLine();
            if (!int.TryParse(inputString267, out kw267))
            {
                Console.Write("So khong hop le. Ket thuc chuong trinh");
            }
            else
            {
                cost267 = kw267 * 500;
                if (kw267 > 100)
                {
                    cost267 += (kw267 - 100) * 300;
                }
                if (kw267 > 250)
                {
                    cost267 += (kw267 - 250) * 200;
                }
                if (kw267 > 350)
                {
                    cost267 += (kw267 - 350) * 500;
                }
                Console.Write("Tien dien: " + cost267);
            }
        }
    }
}
