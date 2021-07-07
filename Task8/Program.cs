using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum = 6;
            int k;
            for (int i = 1; i<=46;  i++)
            {
                if (i % 4 == 0)
                {
                    for (k = 0; k<=10;k++)
                    {
                        sum += i;
                    }
                }
                else continue;
                Console.WriteLine(k);

            }
            Console.WriteLine(sum);
        }
    }
}
