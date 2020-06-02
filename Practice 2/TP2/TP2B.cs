using System;
using System.Collections.Generic;
using System.Text;

namespace TP2
{
    public class TP2B
    {
        
        public int[] FindPair(int[] arr, int x)
        {
            Merge merge = new Merge();

            int[] a = merge.Sort(arr);
            int[] res = new int[2];
       
            int low = 0, high = a.Length - 1;
            bool found = false;
            for (int i = 0; i < a.Length; i++)
            {
                int pairSum = a[low] + a[high];

                if (pairSum == x)
                {
                    res[0] = a[low];
                    res[1] = a[high];
                    found = true;
                }
                else if (pairSum > x) high--;
                else low++; //(pairSum < x) 
            }

            if (!found)
            {
                res[0] = int.MaxValue;
                res[1] = int.MinValue;
            } 
                
            
            return res;
        }
    }
}
