using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperFunctions
{
    public class HelperFunction
    {
        public static int ReadNumber()
        {
            var input = Console.ReadLine();
            int number;

            while (!int.TryParse(input, out number) || number <= 0)
            {
                Console.WriteLine("Ошибка, введите любое число больше нуля!");
                input = Console.ReadLine();
                int.TryParse(input, out number);
            }

            return number;
        }
    }
}
