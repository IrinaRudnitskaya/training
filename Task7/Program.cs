using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 6;
            for (int i=1; i<=46; i++)
            {
                if (i % 4 != 0) continue;
                sum += i;
            }
            int s = 0;
            for (int k = 2; k <= 46; k++)
                if (k % 4 == 0) s++;
            
            Console.WriteLine(sum);
            Console.WriteLine(s);
        }
    }
}
