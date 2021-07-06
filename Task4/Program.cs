using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            int num = 0;
            while (true)
            {
                Console.WriteLine("Enter number of numbers");
                try
                {

                    n = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("Enter number {0}:", i + 1);
                        num = Convert.ToInt32(Console.ReadLine());

                        if (num % 2 != 0)
                        {
                            n1 = n2;
                            n2 = n3;
                            n3 = num;
                        }
                    }
                    Console.WriteLine("Sum of the last three odd numbers: {0}", n1 + n2 + n3);
                    return;
                }

                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
        }
    }
}
