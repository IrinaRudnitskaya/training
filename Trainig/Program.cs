using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Trainig
{
    static class Utilities
    {
        internal static bool CheckNumber(string input, out int number)
        {
            if (int.TryParse(input, out number))
            {
                return true;
            }
            Console.WriteLine("Это не целое число. Попробуйте еще раз");
            return false;
        }
        public static bool CheckRange(int number)
        {
            if (1 <= number && number <= 20)
            {
                return true;
            }
            Console.WriteLine("Введите число из указанного промежутка [1:20]");
            return false;
        }
        public static int FibonacciSum(int n)
        {
            if (n == 0)
                return 0;

            int sum = 0;
            int a = 1, b = 1, c;
            sum += a;

            while (b <= n)
            {
                sum += b;
                c = a + b;
                a = b;
                b = c;
            }
            return sum;
        }
        public static void ArrayPrint(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                Console.Write("{0}\t", array[i]);
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Rectangle();
            //Threeangle_1();
            //Threeangle_2();
            //Threeangle_3();
            Task6();
            //Task7();
            //Task8();
            Task9();
            Task10();
            Task11();
            Task12();

            //int numArray = 0;
            //MaxNumberFromArray(numArray);

            //int numForSortArray = 0;
            //ValidationSortArray(numForSortArray);

            //int numForElementsArray = 0;
            //ElementsOfArray(numForElementsArray);

            //int numForArray_1 = 0;
            //int numForArray_2 = 0;
            //MergeTwoArray(numForArray_1, numForArray_2);

            //var path = @"C:\Users\Irina\Documents\array_1.txt";
            //SortArrayToFile(path);
            //SortReserveArrayToFile(path);

            //int NumFofShiftArray = 0;
            //ShiftArray(NumFofShiftArray);

            //FormatString();
            //ArrayString();
            //ComparisonString();
            //StringIndexO();
            //StringIndexY();
            //StringInsert();
            //StringReplace();
            //StringDelete();
            //StringRegister();
            //StringSplit();
        }

        static void Task1()
        {

            while (true)
            {

                Console.WriteLine("Введите целое трехзначное число");
                string input = Console.ReadLine();

                input = input.Trim('-');


                if (input.Length != 3 || !Utilities.CheckNumber(input, out int i))
                {
                    continue;
                }
                Console.WriteLine($"Сумма цифр равна: {SumOfDigits(i)}");
                break;
            }
        }

        static int SumOfDigits(int n)
        {
            var sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        static void Task2()
        {
            int max_sum = 0;
            int max_num = 0;
            int num;
            Console.WriteLine("Введите целые числа");
            do
            {
                string input = Console.ReadLine();
                input = input.Trim('-');
                Utilities.CheckNumber(input, out num);

                var sum = SumOfDigits(num);
                if (sum > max_sum)
                {
                    max_sum = sum;
                    max_num = num;
                }
            }
            while (num != 0);
            Console.WriteLine("Число с максимальной суммой цифр = " + max_num);
            Console.WriteLine("Сумма цифр = " + max_sum);
        }
        static void Task3()
        {
            int sum_odd = 0;
            int e = 0;
            Console.WriteLine("Введите количество чисел");
            while (true)
            {
                string input = Console.ReadLine();
                Utilities.CheckNumber(input, out int n);
                if (n > 0)
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("Введите число {0}:", i + 1);
                        Utilities.CheckNumber(Console.ReadLine(), out int num);

                        if (num % 2 != 0)
                        {
                            e++;
                            sum_odd += num;
                        }
                        if (e > 2) break;

                    }
                    Console.WriteLine("Сумма первых трех нечетных чисел: {0}", sum_odd);
                    break;
                }
                else Console.WriteLine("Введите положительное целое число");

            }



        }

        static void Task4()
        {
            int n1 = 0;
            int n2 = 0;
            int n3 = 0;

            Console.WriteLine("Введите количество чисел");
            while (true)
            {
                string input = Console.ReadLine();
                Utilities.CheckNumber(input, out int n);
                if (n > 0)
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("Введите число {0}:", i + 1);
                        Utilities.CheckNumber(Console.ReadLine(), out int num);
                        if (num % 2 != 0)
                        {
                            n1 = n2;
                            n2 = n3;
                            n3 = num;
                        }
                    }
                    Console.WriteLine("Sum of the last three odd numbers: {0}", (n1 + n2 + n3));
                    break;
                }
                else Console.WriteLine("Введите положительное целое число");

            }
        }
        static void Rectangle()
        {
            Console.WriteLine("Введите 'n' в промежутке [1;20]");
            while (true)
            {
                if (Utilities.CheckNumber(Console.ReadLine(), out int n) == true)
                {
                    if (Utilities.CheckRange(n) == true)
                    {
                        Console.WriteLine("Введите 'm' в промежутке [1;20]");
                        if (Utilities.CheckNumber(Console.ReadLine(), out int m) == true)
                        {
                            if (Utilities.CheckRange(m) == true)
                            {
                                for (int i = 1; i <= n; i++)
                                {
                                    for (int k = 1; k < m; k++)
                                    {
                                        Console.Write("*");
                                    }
                                    Console.WriteLine("*");
                                }
                                break;
                            }
                        }
                    }
                }
            }
        }
        static void Threeangle_1()
        {
            Console.WriteLine("Введите 'm' в промежутке [1;20]");
            while (true)
            {
                if (Utilities.CheckNumber(Console.ReadLine(), out int m) == true)
                {
                    if (Utilities.CheckRange(m) == true)
                    {
                        int i1 = 0, i2 = 0;
                        for (int a = 0; a < m; a++)
                        {
                            for (int b = 0; b < m; b++)
                            {
                                if (b == i1 || b == i2) Console.Write("*");
                                else Console.Write(" ");
                            }
                            Console.Write("\n");
                            i2++;
                        }
                        //for (int b = 0; b < m; b++)
                        //{
                        //    Console.Write("*");
                        //}
                        Console.Read();
                    }
                    break;
                }
            }
        }

        static void Threeangle_2()
        {
            Console.WriteLine("Введите 'm' в промежутке [1;20]");
            while (true)
            {
                if (Utilities.CheckNumber(Console.ReadLine(), out int m) == true)
                {
                    if (Utilities.CheckRange(m) == true)
                    {
                        for (int i = 0; i < m; i++)
                        {
                            int spacesBefore = Math.Abs(m / 2 - i);
                            int starsCount = (m - 2 * spacesBefore);
                            Console.WriteLine("{0}{1}", new string(' ', spacesBefore), new string('*', starsCount));
                        }
                        Console.WriteLine();
                    }
                    break;
                }
            }
        }

        static void Threeangle_3()
        {
            while (true)
            {
                if (Utilities.CheckNumber(Console.ReadLine(), out int m) == true)
                {
                    if (Utilities.CheckRange(m) == true)
                    {
                        for (int i = 1; i <= m; i++)
                        {
                            for (int k = i + 1; k <= m; k++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine("*");
                        }
                        break;
                    }
                }
            }

        }
        static void Task6()
        {
            int sum_a = 0;            
            for (int i = 0; i <= 50; i ++)
            {
                sum_a += i;                
            }
            Console.WriteLine(sum_a);

            int sum_b = 2;
            for (int i = 0; i <= 50; i+=2)
            {
                sum_b += i;
            }
            Console.WriteLine(sum_b);

            int sum_с = 1;
            for (int i = 0; i <= 50; i += 2)
            {
                sum_с += i;
            }
            Console.WriteLine(sum_с);


        }
        
        static void Task7()
        {
            int sum = 6;
            int s = 0;
            for (int i = 4; i <= 46; i += 4)
            {
                sum += i;
                s++;
            }
            Console.WriteLine(sum);
            Console.WriteLine(s);
        }
        static void Task8()
        {
            int a = 6;
            int sumOfTenTerm = 6;
            Console.WriteLine(a);
            for (int i = 1; i < 10; i++)
            {
                a += 4;
                sumOfTenTerm += a;

                Console.WriteLine(a);
            }
            Console.WriteLine("Sum of the numbers = " + sumOfTenTerm);
        }
        static void Task9()
        {
            int b = 1;
            int sumOfElevenTerms = 1;
            Console.WriteLine(b);
            for (int i = 1; i < 11; i++)
            {
                b = (b * 2);
                sumOfElevenTerms += b;
                Console.WriteLine(b);
            }
            Console.WriteLine("Sum of the numbers = " + sumOfElevenTerms);
        }
        static void Task10()
        {
            int x = 6;
            int sumMoreThan100 = 6;
            int number_1 = 0;
            Console.WriteLine(x);
            for (int i = 1; i < 10; i++)
            {
                x += 4;
                sumMoreThan100 += x;
                Console.WriteLine(x);
                if (sumMoreThan100 > 100)
                    break;
                number_1 = i + 1;
            }
            Console.WriteLine("Количество слагаемых = " + number_1);
            Console.Write("Сумма = " + sumMoreThan100);
        }
        static void Task11()
        {
            int y = 6;
            int sumLessThan100 = 6;
            int number_2 = 0;
            Console.WriteLine(y);
            for (int i = 1; i < 10; i++)
            {
                y += 4;
                sumLessThan100 += y;
                Console.WriteLine(y);
                number_2 = i + 1;
                if (sumLessThan100 > 100)
                {
                    sumLessThan100 -= y;
                    number_2 -= 1;
                    break;
                }
            }
            Console.WriteLine("Количество слагаемых = " + number_2);
            Console.Write("Сумма = " + sumLessThan100);
        }
        static void Task12()
        {
            Console.WriteLine("Enter number");
            Utilities.CheckNumber(Console.ReadLine(), out int numFibbonacci);
            int sum = Utilities.FibonacciSum(numFibbonacci);
            Console.WriteLine(sum);
        }
        //static void MaxNumberFromArray(int numArray)
        //{
        //    Console.Write("Enter number ");
        //    var array = new int[Utilities.NumberValidation(numArray)];
        //    var random = new Random();
        //    for (var i = 0; i < array.Length; i++)
        //    {
        //        array[i] = random.Next(-100, 100);
        //    }
        //    Utilities.ArrayPrint(array);
        //    Console.WriteLine("Answer: {0}", array.GroupBy(x => x)
        //        .Select(x => new { Value = x.Key, Count = x.Count() })
        //        .OrderByDescending(x => x.Count)
        //        .ThenBy(x => x.Value).First().Value);
        //}
        //static void ValidationSortArray(int numArray)
        //{
        //    Console.Write("Enter number ");
        //    var array = new int[Utilities.NumberValidation(numArray)];
        //    var random = new Random();
        //    for (var i = 0; i < array.Length; i++)
        //    {
        //        array[i] = random.Next(-100, 100);
        //    }
        //    Utilities.ArrayPrint(array);
        //    bool f;
        //    Console.WriteLine("Ascending:  {0}", f = array.SequenceEqual(array.OrderBy(x => x)));
        //    Console.WriteLine("Descending: {0}", f |= array.SequenceEqual(array.OrderByDescending(x => x)));
        //    Console.WriteLine("Unsorted:   {0}", !f);
        //    Console.ReadKey();
        //}
        //static void ElementsOfArray(int numArray)
        //{
        //    Console.Write("Enter number ");
        //    var array = new int[Utilities.NumberValidation(numArray)];
        //    var random = new Random();
        //    for (var i = 0; i < array.Length; i++)
        //    {
        //        array[i] = random.Next(-100, 100);
        //    }
        //    Utilities.ArrayPrint(array);
        //    Console.Write("Min = ");
        //    Console.WriteLine(array.Min());

        //    Console.Write("Max = ");
        //    Console.WriteLine(array.Max());


        //    var odd = array[0];
        //    for (int i = 1; i < array.Length; i++)
        //    {
        //        if (array[i] % 2 != 0)
        //        {
        //            if (array[i] < odd)
        //                odd = array[i];
        //        }
        //        else continue;
        //    }

        //    Console.Write("Min odd = ");
        //    Console.WriteLine(odd);
        //    var even = array[0];
        //    for (int k = 1; k < array.Length; k++)
        //    {
        //        if (array[k] % 2 == 0)
        //        {
        //            if (array[k] < even)
        //                even = array[k];
        //        }
        //        else continue;
        //    }

        //    Console.Write("Min even = ");
        //    Console.WriteLine(even);

        //    int a = array.Min();
        //    int b = array.Max();
        //    int c;

        //    c = a;
        //    a = b;
        //    b = c;

        //    Console.Write("New_Min = ");
        //    Console.WriteLine(b);


        //    Console.Write("New_Max = ");
        //    Console.WriteLine(a);
        //}
        //static void MergeTwoArray(int a, int b)
        //{
        //    Console.Write("Enter number for array_1 ");
        //    var array_1 = new int[Utilities.NumberValidation(a)];
        //    var random_1 = new Random();
        //    for (var i = 0; i < array_1.Length; i++)
        //    {
        //        array_1[i] = random_1.Next(-100, 100);
        //        Array.Sort(array_1);
        //    }

        //    Console.Write("Enter number for array_2 ");
        //    var array_2 = new int[Utilities.NumberValidation(b)];
        //    var random_2 = new Random();
        //    for (var j = 0; j < array_2.Length; j++)
        //    {
        //        array_2[j] = random_2.Next(-100, 100);
        //        Array.Sort(array_2);
        //    }
        //    Console.Write("Array_1: ");
        //    Utilities.ArrayPrint(array_1);
        //    Console.Write("Array_2: ");
        //    Utilities.ArrayPrint(array_2);

        //    var array_3 = new int[array_1.Length + array_2.Length];
        //    int n = 0;
        //    int m = 0;
        //    int k = 0;

        //    while (n < array_1.Length && m < array_2.Length)
        //        array_3[k++] = array_1[n] < array_2[m] ? array_1[n++] : array_2[m++];
        //    while (n < array_1.Length)
        //        array_3[k++] = array_1[n++];
        //    while (m < array_2.Length)
        //        array_3[k++] = array_2[m++];


        //    Console.Write("Array_3: ");
        //    Utilities.ArrayPrint(array_3);
        //}
        //static void SortArrayToFile(string path)
        //{
        //    path = @"C:\Users\Irina\Documents\array_1.txt";
        //    int[] arrayFromString;
        //    string textFromFile;
        //    using (FileStream fstream = File.OpenRead(path))
        //    {
        //        byte[] array = new byte[fstream.Length];
        //        fstream.Read(array, 0, array.Length);

        //        textFromFile = Encoding.Default.GetString(array)
        //            .Replace("\r", string.Empty)
        //            .Replace("\n", string.Empty)
        //            .Replace(" ", string.Empty)
        //            .Trim();

        //        arrayFromString = textFromFile.Split(',')
        //            .Select(x => Convert.ToInt32(x))
        //            .ToArray();
        //        fstream.Close();
        //    }
        //    Console.WriteLine($"Текст из файла: {textFromFile}");
        //    Array.Sort(arrayFromString);
        //    Console.WriteLine($"Отсортированный массив:");
        //    Utilities.ArrayPrint(arrayFromString);
        //    string[] textToFile = new string[arrayFromString.Length];
        //    for (int k = 0; k < arrayFromString.Length; k++)
        //    {
        //        textToFile[k] = Convert.ToString(arrayFromString[k]);
        //    }

        //    using (FileStream fstream_1 = new FileStream(path, FileMode.Open, FileAccess.Write))
        //    {

        //        byte[] array_1 = new byte[fstream_1.Length];
        //        for (int j = 0; j < array_1.Length; j++)
        //        {
        //            array_1[j] = Byte.Parse(textToFile[j]);
        //        }
        //        fstream_1.Write(array_1, 0, array_1.Length);
        //    }
        //}
        //static void SortReserveArrayToFile(string path)
        //{
        //    path = @"C:\Users\Irina\Documents\array_1.txt";
        //    int[] arrayFromString;
        //    string textFromFile;
        //    using (FileStream fstream = File.OpenRead(path))
        //    {
        //        byte[] array = new byte[fstream.Length];
        //        fstream.Read(array, 0, array.Length);
        //        textFromFile = Encoding.Default.GetString(array)
        //            .Replace("\r", string.Empty)
        //            .Replace("\n", string.Empty)
        //            .Replace(" ", string.Empty)
        //            .Trim();

        //        arrayFromString = textFromFile.Split(',')
        //            .Select(x => Convert.ToInt32(x))
        //            .ToArray();
        //        fstream.Close();
        //    }
        //    Console.WriteLine($"Текст из файла: {textFromFile}");

        //    Array.Sort(arrayFromString);
        //    Array.Reverse(arrayFromString);
        //    Console.WriteLine($"Отсортированный массив:");
        //    Utilities.ArrayPrint(arrayFromString);
        //    string[] textToFile = new string[arrayFromString.Length];
        //    for (int k = 0; k < arrayFromString.Length; k++)
        //    {
        //        textToFile[k] = Convert.ToString(arrayFromString[k]);
        //    }

        //    using (FileStream fstream_1 = new FileStream(path, FileMode.Open, FileAccess.Write))
        //    {

        //        byte[] array_1 = new byte[fstream_1.Length];
        //        for (int j = 0; j < array_1.Length; j++)
        //        {
        //            array_1[j] = Byte.Parse(textToFile[j]);
        //        }

        //        fstream_1.Write(array_1, 0, array_1.Length);
        //    }
        //}
        //static void ShiftArray(int n)
        //{
        //    Console.Write("Enter number for array ");
        //    var array = new int[Utilities.NumberValidation(n)];
        //    var random = new Random();
        //    for (var i = 0; i < array.Length; i++)
        //    {
        //        array[i] = random.Next(-100, 100);

        //    }
        //    int[] array_1 = new int[array.Length];
        //    Console.WriteLine("Enter how many units to move the array by");
        //    int m = 0;
        //    m = Utilities.NumberValidation(m);
        //    int k = 0;
        //    while (m > array.Length)
        //    {
        //        Console.WriteLine("You enter a value greater than the length of the array. Try again: ");
        //        Console.Write("m = ");
        //        m = Utilities.NumberValidation(m);
        //    }
        //    do
        //    {
        //        int i = 0;
        //        if (m > 0)
        //        {
        //            i = array.Length - 1 - k;
        //        }
        //        for (int j = 0; j < array_1.Length; j++)
        //        {
        //            array_1[j] = array[i];
        //            i++;
        //            if (i == array.Length)
        //            {
        //                i = 0;
        //            }
        //        }
        //        k++;
        //    } while (k < m);

        //    Console.WriteLine("The main array:");
        //    Utilities.ArrayPrint(array);
        //    Console.WriteLine("Shifted array:");
        //    Utilities.ArrayPrint(array_1);
        //    Console.ReadLine();
        //}
        //static void FormatString()
        //{
        //    String hello = "Привет!";
        //    String name = "Меня зовут Ирина.";
        //    String age = "Мне 22 года.";

        //    Console.WriteLine("{0} {1} {2}", hello, name, age);
        //    Console.Write($"{ hello} {name} {age}");
        //}
        //static void ArrayString()
        //{
        //    string[] array = { "apple", "banana", "orange", "kiwi", "mango" };
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Console.Write($"{array[i]}, ");
        //    }

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Console.WriteLine($"{array[i]}");
        //    }
        //}
        //static void ComparisonString()
        //{
        //    string hey = "привет";
        //    string hello = "здравствуйте";

        //    int result = String.Compare(hey, hello);
        //    Console.WriteLine(result);
        //    if (result < 0)
        //    {
        //        Console.WriteLine("Строка hey перед строкой hello");
        //    }
        //    else if (result > 0)
        //    {
        //        Console.WriteLine("Строка hey стоит после строки hello");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Строки hey и hello идентичны");
        //    }



        //    string twenty = "двадцать";
        //    string twelve = "двенадцать";

        //    int result_numbers = String.Compare(twenty, twelve);
        //    Console.WriteLine(result_numbers);
        //    if (result_numbers < 0)
        //    {
        //        Console.WriteLine("Строка twenty перед строкой twelve");
        //    }
        //    else if (result_numbers > 0)
        //    {
        //        Console.WriteLine("Строка twenty стоит после строки twelve");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Строки twenty и twelve идентичны");
        //    }



        //    string sinus = "синус";
        //    string sinusoid = "синусоида";

        //    int result_math = String.Compare(sinus, sinusoid);
        //    Console.WriteLine(result_math);
        //    if (result_math < 0)
        //    {
        //        Console.WriteLine("Строка sinus перед строкой sinusoid");
        //    }
        //    else if (result_math > 0)
        //    {
        //        Console.WriteLine("Строка sinus стоит после строки sinusoid");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Строки sinus и sinusoid идентичны");
        //    }


        //    string number_1 = "14";
        //    string number_2 = "81";

        //    int result_numerals = String.Compare(number_1, number_2);
        //    Console.WriteLine(result_numerals);
        //    if (result_numerals < 0)
        //    {
        //        Console.WriteLine("Строка number_1 перед строкой number_2");
        //    }
        //    else if (result_numerals > 0)
        //    {
        //        Console.WriteLine("Строка number_1 стоит после строки number_2");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Строки number_1 и number_1 идентичны");
        //    }

        //}
        //static void StringIndexO()
        //{
        //    string s1 = "хорошо в лесу";
        //    char ch1 = 'о';
        //    int indexOfCharString1 = s1.IndexOf(ch1);
        //    if (indexOfCharString1 < 0)
        //    {
        //        Console.WriteLine("1. В этой фразе не встречается буква 'o' ");
        //    }
        //    else
        //    {
        //        Console.Write("1. индекс первого вхождения буквы 'o' - ");
        //        Console.WriteLine(indexOfCharString1);
        //    }

        //    string s2 = "Эх, дороги, пыль да туман";
        //    char ch2 = 'о';
        //    int indexOfCharString2 = s2.IndexOf(ch2);
        //    if (indexOfCharString2 < 0)
        //    {
        //        Console.WriteLine("2. В этой фразе не встречается буква 'o' ");
        //    }
        //    else
        //    {
        //        Console.Write("2. индекс первого вхождения буквы 'o' - ");
        //        Console.WriteLine(indexOfCharString2);
        //    }

        //    string s3 = "Семнадцать вариантов решения";
        //    char ch3 = 'о';
        //    int indexOfCharString3 = s3.IndexOf(ch3);
        //    if (indexOfCharString3 < 0)
        //    {
        //        Console.WriteLine("3. В этой фразе не встречается буква 'o' ");
        //    }
        //    else
        //    {
        //        Console.Write("3. индекс первого вхождения буквы 'o' - ");
        //        Console.WriteLine(indexOfCharString3);
        //    }
        //}
        //static void StringIndexY()
        //{
        //    string s1 = "Где такое интересное место?";
        //    char ch1 = 'у';
        //    int LastindexOfCharString1 = s1.LastIndexOf(ch1);
        //    if (LastindexOfCharString1 < 0)
        //    {
        //        Console.WriteLine("1. В этой фразе не встречается буква 'у' ");
        //    }
        //    else
        //    {
        //        Console.Write("1. индекс последнего вхождения буквы 'у' - ");
        //        Console.WriteLine(LastindexOfCharString1);
        //    }

        //    string s2 = "У меня дома есть ноутбук.";
        //    char ch2 = 'у';
        //    int LastindexOfCharString2 = s2.LastIndexOf(ch2);
        //    if (LastindexOfCharString2 < 0)
        //    {
        //        Console.WriteLine("2. В этой фразе не встречается буква 'у' ");
        //    }
        //    else
        //    {
        //        Console.Write("2. индекс последнего вхождения буквы 'у' - ");
        //        Console.WriteLine(LastindexOfCharString2);
        //    }

        //    string s3 = "Винтажный стул";
        //    char ch3 = 'у';
        //    int LastindexOfCharString3 = s3.LastIndexOf(ch3);
        //    if (LastindexOfCharString3 < 0)
        //    {
        //        Console.WriteLine("3. В этой фразе не встречается буква 'у' ");
        //    }
        //    else
        //    {
        //        Console.Write("3. индекс последнего вхождения буквы 'у' - ");
        //        Console.WriteLine(LastindexOfCharString3);
        //    }
        //}
        //static void StringInsert()
        //{
        //    string text = "Какой день";
        //    string subString = "замечательный ";
        //    text = text.Insert(6, subString);
        //    Console.WriteLine(text);
        //}
        //static void StringReplace()
        //{
        //    string text = "Привет, я иду в магазин";
        //    text = text.Replace("магазин", "парк");
        //    Console.WriteLine(text);
        //}
        //static void StringDelete()
        //{
        //    string text = "Сегодня в зоопарке я видел большого жирафа";
        //    text = text.Replace("большого", "");
        //    Console.WriteLine(text);
        //}
        //static void StringRegister()
        //{
        //    string text = "ПрыгаЮщие БуквЫ";
        //    Console.WriteLine(text.ToLower());
        //    Console.WriteLine(text.ToUpper());
        //}
        //static void StringSplit()
        //{
        //    string text = "Первый рабочий день прошел на ура";
        //    string[] words = text.Split(new char[] { ' ' });
        //    foreach (string s in words)
        //    {
        //        Console.WriteLine(s);
        //    }
        //}
    }

}



