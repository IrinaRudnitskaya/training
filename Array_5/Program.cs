using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.;

namespace Array_4
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fstream = File.OpenRead($"{path}\note.txt"))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                int array_1 = new int[int.Parse, textFromFile];
                Console.WriteLine($"Текст из файла: {textFromFile}");
            }

            Console.ReadLine();
        }
    }
}
