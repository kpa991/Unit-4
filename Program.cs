namespace Unit_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свое имя");
            var name = Console.ReadLine();

            Console.WriteLine("Ваше имя по букввам: ");

            foreach(var ch in name)
            {
                Console.Write(ch + " ");
            }

            Console.WriteLine("Последняя буква вашего именни: {0}",name[name.Length - 1]);

            Console.ReadKey();
        }
    }
}
