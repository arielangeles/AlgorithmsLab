using System;
using System.Collections.Generic;
using System.Text;

namespace TP5
{
    public static class NumCombinator
    {
        public static int NumCombinations(int top)
        {
            // Use extra space to keep the calculated results
            int[] k = new int[top + 1];

            //Declare base cases
            k[0] = 1;
            k[1] = 1;
            k[2] = 2;

            //Calculating the next number of combinations from the base cases using DP
            for (int i = 3; i < k.Length; i++)
                k[i] = k[i - 1] + k[i - 2] + k[i - 3];

            //Return the "top" element (answer)
            return k[top];
        }
    }
}
