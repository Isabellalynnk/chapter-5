using System;

namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int average;
            int entry = 0;
            int total = 0;

            while(entry != 999){
                Console.WriteLine("Enter Test Scores>>");
                entry = Convert.ToInt32(Console.ReadLine());
                total = total + entry;
                count++;
            }
            average = total / count;
            Console.WriteLine(average);
        }
    }
}
