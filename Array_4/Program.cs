using System;

namespace Array_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number for array_1 ");
            var array_1 = new int[int.Parse(Console.ReadLine())];
            var random_1 = new Random();
            for (var i = 0; i < array_1.Length; i++)
                array_1[i] = random_1.Next(-100, 100);
            Array.Sort(array_1);

            Console.Write("Enter number for array_2 ");
            var array_2 = new int[int.Parse(Console.ReadLine())];
            var random_2 = new Random();
            for (var j = 0; j < array_2.Length; j++)
                array_2[j] = random_2.Next(-100, 100);
            Array.Sort(array_2);

            Console.Write("Array_1: ");
            for (var i = 0; i < array_1.Length; i++)
                Console.Write("{0}\t", array_1[i]);
            Console.WriteLine();

            Console.Write("Array_2: ");
            for (var j = 0; j < array_2.Length; j++)
                Console.Write("{0}\t", array_2[j]);
            Console.WriteLine();

            var array_3 = new int[array_1.Length + array_2.Length];

            int n = 0;
            int m = 0; 
            int k = 0;
            while (n < array_1.Length && m < array_2.Length)
                array_3[k++] = array_1[n] < array_2[m] ? array_1[n++] : array_2[m++];
            while (n < array_1.Length)
                array_3[k++] = array_1[n++];
            while (m < array_2.Length)
                array_3[k++] = array_2[m++];


            Console.Write("Array_3: ");
            for (var i = 0; i < array_1.Length; i++)
                Console.Write("{0}\t", array_3[i]);
            Console.WriteLine();
        }
    }
}
