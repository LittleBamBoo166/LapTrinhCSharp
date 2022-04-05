using System;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input1;
            string input2 = "";
            Console.Write("Nhap nguoi 1 (tuoi - ten): \n");
            input1 = int.Parse(Console.ReadLine());
            input2 = Console.ReadLine();
            ConNguoi conNguoi1 = new ConNguoi(input1, input2);
            Console.Write("Nhap nguoi 2 (tuoi - ten): \n");
            input1 =int.Parse(Console.ReadLine());
            input2 = Console.ReadLine();
            ConNguoi conNguoi2 = new ConNguoi(input1, input2);
            Console.Write("Nhap nguoi 3 (tuoi - ten): \n");
            input1 = int.Parse(Console.ReadLine());
            input2 = Console.ReadLine();
            ConNguoi conNguoi3 = new ConNguoi(input1, input2);
            conNguoi1.ss();
            Console.WriteLine();
            conNguoi2.ss();
            Console.WriteLine();
            conNguoi3.ss();
            Console.WriteLine();
        }
    }

    class ConNguoi
    {
        protected int tuoi;
        protected string ten;

        public ConNguoi(int tu, string te) 
        {
            tuoi = tu;
            ten = te;
        }

        public void ss() {
            if (tuoi >= 60) {
                Console.Write("Nguoi lon: " + ten);
            } else if (tuoi >= 18) {
                Console.Write("Nguoi truong thanh: " + ten);
            } else {
                Console.Write("Em be: " + ten);                
            }
        }
    }
}
