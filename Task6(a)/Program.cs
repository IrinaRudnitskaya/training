using System;

namespace Task6
{
    class Program
    {
        static void Main()
        {
            int n = 0;
            for (int i = 1; i<51; i++)
            {
                n += i;            
            }
            Console.WriteLine(n);



            int b = 0;
            for (int j = 1; j<51; j++)
            {
                if (!(j % 2 != 0))
                    b += j;
            }
            Console.WriteLine(b);


            int c = 0;
            for (int k = 1; k < 51; k++)
            {
                if (k % 2 != 0)
                    c += k;
            }
            Console.WriteLine(c);
        }
    }
}
