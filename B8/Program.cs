using System;

namespace B8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            int i = 0;
            Console.WriteLine("Nhap 10 so: ");
            while (int.TryParse(Console.ReadLine(), out arr[i]))
            {
                if (i == 9)
                    break;
                i++;
            }
            if (arr.Length != 10)
                goto exit;
            else {
                int max = arr[0], min = arr[0];
                int tmp = 0;
                for (i = 1; i < arr.Length; i++)
                {
                    if (arr[i] > max) {
                        max = arr[i];
                    }
                    if (arr[i] < min) {
                        min = arr[i];
                    }
                }
                for (int j = 0; j < arr.Length; j++)
                {
                    for (int k = 0; k < arr.Length; k++)
                    {
                        if (arr[j] > arr[k])
                            tmp = arr[j];
                            arr[j] = arr[k];
                            arr[k] = tmp;
                    }
                }
                Console.WriteLine("Max = ", max);
                Console.WriteLine("Min = ", min);
                for (int m = 0; m < arr.Length; m++)
                {
                    Console.Write(arr[m] + "  ");
                }
            }
            exit:
            Console.WriteLine("Exit");
        }
    }
}
