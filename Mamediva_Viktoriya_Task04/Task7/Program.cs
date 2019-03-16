using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string input = Console.ReadLine();
            int time = Regex.Matches(input, @"(([0-1][0-9])|(2[0-3])|([0-9])):([0-5][0-9])").Count;
            Console.WriteLine($"Время в тексте присутствует {time} раз.");
            Console.ReadKey();
        }
    }
}
