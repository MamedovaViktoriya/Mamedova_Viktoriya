using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите любое вещественное число: ");
            string input = Console.ReadLine();
            Regex common = new Regex("^[-0-9]*[.,]?[0-9]+$");
            Regex sience = new Regex("^[-0-9][.,][0-9]*[Ee][-0-9]+$");

            if (common.IsMatch(input))
            {
                Console.WriteLine("Это число в обычной нотации");
            }

            else if (sience.IsMatch(input))
            {
                Console.WriteLine("Это число в научной нотации");
            }

            else
            {
                Console.WriteLine("Это не число");
            }

            Console.ReadKey();
        }
    }
}
