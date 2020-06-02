using System;
using System.Collections.Generic;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Find pair such that pairSum = x func */
            TP2A tp2a = new TP2A();
            int[] arreglo = { 10, 2, 13, 7, 15 };
            //int[] arr = { 2 };

            int[] lista = tp2a.FindMinDifference(arreglo);

            if (lista[0] == -1) Console.WriteLine(lista[0]);
            else Console.WriteLine(string.Join(" - ", lista));


            Console.ReadLine();

            TP2B tp2b = new TP2B();
            Console.WriteLine($"[{string.Join(", ", arreglo)}]");
            int x = 9;    
            int[] foundPair = tp2b.FindPair(arreglo, x);
           
            if (foundPair[0] == int.MaxValue && foundPair[1] == int.MinValue) Console.WriteLine(-1);
            else Console.WriteLine($"\nX={x}\n[{string.Join(", ", foundPair)}]");

            Console.ReadLine();
        }
    }
}
