namespace Unit_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[3][];
            array[0] = new int[] { 1, 2 };
            array[1] = new int[] {1, 2, 3 };
            array[2] = new int[] {1, 2, 3, 4, 5 };

            for (int i = 0; i < array.Length; i++)
            {

                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j]);
                }

                Console.WriteLine();
            }

            foreach (var num in array)
            {
                foreach (var item in num)
                {
                    Console.Write(item + " ");
                }
            }


        }
    }
}
