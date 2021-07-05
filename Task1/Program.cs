using System;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter three-digit number ");
            do
            {

            }

            int sum = 0;
            int n;
            n = Int32.Parse(Console.ReadLine());
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine("sum of numbers " + sum);
        }
    }
}