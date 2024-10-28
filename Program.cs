using Microsoft.VisualBasic;
using System.Linq.Expressions;

namespace Unit_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            (string name, int age, DateTime birthdate) anketa;

            Console.Write("Введите ваше имя: ");
            anketa.name = Console.ReadLine();
            // string name = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());
            // byte age = (byte)int.Parse(Console.ReadLine());
            Console.Write("Введите вашу дату рождения по примеру \"дд.мм.гггг \": ");
            anketa.birthdate = Convert.ToDateTime(Console.ReadLine());
            /* string date = Console.ReadLine();
            DateTime birthdate = DateTime.Parse(date); */
            Console.WriteLine("Ваше имя {0}, ваш возраст {1} и ваша дата рождения {2}", anketa.name, anketa.age, anketa.birthdate.ToString("dd.MM.yyyy"));
            // Console.WriteLine("Your name is {0}, your age is {1} and your birthdate is " + birthdate.ToString("dd.MM.yyyy"), name, age);

        }
    }
}
