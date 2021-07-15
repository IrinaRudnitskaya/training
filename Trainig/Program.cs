using System;

namespace Trainig
{
    static class Utilities
    {
        public static int LengthValidation(int number)
        {
            while (true)
            {
                try
                {
                    do
                    {
                        number = Int32.Parse(Console.ReadLine());
                        if (number.ToString().Length != 3)
                        {
                            Console.WriteLine("Error. Enter exactly three-digit number ");
                        }
                    }
                    while (number.ToString().Length != 3);

                    return (number);
                }
                catch (Exception)
                {
                    Console.WriteLine("You can't enter symbols. Please, enter the number.");
                }
            }
        }
        public static int NumberValidation(int number)
        {
            while (true)
            {

                string input = (Console.ReadLine());
                if (int.TryParse(input, out number))
                {
                    return number;
                }

                else
                {
                    Console.WriteLine("You can't enter symbols. Please, enter the number.");
                }

            }
        }
        public static int RangeValidation(int number)
        {
            while (true)
            {

                if (((1 < number && number <= 20)))
                {
                    return number;
                }

                else
                {
                    Console.WriteLine("Error. Enter a numbers from the correct range");
                }

            }
        }
    }
    class Program
    {


        static void Main(string[] args)
        {
            //Console.WriteLine("Enter three-digit number ");
            //var number = 0;
            //number = Utilities.LengthValidation(number);
            //var sum = SumOfDigits(number);

            //Console.WriteLine("sum of numbers " + sum);


            ////

            //Console.WriteLine("Enter numbers ");
            //int num = 0;
            //MaxSumOfDigits(num);

            /////
            //Console.WriteLine("Enter number of numbers");
            //int nOfNumbers = 0;
            //SumOfThreeFirstNum(nOfNumbers);


            //Console.WriteLine("Enter number of numbers");
            //int kOfNumbers = 0;
            //SumOfThreeLastNum(kOfNumbers);

            /////
            ///
            //int side_1 = 0;
            //int side_2 = 0;
            //Rectangle(side_1, side_2);

            //int threeangle_side = 0;
            //Threeangle_1(threeangle_side);

            //int Threeangle_side = 0;
            //Threeangle_2(Threeangle_side);

            //int Threeangle_Side = 0;
            //Threeangle_3(Threeangle_Side);

            //int sum = 6;
            //NumberOfTerms(sum);

            //int a = 6;
            //int sumOfTenTerms = 6;
            //SumOfTenTerms(a, sumOfTenTerms);

            //int b = 1;
            //int sumOfElevenTerms = 1;
            //SumOfElevenTerms(b, sumOfElevenTerms);

            //int x = 6;
            //int sumMoreThan100 = 6;
            //int number_1 = 0;
            //SumMoreThan100(x, sumMoreThan100, number_1);

            int y = 6;
            int sumLessThan100 = 6;
            int number_2 = 0;
            SumLessThan100(y, sumLessThan100, number_2);



        }



        static int SumOfDigits(int n)
        {
            var sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }

            return (sum);
        }

        static void MaxSumOfDigits(int num)
        {
            int max_sum = 0;
            int max_num = 0;
            int num_1;
            do
            {
                num_1 = Utilities.NumberValidation(num);
                var sum = SumOfDigits(num_1);
                if (sum > max_sum)
                {
                    max_sum = sum;
                    max_num = num_1;
                }
            }
            while (num_1 != 0);
            Console.WriteLine("Number with the maximum sum of digits " + max_num);
            Console.WriteLine("Sum = " + max_sum);






        }


        static void SumOfThreeFirstNum(int n)
        {

            int num = 0;
            int sum_odd = 0;
            int e = 0;
            while (n <= 0)
            {
                n = Utilities.NumberValidation(n);
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Enter number {0}:", i + 1);
                    num = Utilities.NumberValidation(num);

                    if (num % 2 != 0)
                    {
                        sum_odd += num;
                        e++;
                    }
                }
                Console.WriteLine("Sum of the first three odd numbers: {0}", sum_odd);
                Console.WriteLine(e);

            }
        }

        static void SumOfThreeLustNum(int n)
        {
            int numbers;
            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            int num = 0;

            numbers = Utilities.NumberValidation(n);
            for (int i = 0; i < numbers; i++)
            {
                Console.WriteLine("Enter number {0}:", i + 1);
                num = Utilities.NumberValidation(num);
                if (num % 2 != 0)
                {
                    n1 = n2;
                    n2 = n3;
                    n3 = num;
                }
            }
            Console.WriteLine("Sum of the last three odd numbers: {0}" + n1 + n2 + n3);
        }

        static void Rectangle(int m, int n)
        {
            Console.WriteLine("Enter 'n' in beetwin [1;20]");
            n = Utilities.NumberValidation(n);
            Utilities.RangeValidation(n);
            Console.WriteLine("Enter 'm' in beetwin [1;20]");
            m = Utilities.NumberValidation(m);
            Utilities.RangeValidation(m);
            for (int i = 1; i <= n; i++)
            {

                for (int k = 1; k < m; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
        }
        static void Threeangle_1(int m)
        {
            Console.WriteLine("Enter 'm' in beetwin [1;20]");
            m = Utilities.NumberValidation(m);
            Utilities.RangeValidation(m);
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
            for (int b = 0; b < m; b++)
            {
                Console.Write("*");
            }
            Console.Read();
        }

        static void Threeangle_2(int m)
        {
            Console.WriteLine("Enter 'm' in beetwin [1;20]");
            m = Utilities.NumberValidation(m);
            Utilities.RangeValidation(m);
            for (int i = 0; i < m; i++)
            {
                int spacesBefore = Math.Abs(m / 2 - i);
                int starsCount = (m - 2 * spacesBefore);
                Console.WriteLine("{0}{1}", new string(' ', spacesBefore), new string('*', starsCount));
            }
            Console.WriteLine();
        }
        static void Threeangle_3(int m)
        {
            Console.WriteLine("Enter 'm' in beetwin [1;20]");
            m = Utilities.NumberValidation(m);
            Utilities.RangeValidation(m);
            for (int i = 1; i <= m; i++)
            {

                for (int k = i + 1; k <= m; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
        }
        static void NumberOfTerms(int sum)
        {
            for (int i = 1; i <= 46; i++)
            {
                if (i % 4 != 0) continue;
                sum += i;
            }
            int s = 0;
            for (int k = 2; k <= 46; k++)
                if (k % 4 == 0) s++;

            Console.WriteLine(sum);
            Console.WriteLine(s);
        }
        static void SumOfTenTerms(int a, int sumOfTenTerms)
        {
            Console.WriteLine(a);
            for (int i = 1; i < 10; i++)
            {
                a += 4;
                sumOfTenTerms += a;

                Console.WriteLine(a);
            }

            Console.WriteLine("Sum of the numbers = " + sumOfTenTerms);
        }
        static void SumOfElevenTerms(int b, int sumOfElevenTerms)
        {
            Console.WriteLine(b);
            for (int i = 1; i < 11; i++)
            {
                b = (b * 2);
                sumOfElevenTerms += b;

                Console.WriteLine(b);
            }

            Console.WriteLine("Sum of the numbers = " + sumOfElevenTerms);
        }
        static void SumMoreThan100(int x, int sumMoreThan100, int number_1)
        {
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

            Console.Write("Количество слагаемых = ");
            Console.WriteLine(number_1);
            Console.Write("Сумма = ");
            Console.WriteLine(sumMoreThan100);
        }
        static void SumLessThan100(int y, int sumLessThan100, int number_2)
        {
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

            Console.Write("Количество слагаемых = ");
            Console.WriteLine(number_2);
            Console.Write("Сумма = ");
            Console.WriteLine(sumLessThan100);
        }




    }

}


