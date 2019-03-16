using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите HTML текст: ");
            string input = Console.ReadLine();
            Regex regex = new Regex("<.*?>");
            string result = regex.Replace(input, "_");
            Console.WriteLine($"Результат замены: {result}");
            Console.ReadKey();
        }
    }
}
