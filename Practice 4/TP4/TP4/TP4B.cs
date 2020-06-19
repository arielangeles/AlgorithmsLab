using System;
using System.Collections.Generic;
using System.Text;

namespace TP4
{
    class TP4B
    {
        public int[] countingSort2(int[] arr)
        {
            int[] frequencyArray = new int[100]; // 
            int[] sorted = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++) frequencyArray[arr[i]]++;

            for (int i = 1; i < frequencyArray.Length; i++) frequencyArray[i] += frequencyArray[i - 1];

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int c = arr[i];
                sorted[--frequencyArray[c]] = c;
            }

            return sorted;

        }
    }
}
