using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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
            int[] RandomArray = new int[15];
            Random random = new Random();

            for (int i = 0; i < RandomArray.Length; i++)
            {
                RandomArray[i] = random.Next(-15, 15);
            }

            RandomArray = SortArray(RandomArray);

            for (int i = 0; i < RandomArray.Length; i++)

            {
                Console.WriteLine($"Элемент[{i}] = {RandomArray[i]} ");
            }

            Console.WriteLine($"Минимальное значение массива = {RandomArray[0]}");
            Console.WriteLine($"Максимальное значение массива = {RandomArray[RandomArray.Length - 1]}");
            Console.ReadKey();
        }
    }
}