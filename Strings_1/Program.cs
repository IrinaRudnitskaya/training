using System;

namespace Strings_1
{
    class Person
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public byte Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            String hello = "Привет!";
            String name = "Меня зовут Ирина.";
            String age = "Мне 22 года.";

            Console.WriteLine("{0} {1} {2}", hello, name, age);
        

            Console.Write ($"{ hello} {name} {age}");
            
        }
    


    }
}
