using System;

namespace ConsAppAss4part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First 10 Natural Numbers:");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\n\nFirst 10 Even Natural Numbers:");
            int evenCounter = 1;
            while (evenCounter <= 20)
            {
                if (evenCounter % 2 == 0)
                {
                    Console.Write($"{evenCounter} ");
                    evenCounter++;
                }
                else
                {
                    evenCounter++;
                }
            }

            Console.WriteLine("\n\nFirst 10 Odd Natural Numbers:");
            int oddCounter = 1;
            do
            {
                if (oddCounter % 2 != 0)
                {
                    Console.Write($"{oddCounter} ");
                }else
                {
                    oddCounter++;
                }
               
            } while (oddCounter <= 20);

            Console.ReadLine(); 

        }
    }
}
