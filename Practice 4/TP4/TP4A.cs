using System;
using System.Collections.Generic;
using System.Text;

namespace TP4
{
    class TP4A
    {
        public int[] countingSort1(int[] arr)
        {
            int[] frequencyArray = new int[100];

            for (int i = 0; i < arr.Length; i++) frequencyArray[arr[i]]++;

            return frequencyArray;

        }
    }
}
