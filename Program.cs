using Microsoft.VisualBasic;
using System.Linq.Expressions;

namespace Unit_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            (string FirstName, string SurName, string Login, int LoginLenght, bool HasPet, double Age, string[] LoveColors) User;

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите ваше имя: ");
                User.FirstName = Console.ReadLine();

                Console.Write("Введите вашу фамилию: ");
                User.SurName = Console.ReadLine();

                Console.Write("Введите ваш логин: ");
                User.Login = Console.ReadLine();

                User.LoginLenght = User.Login.Length;

                Console.WriteLine("Есть ли у вас животные? Да или Нет");
                var answer = Console.ReadLine();
                if (answer == "Да")
                {
                    User.HasPet = true;
                }
                else
                {
                    User.HasPet = false;
                }

                Console.Write("Введите ваш возраст: ");
                User.Age = Convert.ToDouble(Console.ReadLine());

                User.LoveColors = new string[3];
                Console.WriteLine("Введите три любимых цвета:");

                for (int k = 0; k < User.LoveColors.Length; k++)
                {
                    User.LoveColors[k] = Console.ReadLine();
                }
            }

            
        }
    }
}
