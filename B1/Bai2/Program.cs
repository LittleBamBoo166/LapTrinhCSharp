using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap mot so: ");
            string inputString = Console.ReadLine();
            int num = 0;
            if (int.TryParse(inputString, out num))
            {
                // num la mot so
                string outputString = "";
                if (num > 10 || num < -10)
                {
                    Console.WriteLine("Opp! Out of brain.");
                }
                else
                {
                    if (num < 0)
                    {
                        outputString += "am ";
                    }
                    switch (Math.Abs(num))
                    {
                        case 1:
                            outputString += "mot";
                            break;
                        case 2:
                            outputString += "hai";
                            break;
                        case 3:
                            outputString += "ba";
                            break;
                        case 4:
                            outputString += "bon";
                            break;
                        case 5:
                            outputString += "nam";
                            break;
                        case 6:
                            outputString += "sau";
                            break;
                        case 7:
                            outputString += "bay";
                            break;
                        case 8:
                            outputString += "tam";
                            break;
                        case 9: 
                            outputString += "chin";
                            break;
                        default:
                            outputString = "Opp!";
                            break;
                    }
                    Console.WriteLine(outputString);
                }
            }
            else {
                Console.WriteLine("So ban nhap khong hop le.");
            }
        }
    }
}
