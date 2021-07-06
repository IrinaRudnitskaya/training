using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int m;
            
            while (true)
            {
                try
                {
                        Console.WriteLine("Enter 'n' in beetwin [1;20]");
                        n = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter 'm' in beetwin [1;20]");
                        m = Convert.ToInt32(Console.ReadLine());

                    if ((1 < n && n <= 20) && (1 < m && m <= 20))
                    {
                        for (int i = 1; i <= n; i++)
                        {

                            for (int k = 1; k < m; k++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine("*");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error. Enter a numbers from the correct range");
                    }

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
