using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int m;
            
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter 'm' in beetwin [1;20]");
                    m = Convert.ToInt32(Console.ReadLine());

                    if (1 < m && m <= 20)
                    {
                        for (int i = 1; i <= m; i++)
                        {

                            for (int k = i+1; k <= m; k++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine("*");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error. Enter a number from the correct range");
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
