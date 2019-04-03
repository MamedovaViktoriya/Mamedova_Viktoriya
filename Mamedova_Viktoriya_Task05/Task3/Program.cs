using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassTriangle;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны треугольника:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            ClassTriangle.ClassTriangle triangle = new ClassTriangle.ClassTriangle(a, b, c);
            Console.WriteLine($"Периметр треугольника = {triangle.Perimeter}");
            Console.WriteLine($"Площадь треугольника = {triangle.Square}");
            Console.ReadKey();
        }
    }
}
