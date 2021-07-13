using System;

namespace Strings_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "хорошо в лесу";
            char ch1 = 'о';
            int indexOfCharString1 = s1.IndexOf(ch1);
            if (indexOfCharString1 < 0)
            {
                Console.WriteLine("1. В этой фразе не встречается буква 'o' ");
            }
            else
            {
                Console.Write("1. индекс первого вхождения буквы 'o' - ");
                Console.WriteLine(indexOfCharString1);
            }


            string s2 = "Эх, дороги, пыль да туман";
            char ch2 = 'о';
            int indexOfCharString2 = s2.IndexOf(ch2);
            if (indexOfCharString2 < 0)
            {
                Console.WriteLine("2. В этой фразе не встречается буква 'o' ");
            }
            else
            {
                Console.Write("2. индекс первого вхождения буквы 'o' - ");
                Console.WriteLine(indexOfCharString2);
            }

            string s3 = "Семнадцать вариантов решения";
            char ch3 = 'о';
            int indexOfCharString3 = s3.IndexOf(ch3);
            if (indexOfCharString3 < 0)
            {
                Console.WriteLine("3. В этой фразе не встречается буква 'o' ");
            }
            else
            {
                Console.Write("3. индекс первого вхождения буквы 'o' - ");
                Console.WriteLine(indexOfCharString3);
            }


        }
    }
}
