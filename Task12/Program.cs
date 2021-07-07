using System;

namespace Task12
{
    class Program
    {
        static int FibonacciSum(int n)
        {
            if (n == 0)
                return 0;

            int sum = 0;
            int a = 1, b = 1, c;
            sum += a;

            while (b <= n)
            {
                sum += b;
                c = a + b;
                a = b;
                b = c;
            }
         return sum;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = FibonacciSum(n);
            Console.WriteLine(s);
        }
    }
}
