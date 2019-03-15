using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HelperFunctions;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите число:");
            n = HelperFunction.ReadNumber();

            for (int i = 1; i <= n; i++)
            {
                var spaces = n - i;
                string s = new string('*', i * 2 - 1);
                var s2 = new string(' ', spaces);
                var s3 = s2 + s;
                Console.WriteLine(s3);
            }

            Console.ReadLine();
        }
    }
}
