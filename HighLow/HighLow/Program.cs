using System;

namespace HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int r = rnd.Next(1, 100);
            int userEntry;
            bool again = true;
            while (again)
            {
                Console.WriteLine("Please enter a number between 1 - 100");
                userEntry = Convert.ToInt32(Console.ReadLine());
                if (userEntry > r)
                {
                    Console.WriteLine("Hey buddy that number is too high!!!");
                }
                else if (userEntry < r)
                {
                    Console.WriteLine("Hey pal that number is too low!!!");
                }
                else if(userEntry == r)
                {
                    Console.WriteLine("Good job yuppie! You got it right!!");
                    again = false;
                }
            } 

        }
    }
}
