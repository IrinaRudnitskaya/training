using System;
using System.Linq;
namespace Array_1
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
            for(var i = 0; i < array.Length; i++)
                Console.Write("{0}\t", array[i]);
            Console.WriteLine();

            Console.WriteLine("Answer: {0}", array.GroupBy(x => x)
                .Select(x => new { Value = x.Key, Count = x.Count() })
                .OrderByDescending(x => x.Count)
                .ThenBy(x => x.Value).First().Value);
        }
    }
}
