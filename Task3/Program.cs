using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int num = 0;
            int sum_odd = 0;
            int e = 0;
            while (n <= 0)
            {
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
                                sum_odd += num;
                                e++;
                            }
                        }
                        Console.WriteLine("Sum of the first three odd numbers: {0}", sum_odd);
                        Console.WriteLine(e);
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
}