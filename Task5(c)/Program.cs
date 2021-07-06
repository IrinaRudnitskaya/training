using System;

namespace Task5_c_
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
                        int i1 = 0, i2 = 0;
                        for (int a = 0; a < m; a++)
                        {
                            for (int b = 0; b < m; b++)
                            {

                                if (b == i1 || b == i2) Console.Write("*");
                                
                            }
                            Console.Write("\n");
                            i2++;
                        }
                        for (int b = 0; b < m; b++)
                        {
                            Console.Write("*");
                        }
                        Console.Read();
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
