using System;
using System.IO;

namespace TP4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            int[] result = countingSort(arr);

            Console.WriteLine(string.Join(" ", result));
        }

        static int[] countingSort(int[] arr)
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
