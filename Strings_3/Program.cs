using System;


namespace Strings_3
{
    class Program
    {

        static void Main(string[] args)
        {
            string hey = "привет";
            string hello = "здравствуйте";

            int result = String.Compare(hey, hello);
            Console.WriteLine(result);
            if (result < 0)
            {
                Console.WriteLine("Строка hey перед строкой hello");
            }
            else if (result > 0)
            {
                Console.WriteLine("Строка hey стоит после строки hello");
            }
            else
            {
                Console.WriteLine("Строки hey и hello идентичны");
            }



            string twenty = "двадцать";
            string twelve = "двенадцать";

            int result_numbers = String.Compare(twenty, twelve);
            Console.WriteLine(result_numbers);
            if (result_numbers < 0)
            {
                Console.WriteLine("Строка twenty перед строкой twelve");
            }
            else if (result_numbers > 0)
            {
                Console.WriteLine("Строка twenty стоит после строки twelve");
            }
            else
            {
                Console.WriteLine("Строки twenty и twelve идентичны");
            }



            string sinus = "синус";
            string sinusoid = "синусоида";

            int result_math = String.Compare(sinus, sinusoid);
            Console.WriteLine(result_math);
            if (result_math < 0)
            {
                Console.WriteLine("Строка sinus перед строкой sinusoid");
            }
            else if (result_math > 0)
            {
                Console.WriteLine("Строка sinus стоит после строки sinusoid");
            }
            else
            {
                Console.WriteLine("Строки sinus и sinusoid идентичны");
            }


            string number_1 = "14";
            string number_2 = "81";

            int result_numerals = String.Compare(number_1, number_2);
            Console.WriteLine(result_numerals);
            if (result_numerals < 0)
            {
                Console.WriteLine("Строка number_1 перед строкой number_2");
            }
            else if (result_numerals > 0)
            {
                Console.WriteLine("Строка number_1 стоит после строки number_2");
            }
            else
            {
                Console.WriteLine("Строки number_1 и number_1 идентичны");
            }

        }


    }
}
