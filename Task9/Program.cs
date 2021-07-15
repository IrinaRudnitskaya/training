using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int sum = 1;
            Console.WriteLine(x);
            for (int i = 1; i < 11; i++)
            {
                x = (x*2);
                sum += x;

                Console.WriteLine(x);
            }

            Console.WriteLine("Sum of the numbers = ", sum);
        }
    }
}
