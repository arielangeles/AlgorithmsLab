using System;
using System.Collections.Generic;
using System.Text;

namespace TP2
{
    public class TP2B
    {
        public static bool found = false;
        
        public int[] FindPair(int[] arr, int x)
        {
            Merge merge = new Merge();

            int[] a = merge.Sort(arr);
            int[] res = new int[2];
       
            int low = 0, high = a.Length - 1;
            int pairSum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (low < high) pairSum = a[low] + a[high];
                
                if (pairSum == x)
                {
                    res[0] = a[low];
                    res[1] = a[high];
                    found = true;
                }
                else if (pairSum > x) high--;
                else low++; //(pairSum < x) 
            }
            
            return res;
        }
    }
}
