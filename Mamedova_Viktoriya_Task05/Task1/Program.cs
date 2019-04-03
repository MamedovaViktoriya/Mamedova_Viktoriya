using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassUser;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите отчество: ");
            string patronymic = Console.ReadLine();
            Console.WriteLine("Введите дату рождения: ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            User user = new User(surname, name, patronymic, birthday);
            Console.WriteLine($"Пользователь = {surname} {name} {patronymic}");
            Console.WriteLine($"Возраст = {user.Age}");
            Console.ReadKey();
        }
    }
}