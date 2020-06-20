using System;
using System.IO;

namespace TP4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finished = true;

            while (finished)
            {
                Console.Clear();
                Console.WriteLine("Trabajo Práctico 4 [TP4]");
                Console.WriteLine("\nChoose the exercise to execute: ");
                Console.WriteLine("1. [TP4A] Find the frequence of each inserted variable");
                Console.WriteLine("2. [TP4B] Sort the inserted array");
                Console.WriteLine("3. Exit");
                Console.Write("\nAnswer: ");
                bool IsInt = int.TryParse(Console.ReadLine(), out int option);


                if (IsInt)
                {
                    Console.Clear();

                    Console.Write("Please enter the size of the array: ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nPlease enter the variables:");
                    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

                    switch (option)
                    {
                        #region TP4A
                        case 1:
                            Console.Clear();

                            TP4A tp4a = new TP4A();

                            int[] result1 = tp4a.countingSort1(arr);

                            Console.WriteLine("Frequency of each variable: ");
                            Console.WriteLine(string.Join(" ", result1));
                            Console.ReadLine();
                            break;
                        #endregion

                        #region TP4B
                        case 2:
                            Console.Clear();

                            TP4B tp4b = new TP4B();

                            int[] result2 = tp4b.countingSort2(arr);

                            Console.WriteLine("Sorted array: ");
                            Console.WriteLine(string.Join(" ", result2));
                            Console.ReadLine();
                            break;
                        #endregion

                        case 3:
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
    }
}
