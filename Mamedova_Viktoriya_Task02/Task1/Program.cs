using HelperFunctions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            Console.WriteLine("Введите сторону a:");
            a = HelperFunction.ReadNumber();
            Console.WriteLine("Введите сторону b:");
            b = HelperFunction.ReadNumber();
            Console.WriteLine($"Площадь прямоугольника:{a * b}");
            Console.ReadLine();
        }
    }
}
