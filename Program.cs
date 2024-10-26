namespace Unit_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int temp;
            int sum =0;

            Console.Write("начальный массив: ");
            for (int i =0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");  
            }
            
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }

            }

            Console.Write("От сортированный массив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+ " ");
            }
            Console.WriteLine();
            for (int i = 0;i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Сумма всех элементов массива: " + sum);

        }
    }
}
