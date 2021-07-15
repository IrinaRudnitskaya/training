using System;

namespace Task1
{
    class Program
    {
        static void Main()
        {          
            int sum = 0;
            int n;

            while (true)
            {
                Console.WriteLine("Enter three-digit number ");
                try
                {
                    do
                    {
                        n = Int32.Parse(Console.ReadLine());
                        if (n.ToString().Length != 3)
                        {
                            Console.WriteLine("Error. Enter exactly three-digit number ");
                        }
                    } while (n.ToString().Length != 3);
                    while (n != 0)
                    {
                        sum += n % 10;
                        n /= 10;
                    }
                    Console.WriteLine("sum of numbers " + sum);
                    return;
                }

                catch (Exception)
                {
                    Console.WriteLine("You can't enter symbols. Please, enter the number.");
                }
            }
           
        }
    }
}