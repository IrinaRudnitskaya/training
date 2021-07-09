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
            using (FileStream fstream = File.OpenRead(@"C:\Users\Irina\Documents\array.txt"))
            {
                byte[] array = new byte[fstream.Length];

                fstream.Read(array, 0, array.Length);

                string textFromFile = Encoding.Default.GetString(array)
                    .Replace("\r", string.Empty)
                    .Replace("\n", string.Empty)
                    .Trim();

                var arrayFromString = textFromFile.Split(' ')
                    .Select(x => Convert.ToInt32(x))
                    .ToArray();

                Console.WriteLine($"Текст из файла: {textFromFile}");
            }

            Console.ReadLine();
        }
    }
}
