using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static int Sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                }
            }
            return sum;
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

            for (int i = 0; i < RandomArray.Length; i++)
            {
                Console.WriteLine($"Элемент[{i + 1}] = {RandomArray[i]}");
            }

            Console.WriteLine($"Сумма неотрицательных элементов массива = {Sum(RandomArray)}");
            Console.ReadKey();
        }
    }
}
