using System;
using System.Collections;
using System.Collections.Generic;

namespace Tp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            while (keepGoing)
            {
                Console.WriteLine("Practica #1");
                Console.WriteLine("1. Uniendo dos arreglos ordenados de distintos tamaños");
                Console.WriteLine("2. Emparejando tuercas y tornillos");
                Console.WriteLine("3. Salir");

                bool isInt = int.TryParse(Console.ReadLine(), out int val);

                if (isInt && val > 0 && val < 4)
                {
                    switch (val)
                    {
                        case 1:
                            TP1A();
                            Console.WriteLine("Presione cualquier tecla para continuar");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 2:
                            TP1B();
                            Console.WriteLine("Presione cualquier tecla para continuar");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 3:
                            keepGoing = false;
                            break;

                        default:
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("\nIntroduzca un valor valido");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        static void TP1A()
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

            #region Metodos
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
                        int[] array = CreateArray(n);
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

                        else if (val < y)
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

            #endregion

        }

        static void TP1B()
        {
            #region //TP1B
            Console.WriteLine("\nEmparejando tuercas y tornillos");
            Console.WriteLine("====================================================");

            //Ejemplos
            //char[] tuercas = { '@', '>', '%', '_', '!', '-' };
            //char[] tornillos = { '%', '_', '!', '-', '@', '>' };
            char[] tuercas = GetCharArr(1);
            char[] tornillos = GetCharArr(2);

            TP12 matching = new TP12();

            //Before match
            Console.WriteLine($"Tuercas: {string.Join(" ", tuercas)}");
            Console.WriteLine($"Tornillos: {string.Join(" ", tornillos)}");

            matching.MatchPairs(tuercas, tornillos, 0, tornillos.Length - 1);

            //After match
            Console.WriteLine("\nTuercas y Tornillos matched: ");
            Console.WriteLine(string.Join(" ", tuercas));
            Console.WriteLine(string.Join(" ", tornillos));


            #region Metodos
            // Metodos
            char[] GetCharArr(int x)
            {
                bool isRight = false;
                do
                {
                    Console.Write($"\nTamaño del arreglo {x}: ");
                    bool isChar = int.TryParse(Console.ReadLine(), out int n);

                    if (isChar)
                    {
                        char[] array = CreateCharArr(n);
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

            char[] CreateCharArr(int size)
            {
                char[] array = new char[size];


                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"Inserte el caracter {i + 1}: ");
                    bool isChar = char.TryParse(Console.ReadLine(), out char val);

                    if (isChar)
                    {
                        array[i] = val;
                    }
                    else
                    {
                        Console.WriteLine("\nIntroduzca un char valido");
                        i--;
                    }

                }

                return array;
            }
            #endregion 

            #endregion
        }



    }

    

    
}
