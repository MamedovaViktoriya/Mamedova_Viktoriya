using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstStr = "";
            string secondStr = "";
            StringBuilder sb = new StringBuilder();
            Console.Write("Введите первую строку: ");
            firstStr = Console.ReadLine();
            Console.Write("Введите вторую строку: ");
            secondStr = Console.ReadLine();

            foreach (char symbol in firstStr)
            {
                if (secondStr.Contains(symbol))
                {
                    sb.Append(symbol);
                }
                sb.Append(symbol);
            }

            Console.WriteLine($"Удваивание всех символов первой строки, принадлежащих второй строке:");
            Console.Write(sb);
            Console.ReadKey();
        }
    }
}
