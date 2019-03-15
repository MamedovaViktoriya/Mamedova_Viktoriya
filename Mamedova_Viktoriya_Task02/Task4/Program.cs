using HelperFunctions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите число:");
            n = HelperFunction.ReadNumber();

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.WriteLine("{0}{1}", new string(' ', n - j), new string('*', 2 * j + 1));
                }
            }

            Console.ReadLine();
        }
    }
}
