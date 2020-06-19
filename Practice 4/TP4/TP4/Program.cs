using System;
using System.IO;

namespace TP4
{
    class Program
    {
        static void Main(string[] args)
        {
            TP4A tp4a = new TP4A();
            TP4B tp4b = new TP4B();

            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            int[] result1 = tp4a.countingSort1(arr);
            int[] result2 = tp4b.countingSort2(arr);

            Console.WriteLine(string.Join(" ", result1));
            Console.WriteLine(string.Join(" ", result2));
        }
    }
}
