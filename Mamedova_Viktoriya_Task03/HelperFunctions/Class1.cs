using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperFunctions
{
    public class HelperFunction
    {
        public static int[] CreateRandomArray(int[] randomArray)
        {
            Random random = new Random();
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = random.Next(-15, 15);
            }
            return randomArray;
        }

        public static int[] SortArray(int[] array)
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

        public static int[] ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Элемент[{i}] = {array[i]} ");
            }

            return array;
        }
    }      
}


