using System;

namespace SumInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int entry = 0;
            int total = 0;

            while (entry != 999)
            {
                Console.WriteLine("Enter Number>>");
                entry = Convert.ToInt32(Console.ReadLine());
                total = total + entry;
            }
        }
    }
}
