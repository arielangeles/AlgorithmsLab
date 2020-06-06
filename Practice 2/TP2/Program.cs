using System;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finished = true;

            while(finished)
            {
                Console.Clear();
                Console.WriteLine("Trabajo Práctico 2 [TP2]");
                Console.WriteLine("\nElige el ejercicio a ejecutar: ");
                Console.WriteLine("1. [TP2A] Minimum Difference between array's values");
                Console.WriteLine("2. [TP2B] Find pair such that sum of pairs = x func");
                Console.WriteLine("3. Exit");
                Console.Write("\nAnswer: ");
                bool IsInt = int.TryParse(Console.ReadLine(), out int option);
                //int option = int.Parse(Console.ReadLine());
                if (IsInt)
                {
                    switch (option)
                    {
                        #region Minimum Difference between array's values
                        case 1:

                            TP2A tp2a = new TP2A();

                            Console.Clear();
                            int[] array1 = CreateArray();
                            Console.WriteLine($"\nArray: [{string.Join(", ", array1)}]");

                            int[] lista = tp2a.FindMinDifference(array1);

                            if (lista[0] == -1) Console.WriteLine(lista[0]);
                            else
                            {
                                Console.WriteLine("\nThe Pair of numbers with the minimum difference is: ");
                                Console.WriteLine(string.Join(" - ", lista));
                            }

                            Console.ReadLine();
                            break;
                        #endregion

                        #region Find pair such that pairSum = x func
                        case 2:

                            TP2B tp2b = new TP2B();

                            Console.Clear();
                            int[] array2 = CreateArray();
                            Console.WriteLine($"\nArray: [{string.Join(", ", array2)}]");

                            Console.Write("\nPlease enter the x function: ");
                            int x = int.Parse(Console.ReadLine());
                            int[] foundPair = tp2b.FindPair(array2, x);


                            if (!TP2B.found) Console.WriteLine(-1);
                            else Console.WriteLine($"\nX={x}\n[{string.Join(", ", foundPair)}]");

                            Console.ReadLine();

                            break;
                        #endregion

                        case 3:
                            //finished = false;
                            Environment.Exit(3);
                            break;

                        default:
                            Console.WriteLine("Invalid number");
                            Console.ReadKey();
                            break;
                    }
                    finished = true;
                }
                else
                {
                    Console.WriteLine("Insert a valid character");
                    Console.ReadKey();
                }
            }


        }

        public static int[] CreateArray()
        {
            bool finish = false;
            do
            {
                Console.Write("\nPlease enter the size of the Array: ");
                bool isInt = int.TryParse(Console.ReadLine(), out int size);

                if (isInt)
                {
                    int[] nArray = new int[size];

                    Console.WriteLine("\nPlease enter the value for each index: ");
                    for (int i = 0; i < nArray.Length; i++)
                    {
                        Console.Write($"Position {i + 1} = ");
                        bool isValid = int.TryParse(Console.ReadLine(), out int val);

                        if (isValid) nArray[i] = val;
                        else
                        {
                            Console.WriteLine("Insert a valid number");
                            i--;
                        }
                    }
                    return nArray;
                }
                else
                {
                    Console.WriteLine("Insert a valid character");
                }

            } while (!finish);

            return null;           
        }

    }

}
