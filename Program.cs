namespace Unit_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свое имя");
            var name = Console.ReadLine();

            Console.WriteLine("Ваше имя по букввам: ");

            for ( int i = name.Length - 1; i >= 0 ; i--)
            {
                Console.WriteLine(name[i] + " "); 
            }

            Console.ReadKey();
        }
    }
}
