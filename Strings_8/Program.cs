using System;

namespace Strings_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Сегодня в зоопарке я видел большого жирафа";

            text = text.Replace("большого", "");
            Console.WriteLine(text);
        }
    }
}
