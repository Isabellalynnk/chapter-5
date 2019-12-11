using System;

namespace TestingWhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            displayDoWhile();
        }
        public static void displayDoWhile()
        {
            int count = 0;
            string reswponse = null;
            do
            {
                Console.WriteLine(count);
                count++;
            } while (count < 10);

            do
            {
                Console.WriteLine(count);
                count--;
            } while (count > 0){

            Console.WriteLine("Would you like to count agian? Y or N");
            response = Console.ReadLine();

            } while ("Y" != response);
        }
        public static void displayYesterdaysWork() {
            int num = 10;
            int num2 = 0;
            bool again = true;
            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                    num = num - 5;
                }
                while (num2 < 10)
                {
                    Console.WriteLine("Isabella");
                    num2 = num2 + 1;
                }
                while (again)
                {
                    num = num + 1;
                    Console.WriteLine(num);
                    if (num == 10)
                    {
                        again = false;
                    }
                }
            }
        }
    }
}
