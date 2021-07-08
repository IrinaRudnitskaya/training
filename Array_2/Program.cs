using System;
using System.Linq;

namespace Array_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number ");
            var array = new int[int.Parse(Console.ReadLine())];
            var random = new Random();
            for (var i = 0; i < array.Length; i++)
                array[i] = random.Next(0, 10);

            Console.Write("Array: ");
            for (var i = 0; i < array.Length; i++)
                Console.Write("{0}\t", array[i]);
            Console.WriteLine();

            bool f;
            Console.WriteLine("Ascending:  {0}", f = array.SequenceEqual(array.OrderBy(x => x)));
            Console.WriteLine("Descending: {0}", f |= array.SequenceEqual(array.OrderByDescending(x => x)));
            Console.WriteLine("Unsorted:   {0}", !f);
            Console.ReadKey();
        }
    }
}
