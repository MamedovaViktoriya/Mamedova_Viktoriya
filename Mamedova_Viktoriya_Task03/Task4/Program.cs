using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static int SumArray(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += array[i, j];
                    }
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Двумерный массив случайных чисел:");
            int[,] RandomArray = new int[3, 3];
            Random random = new Random();

            for (int i = 0; i < RandomArray.GetLength(0); i++)
            {
                for (int j = 0; j < RandomArray.GetLength(1); j++)
                {
                    RandomArray[i, j] = random.Next(-15, 15);
                }
        }

            for (int i = 0; i < RandomArray.GetLength(0); i++)
            {
                for (int j = 0; j < RandomArray.GetLength(1); j++)

                {
                    Console.WriteLine($"Элемент[{i + 1},{j + 1}] = {RandomArray[i, j]} ");
                }
            }

            Console.WriteLine($"Сумма элементов массива, стоящих на четных позициях равна = {SumArray(RandomArray)}");
            Console.ReadKey();
        }
    }
}
