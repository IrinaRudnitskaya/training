using System;

namespace Strings_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "apple", "banana", "orange", "kiwi", "mango" };
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}, ");
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]}");
            }
        }
    }
}
