using System;
using System.Linq;
using System.IO;
using System.Text;

namespace Array_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Irina\Documents\array_1.txt";
            int[] arrayFromString;
            string textFromFile;
            using (FileStream fstream = File.OpenRead(path))
            {
                byte[] array = new byte[fstream.Length];

                fstream.Read(array, 0, array.Length);


                textFromFile = Encoding.Default.GetString(array)
                    .Replace("\r", string.Empty)
                    .Replace("\n", string.Empty)
                    .Replace(" ", string.Empty)
                    .Trim();

                arrayFromString = textFromFile.Split(',')
                    .Select(x => Convert.ToInt32(x))
                    .ToArray();
                fstream.Close();
            }

            Console.WriteLine($"Текст из файла: {textFromFile}");

            Array.Sort(arrayFromString);            
            Console.WriteLine($"Отсортированный массив:");
            for (int i = 0; i < arrayFromString.Length; i++)
            {
                Console.Write(arrayFromString[i]);
            }
            string[] textToFile = new string[arrayFromString.Length];
            for (int k = 0; k < arrayFromString.Length; k++)
            {
                textToFile[k] = Convert.ToString(arrayFromString[k]);
            }

            using (FileStream fstream_1 = new FileStream(path, FileMode.Open, FileAccess.Write))
            {

                byte[] array_1 = new byte[fstream_1.Length];
                for (int j = 0; j < array_1.Length; j++)
                {
                    array_1[j] = Byte.Parse(textToFile[j]);
                }

                fstream_1.Write(array_1, 0, array_1.Length);
            }

        }
    }
}