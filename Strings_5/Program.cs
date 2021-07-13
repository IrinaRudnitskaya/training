using System;

namespace Strings_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Где такое интересное место?";
            char ch1 = 'у';
            int LastindexOfCharString1 = s1.LastIndexOf(ch1);
            if (LastindexOfCharString1 < 0)
            {
                Console.WriteLine("1. В этой фразе не встречается буква 'у' ");
            }
            else
            {
                Console.Write("1. индекс последнего вхождения буквы 'у' - ");
                Console.WriteLine(LastindexOfCharString1);
            }


            string s2 = "У меня дома есть ноутбук.";
            char ch2 = 'у';
            int LastindexOfCharString2 = s2.LastIndexOf(ch2);
            if (LastindexOfCharString2 < 0)
            {
                Console.WriteLine("2. В этой фразе не встречается буква 'у' ");
            }
            else
            {
                Console.Write("2. индекс последнего вхождения буквы 'у' - ");
                Console.WriteLine(LastindexOfCharString2);
            }


            string s3 = "Винтажный стул";
            char ch3 = 'у';
            int LastindexOfCharString3 = s3.LastIndexOf(ch3);
            if (LastindexOfCharString3 < 0)
            {
                Console.WriteLine("3. В этой фразе не встречается буква 'у' ");
            }
            else
            {
                Console.Write("3. индекс последнего вхождения буквы 'у' - ");
                Console.WriteLine(LastindexOfCharString3);
            }

        }
    }
}
