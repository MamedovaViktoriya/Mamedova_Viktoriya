using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HelperFunctions;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Одномерный массив случайных чисел:");
            int[] randomArray = new int[15];
            randomArray = HelperFunction.CreateRandomArray(randomArray);
            randomArray = HelperFunction.SortArray(randomArray);
            randomArray = HelperFunction.ShowArray(randomArray);
            Console.WriteLine($"Минимальное значение массива = {randomArray[0]}");
            Console.WriteLine($"Максимальное значение массива = {randomArray[randomArray.Length - 1]}");
            Console.ReadKey();
        }
    }
}
