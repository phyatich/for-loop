using System;

namespace for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Bir sayı giriniz: ");
            // int counter = int.Parse(Console.ReadLine());
            // for (int i = 0; i <= counter; i++)
            // {
            //     if (i % 2 == 1)
            //     {
            //         Console.WriteLine(i);
            //     }
            // }

            // int oddSum = 0;
            // int evenSum = 0;

            // for (int i = 0; i < 1000; i++)
            // {
            //     if (i % 2 == 1)
            //     {
            //         oddSum += i;
            //     }
            //     else
            //     {
            //         evenSum += i;
            //     }
            // }

            // Console.WriteLine("Tek Toplam: " + oddSum);
            // Console.WriteLine("Çift Toplam: " + evenSum);

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
