using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            StringBuilder sb = new StringBuilder();
            Stopwatch timer = new Stopwatch();
            int n = 100;
            timer.Start();

            for (int i = 0; i < n; i++)
            {
                str += "*";
            }

            timer.Stop();
            Console.WriteLine($"String: {timer.Elapsed.TotalMilliseconds}");
            timer.Reset();
            timer.Start();

            for (int i = 0; i < n; i++)
            {
                sb.Append("*");
            }

            timer.Stop();
            Console.WriteLine($"StringBuilder: {timer.Elapsed.TotalMilliseconds}");
            Console.ReadKey();
        }
    }
}
