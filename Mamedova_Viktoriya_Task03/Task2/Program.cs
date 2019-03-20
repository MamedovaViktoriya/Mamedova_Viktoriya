using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static int[,,] ChangeToZero(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        if (array[i, j, k] < 0)
                        {
                            array[i, j, k] = 0;
                        }
                    }
                }
            }
            return array;
        }

        static void Main(string[] args)
        {
            int[,,] RandomArray = new int[3, 3, 3];
            Random random = new Random();
            for (int i = 0; i < RandomArray.GetLength(0); i++)
            {
                for (int j = 0; j < RandomArray.GetLength(1); j++)
                {
                    for (int k = 0; k < RandomArray.GetLength(2); k++)
                    {
                        RandomArray[i, j, k] = random.Next(-10, 10);
                    }
                }
            }

            for (int i = 0; i < RandomArray.GetLength(0); i++)
            {
                for (int j = 0; j < RandomArray.GetLength(1); j++)
                {
                    for (int k = 0; k < RandomArray.GetLength(2); k++)
                    {
                        Console.WriteLine($"Элемент исходного массива[{i + 1},{j + 1},{k + 1}] = {RandomArray[i, j, k]} ");
                        RandomArray = ChangeToZero(RandomArray);
                        Console.WriteLine($"Элемент измененного массива[{i + 1},{j + 1},{k + 1}] = {RandomArray[i, j, k]} ");
                    }
                }using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static int[,,] ChangeToZero(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        if (array[i, j, k] > 0)
                        {
                            array[i, j, k] = 0;
                        }
                    }
                }
            }

            return array;
        }

        static void Main(string[] args)
        {
            int[,,] randomArray = new int[3, 3, 3];
            Random random = new Random();

            for (int i = 0; i < randomArray.GetLength(0); i++)
            {
                for (int j = 0; j < randomArray.GetLength(1); j++)
                {
                    for (int k = 0; k < randomArray.GetLength(2); k++)
                    {
                        randomArray[i, j, k] = random.Next(-15, 15);
                    }
                }
            }

            for (int i = 0; i < randomArray.GetLength(0); i++)
            {
                for (int j = 0; j < randomArray.GetLength(1); j++)
                {
                    for (int k = 0; k < randomArray.GetLength(2); k++)
                    {
                        Console.WriteLine($"Элемент исходного массива[{i + 1},{j + 1},{k + 1}] = {randomArray[i, j, k]} ");
                        randomArray = ChangeToZero(randomArray);
                        Console.WriteLine($"Элемент измененного массива[{i + 1},{j + 1},{k + 1}] = {randomArray[i, j, k]} ");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
            
