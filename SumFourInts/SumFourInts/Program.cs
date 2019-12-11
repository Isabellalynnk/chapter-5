using System;

namespace SumFourInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int entry;

            for (i = 900;)
            {
                Console.WriteLine("Enter four numbers to sum together>>>");
                entry = Convert.ToInt32(Console.ReadLine());
                total = total + entry;
            }
            Console.WriteLine(total);
            }
        }
    }
}
