using System;

namespace Strings_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Какой день";
            string subString = "замечательный ";

            text = text.Insert(6, subString);
            Console.WriteLine(text);
        }
    }
}
