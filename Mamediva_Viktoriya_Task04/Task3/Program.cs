using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool trueInput = false;

            while (!trueInput)
            {
                Console.WriteLine("Выберите интересующие культуры: ");
                Console.WriteLine("1: ru vs en");
                Console.WriteLine("2: en vs invariant");
                Console.WriteLine("3: ru vs invariant");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        trueInput = true;
                        OutputCulture("ru", "en");
                        break;
                    case "2":
                        trueInput = true;
                        OutputCulture("en", "invariant");
                        break;
                    case "3":
                        trueInput = true;
                        OutputCulture("ru", "invariant");
                        break;
                    default:
                        Console.WriteLine("Выберите один из представленных вариантов!");
                        break;
                }
            }

            Console.ReadKey();
        }

        public static void OutputCulture(string firstCulture, string secondCulture)
        {
            DateTime now = DateTime.Now;
            double firstNum = 48756.2539;
            string date = "d";
            string secondNum = "F";
            string numInvar = "e4";

            if (secondCulture != "invariant")
            {
                Console.WriteLine($"Число {firstCulture} " +
                    $"{firstNum.ToString(secondNum, CultureInfo.CreateSpecificCulture(firstCulture))}" +
                    $" vs Число {secondCulture}" +
                    $" {firstNum.ToString(numInvar, CultureInfo.CreateSpecificCulture(secondCulture))}");

                Console.WriteLine($"Дата {firstCulture} " +
                    $"{now.ToString(date, CultureInfo.CreateSpecificCulture(firstCulture))} " +
                    $"vs Дата {secondCulture}" +
                    $" {now.ToString(date, CultureInfo.CreateSpecificCulture(secondCulture))}");
            }

            else
            {
                Console.WriteLine($"Число {firstCulture} " +
                    $"{firstNum.ToString(secondNum, CultureInfo.CreateSpecificCulture(firstCulture))}" +
                    $" vs Число {secondCulture} " +
                    $"{firstNum.ToString(numInvar, CultureInfo.InvariantCulture)}");

                Console.WriteLine($"Дата {firstCulture} " +
                    $"{now.ToString(date, CultureInfo.CreateSpecificCulture(firstCulture))} " +
                    $"vs Дата {secondCulture}" +
                    $" {now.ToString(date, DateTimeFormatInfo.InvariantInfo)}");
            }
        }
    }
}