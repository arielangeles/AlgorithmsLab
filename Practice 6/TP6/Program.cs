using System;
using System.Collections.Generic;

namespace TP6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int[]> results = new List<int[]>();

            int[] array1 = { -21, -2, -3, -4 };
            int[] result1 = MaxSubArray.maxSubarray(array1);

            int[] array2 = { 1, 2, 3, 4 };
            int[] result2 = MaxSubArray.maxSubarray(array2);

            int[] array3 = { 8, -2, 5, -4 };
            int[] result3 = MaxSubArray.maxSubarray(array3);

            results.Add(result1);
            results.Add(result2);
            results.Add(result3);

            foreach (var item in results)
            {
                Console.WriteLine($"{item[0]} {item[1]}");
            }
        }

       
    
    }
}
