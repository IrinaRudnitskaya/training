using System;

namespace Strings_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Первый рабочий день прошел на ура";

            string[] words = text.Split(new char[] { ' ' });

            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
        }
    }
}
