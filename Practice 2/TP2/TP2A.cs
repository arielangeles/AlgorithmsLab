using System;
using System.Collections.Generic;
using System.Text;

namespace TP2
{
    public class TP2A
    {
        public int[] FindMinDifference(int[] a)
        {
            
            Merge merge = new Merge();

            a = merge.Sort(a);

            int minDifference = 0; //Temp var that contains the min difference
            int[] limitsOfMinDifference = new int[2];      /* This array stores the limits in the form [a[i], a[i+1]]
                                                             to know which set of values give the Min difference*/

            if (a.Length < 2)
            {
                limitsOfMinDifference[0] = -1;
                return limitsOfMinDifference;
            }

            minDifference = Math.Abs(a[0] - a[1]);
            for (int i = 1; i < a.Length - 1; i++)
            {
                if (Math.Abs(a[i] - a[i + 1]) < minDifference)
                {
                    //If we get a new min Difference
                    minDifference = (Math.Abs(a[i] - a[i + 1]));
                    limitsOfMinDifference[0] = a[i];
                    limitsOfMinDifference[1] = a[i + 1];
                }
            }
                
            return limitsOfMinDifference;

            /* HashTable Way */

            //Hashtable hashtable = new Hashtable(a.Length);
            //int[] result = new int[2];
            //for (int i = 0; i < a.Length - 1; i++) hashtable.Add(Convert.ToString(i), Convert.ToString(Math.Abs(a[i] - a[i + 1])));

            //Item it = new Item();
            //it = hashtable["0"];
            //int minVal = int.Parse(it.Value);
            //for (int i = 1; i < a.Length - 1; i++)
            //{
            //    it = hashtable[Convert.ToString(i)];
            //    if(int.Parse(it.Value) < minVal) minVal = int.Parse(it.Value);        
            //}

            //for (int i = 0; i < a.Length  - 1; i++)
            //{
            //    it = hashtable[Convert.ToString(i)];
            //    if (minVal == int.Parse(it.Value))
            //    {
            //        result[0] = a[i];
            //        result[1] = a[i + 1];
            //    }
            //}

            //return result;

        }

    } 
          
}
