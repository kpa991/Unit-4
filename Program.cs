using System.Linq.Expressions;

namespace Unit_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 1, 2, -3, 4, -5, 6, -7, 8, - 9};
            int Negative = 0;
            int Positive = 0;

            foreach (int i in array)
            {
                if (i < 0)
                { 
                    Negative ++;
                } else 
                { 
                    Positive ++;
                }
            }
            
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Кол-во положительных чисел в массиве: " + Positive);
            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Кол-во отрицательных чисел в массиве: " + Negative);
            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey();
        }
    }
}
