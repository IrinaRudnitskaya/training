using System;

namespace Strings_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Привет, я иду в магазин";

            text = text.Replace("магазин", "парк");
            Console.WriteLine(text);
        }
    }
}
