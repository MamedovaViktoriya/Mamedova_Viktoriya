using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HelperFunctions;

namespace Task3
{
    class Program
    {
        static int Sum(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    sum += array[i];
                }
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Одномерный массив случайных чисел:");
            int[] randomArray = new int[15];
            randomArray = HelperFunction.CreateRandomArray(randomArray);

            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.WriteLine($"Элемент[{i + 1}] = {randomArray[i]}");
            }

            Console.WriteLine($"Сумма неотрицательных элементов массива = {Sum(randomArray)}");
            Console.ReadKey();
        }
    }
}
