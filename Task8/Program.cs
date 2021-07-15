using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 6;
            int sum = 6;
            Console.WriteLine(x);
            for (int i = 1; i < 10; i++)
            {
                x += 4;
                sum += x;
                
                Console.WriteLine(x);
            }

            Console.WriteLine("Sum of the numbers = " + sum) ;


        }
    }
}
