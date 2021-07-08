using System;
using System.Linq;

namespace Array_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number ");
            var array = new int[int.Parse(Console.ReadLine())];
            var random = new Random();
            for (var i = 0; i < array.Length; i++)
                array[i] = random.Next(-100, 100);

            Console.Write("Array: ");
            for (var i = 0; i < array.Length; i++)
                Console.Write("{0}\t", array[i]);
            Console.WriteLine();

            Console.Write("Min = ");
            Console.WriteLine(array.Min());

            Console.Write("Max = ");
            Console.WriteLine(array.Max());

            var odd = array[0];

            for (int i = 1; i < array.Length; i ++)
            {
                if (array[i] % 2 != 0)
                {
                    if (array[i] < odd)
                        odd = array[i];
                }
                else continue;
            }

            Console.Write("Min odd = ");
            Console.WriteLine(odd);

            var even = array[0];

            for (int k = 1; k < array.Length; k ++)
            {
                if (array[k] % 2 == 0)
                {
                    if (array[k] < even)
                        even = array[k];
                }
                else continue;
            }

            Console.Write("Min even = ");
            Console.WriteLine(even);

            int a = array.Min();
            int b = array.Max();
            int c;

            c = a;
            a = b;
            b = c;

            Console.Write("New_Min = ");
            Console.WriteLine(b);


            Console.Write("New_Max = ");
            Console.WriteLine(a);


        }
    }
}
