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
    }
}
