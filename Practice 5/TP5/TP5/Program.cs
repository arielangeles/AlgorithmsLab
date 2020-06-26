using System;

namespace TP5
{
    class Program
    {
        static void Main(string[] args)
        {
            int top = 2;
            Console.WriteLine($"If top is {top} then it has {NumCombinations(top)} combinations");

            int top3 = 6;
            Console.WriteLine($"If top is {top3} then it has {NumCombinations(top3)} combinations");

            int top5 = 7;
            Console.WriteLine($"If top is {top5} then it has {NumCombinations(top5)} combinations");

        }


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
