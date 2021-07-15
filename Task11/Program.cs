using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 6;
            int sum = 6;
            int number = 0;
            Console.WriteLine(x);

            for (int i = 1; i < 10; i++)
            {
                x += 4;
                sum += x;
                Console.WriteLine(x);
                number = i + 1;
                if (sum > 100)
                {
                    sum -= x;
                    number -= 1;
                    break;
                }                
            }

            Console.Write("Количество слагаемых = ");
            Console.WriteLine(number);
            Console.Write("Сумма = ");
            Console.WriteLine(sum);
        }
    }
}
