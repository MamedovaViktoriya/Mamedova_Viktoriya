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
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            char[] exception = { ' ', ',', '.', ';', '?', '!', ':', '-', };
            string[] words = input.Split(exception, StringSplitOptions.RemoveEmptyEntries);
            var amount = 0;
            var number = 0;
            var WordCount = 0f;

            foreach (string word in words)
            {
                if (!int.TryParse(word, out number))
                {
                    amount += word.Length;
                    WordCount++;
                    Console.WriteLine($"Слово: {word}; Длина = {word.Length}");
                }
            }

            Console.WriteLine($"Средняя длина слова в строке = {amount / WordCount}");
            Console.ReadKey();
        }
    }
}
