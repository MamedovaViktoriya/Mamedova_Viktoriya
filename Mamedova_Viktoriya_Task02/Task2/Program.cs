using HelperFunctions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите число:");
            n = HelperFunction.ReadNumber();
            string s = string.Empty;

            for (int i = 0; i < n; i++)
            {
                s = new string('*', i);
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }
}
