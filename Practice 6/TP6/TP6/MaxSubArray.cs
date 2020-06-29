using System;
using System.Collections.Generic;
using System.Text;

namespace TP6
{
    public class MaxSubArray
    {
        public static int[] maxSubarray(int[] arr)
        {
            //1
            int size = arr.Length;
            int currentMax = 0;
            int resultMax = int.MinValue;


            for (int i = 0; i < size; i++)
            {
                currentMax = Math.Max(arr[i], arr[i] + currentMax);
                if (currentMax > resultMax)
                {
                    resultMax = currentMax;
                }
            }

            //2
            Array.Sort(arr);
            int suma = 0;

            if (arr[size - 1] <= 0)
                suma = arr[size - 1];
            else
            {
                for (int x = 0; x < size; x++)
                {
                    if (arr[x] > 0)
                        suma += arr[x];
                }
            }

            return new int[] { resultMax, suma };

        }
    }
}
