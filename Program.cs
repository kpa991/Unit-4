using System.Linq.Expressions;

namespace Unit_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int temp = 0;

            Console.WriteLine("Начальный массив:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = j + 1; k < arr.GetLength(1); k++)
                    {
                        if (arr[i, j] > arr[i, k])
                        {
                            temp = arr[i, j];
                            arr[i, j] = arr[i, k];
                            arr[i, k] = temp;
                        }
                    }
                }
            }

            Console.WriteLine("Отсортированный массив:");
            for (int i = 0;i < arr.GetLength(0); i++)
            {
                for(int j = 0;j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
