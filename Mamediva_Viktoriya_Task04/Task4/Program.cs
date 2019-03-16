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
            Stopwatch sw = new Stopwatch();
            int n = 100;
            sw.Start();

            for (int i = 0; i < n; i++)
            {
                str += "*";
            }

            sw.Stop();
            Console.WriteLine($"String: {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            sw.Start();

            for (int i = 0; i < n; i++)
            {
                sb.Append("*");
            }

            sw.Stop();
            Console.WriteLine($"StringBuilder: {sw.Elapsed.TotalMilliseconds}");
            Console.ReadKey();
        }
    }
}