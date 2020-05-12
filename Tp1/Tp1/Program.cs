using System;
using System.Collections;
using System.Collections.Generic;

namespace Tp1
{
    class Program
    {
        static void Main(string[] args)
        {


            #region //TP1A
            Console.WriteLine("Uniendo dos arreglos ordenados de distintos tamaños");
            Console.WriteLine("====================================================");

            int[] arr1 = GetArr(1);
            Console.WriteLine();
            int[] arr2 = GetArr(2);

            // Ejemplos
            //int[] arr1 = { 1, 2, 4, 6, 19, 23, 25 };
            //int[] arr2 = { 3, 5, 7, 8, 9 };

            Console.Clear();
            TP11 merger = new TP11();

            int[] mergedArray = merger.Merge(arr1, arr2);

            PrintArr(mergedArray);

            // Metodos
            int[] GetArr(int x)
            {
                bool isRight = false;
                do
                {
                    Console.Write($"\nTamaño del arreglo {x}: ");
                    bool isInt = int.TryParse(Console.ReadLine(), out int n);

                    if (isInt)
                    {                  
                        int[]array = CreateArray(n);
                        isRight = true;
                        return array;
                    }
                    else
                    {
                        Console.WriteLine("Introduzca un numero valido");
                        Console.WriteLine();
                    }

                } while (!isRight);

                return null;

            }
            
            int[] CreateArray(int size)
            {
                int[] array = new int[size];

                int y = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"Inserte el numero {i + 1}: ");
                    bool isInt = int.TryParse(Console.ReadLine(), out int val);
                   
                    if (val >= y && isInt)
                    {
                        array[i] += val;
                        y = val;
                    }
                    else
                    {
                        if (!isInt) 
                            Console.WriteLine("\nIntroduzca un numero valido");

                        else if(val < y)
                            Console.WriteLine($"\nInserte un numero mayor o igual a {y}"); 
                        
                        i--;
                    }

                }

                return array;
            }

            void PrintArr(int[] mergedArray)
            {
                Console.WriteLine($"Arreglo 1:\n [{string.Join(", ", arr1)}]");
                Console.WriteLine($"Arreglo 2:\n [{string.Join(", ", arr2)}]");

                Console.WriteLine($"\nArreglo ordenado:\n [{string.Join(", ", mergedArray)}]");
            }


            #endregion

            #region //TP1B
            Console.WriteLine("\nEmparejando tuercas y tornillos");
            Console.WriteLine("====================================================");
            char[] tuercas = { '@', '>', '%', '_', '!', '-' };

            char[] tornillos = { '%', '_', '!','-', '@', '>' };


            TP12 matching = new TP12();

            //Before match
            Console.WriteLine($"Tuercas: {string.Join(" ", tuercas)}");
            Console.WriteLine($"Tornillos: {string.Join(" ", tornillos)}");

            matching.MatchPairs(tuercas, tornillos, 0, tornillos.Length - 1);

            //After match
            Console.WriteLine("\nTuercas y Tornillos matched: ");
            Console.WriteLine(string.Join(" ", tuercas));
            Console.WriteLine(string.Join(" ", tornillos));

            #endregion

        }

    }

    

    
}
