using System;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString267 = "";
            float s267 = 0f;
            Console.Write("Nhap dien tich S: ");
            inputString267 = Console.ReadLine();
            if (!float.TryParse(inputString267, out s267))
            {
                Console.WriteLine("So khong hop le. Ket thuc chuong trinh.");
            }
            else
            {
                Console.Write("The tich V: " + ((4 * Math.PI * Math.Pow(Math.Sqrt(s267 / (4 * Math.PI)), 3)) / 3));
            }
        }
    }
}
