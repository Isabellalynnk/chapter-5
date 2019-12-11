using System;

namespace HomeSales
{
    class Program
    {
        static void Main(string[] args)
        {
            string D, E, F;
            int totalD;
            int totalE;
            int totalF;
            int salesEntry;

            if (salesEntry == "D")
            {
                Console.WriteLine("Enter sales>>>");
                salesEntry = Convert.ToInt32(Console.ReadLine());
                totalD = totalD + salesEntry;
            }
            else (salesEntry == "E"){
                Console.WriteLine("Enter sales>>>");
                salesEntry = Convert.ToInt32(Console.ReadLine());
                totalE = totalE + salesEntry;
            }
            else(salesEntry == "F"){
                Console.WriteLine("Enter sales>>>");
                salesEntry = Convert.ToInt32(Console.ReadLine());
                totalF = totalF + salesEntry;
            }

            salesEntry = totalD + totalE + totalF;
        }
    }
}
