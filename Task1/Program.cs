using System; ConsoleKey

namespace Task1
{
    class Program
    {
        static void Main()
        {
            void TextBox1KeyPress(object sender, KeyPressEventArgs e)
            {

                if (Char.IsDigit(e.KeyChar)) return;
                else
                    e.Handled = true;
            }
            int sum = 0;
            int n;
            Console.WriteLine("Enter three-digit number ");
            do
            {
                n = Int32.Parse(Console.ReadLine());
                if (n.ToString().Length != 3)
                {
                    Console.WriteLine("Error. Enter exactly three-digit number ");
                }
            } while (n.ToString().Length != 3);

           
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine("sum of numbers " + sum);
        }
    }
}