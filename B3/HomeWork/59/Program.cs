using System;

namespace _59
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string[] can = { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky" };
            string[] chi = { "Than", "Dau", "Tuat", "Hoi", "Ti", "Suu", "Dan", "Meo", "Thin", "Ty", "Ngo", "Mui" };
            Console.Write("Nhap nam: ");
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Gia tri khong hop le. Ket thuc chuong trinh.");
            }
            else
            {
                Console.WriteLine(n + " - " + can[n % 10] + " " + chi[n % 12]);
                Console.WriteLine((n + 60) + " - " + can[n % 10] + " " + chi[n % 12]);
            }
        }
    }
}
