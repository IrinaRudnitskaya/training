using System;

namespace Task2
{
    class Program1
    {
        static void Main(string[] args)
        {
            int sum;
            int num = 0;
            int num_1 = 0;
           
            while (true)
            {
                int max_sum = 0;
                int max_num = 0;
                Console.WriteLine("Enter numbers ");
                try
                {
                    do
                    {
                        num = Int32.Parse(Console.ReadLine());
                        num_1 = num;
                        sum = 0;
                        while (num_1 != 0)
                        {                          
                            sum += num_1 % 10;
                            num_1 /= 10;
                        }                       
                        if (sum > max_sum)
                        {
                            max_sum = sum;
                            max_num = num;                           
                        }

                    } while (num != 0);                    

                    Console.WriteLine("Number with the maximum sum of digits " + max_num, "Sum = " + max_sum);
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
