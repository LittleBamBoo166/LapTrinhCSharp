using System;

namespace BTDiemDanh
{
    class Program
    {
        static void Main(string[] args)
        {
            int a267, b267, c267;
            Console.Write("Nhap a: ");
            if (!int.TryParse(Console.ReadLine(), out a267)) {
                Console.WriteLine("Invalid.");
                goto exit267;
            }
            Console.Write("Nhap b: ");
            if (!int.TryParse(Console.ReadLine(), out b267)) {
                Console.WriteLine("Invalid.");
                goto exit267;
            }
            Console.Write("Nhap c: ");
            if (!int.TryParse(Console.ReadLine(), out c267)) {
                Console.WriteLine("Invalid.");
                goto exit267;
            }
            PTB2 pTB2 = new PTB2(a267, b267, c267);
            pTB2.result();
            Animal cat = new Cat();
            Animal bird = new Bird();
            cat.eat267();
            cat.makeSound267();
            bird.eat267();
            bird.makeSound267();
            exit267:
            Console.WriteLine("Exit");
        }
    }
}
