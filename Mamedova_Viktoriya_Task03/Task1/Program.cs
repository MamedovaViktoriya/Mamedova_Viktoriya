using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HelperFunctions;

namespace Task1
{
    class Program
    {
        static int[] SortArray(int[] array)
        {
            int temp = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Одномерный массив случайных чисел:");
            int[] randomArray = new int[15];
            randomArray = HelperFunction.CreateRandomArray(randomArray);
            randomArray = SortArray(randomArray);

            for (int i = 0; i < randomArray.Length; i++)

            {
                Console.WriteLine($"Элемент[{i}] = {randomArray[i]} ");
            }

            Console.WriteLine($"Минимальное значение массива = {randomArray[0]}");
            Console.WriteLine($"Максимальное значение массива = {randomArray[randomArray.Length - 1]}");
            Console.ReadKey();
        }
    }
}
