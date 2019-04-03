using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassRound;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите X координату центра окружности: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите Y координату центра окружности: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите радиус окружности: ");
            int radius = int.Parse(Console.ReadLine());
            Round round = new Round(x, y, radius);
            Console.WriteLine($"Площадь круга = {round.GetArea()}");
            Console.WriteLine($"Длина окружности = {round.GetLength()}");
            Console.ReadKey();
        }
    }
}
