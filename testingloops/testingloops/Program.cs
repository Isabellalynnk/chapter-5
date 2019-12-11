using System;

namespace testingloops
{
    class Program
    {
        static void Main(string[] args)
        {
            displayDoWhileLoop();
        }
        public static void displayDoWhileLoops()
        {
            int count = 0;

            do
            {
                Console.WriteLine(count);
                count++;
            }
        }
    }
}
