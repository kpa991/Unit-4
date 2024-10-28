using System.Linq.Expressions;

namespace Unit_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int Negative = 0;
            int Positive = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < 0)
                    {
                        Negative++;
                    }else
                    {
                        Positive++;
                    }
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
