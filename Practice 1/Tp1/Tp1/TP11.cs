using System;
using System.Collections.Generic;
using System.Text;

namespace Tp1
{
    public class TP11
    {
        //private int[] arr1;
        //private int[] arr2;  
        
        //public TP11(int[] array1, int[] array2)
        //{
        //    arr1 = new int[array1.Length];
        //    arr1 = array1;

        //    arr2 = new int[array2.Length];
        //    arr2 = array2;
        //}

        //public int[] MergedArray
        //{
        //    get
        //    {
        //        int[] mergedArray = Merge(arr1, arr2);
        //        return mergedArray;
        //    }
        //}

        public int[] Merge(int[] arr1, int[] arr2)
        {
            int totalLength = arr1.Length + arr2.Length;
            int[] result = new int[totalLength];


            int j = 0, i = 0;
            for (int x = 0; x < totalLength; x++)
            {
                if (i < arr1.Length && j < arr2.Length)
                {
                    if (arr1[i] < arr2[j])
                    {
                        result[x] += arr1[i];
                        i++;
                    }
                    else
                    {
                        result[x] += arr2[j];
                        j++;
                    }

                }
                else if (i < arr1.Length)
                {
                    result[x] += arr1[i];
                    i++;
                }
                else if (j < arr2.Length)
                {
                    result[x] += arr2[j];
                    j++;
                }
            }

            return result;
        }

        

    }
}
