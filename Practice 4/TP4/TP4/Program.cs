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
                Console.WriteLine("1. [TP4A] Find the frequency of each inserted variable");
                Console.WriteLine("2. [TP4B] Sort the inserted array");
                Console.WriteLine("3. Exit");
                Console.Write("\nAnswer: ");
                bool IsInt = int.TryParse(Console.ReadLine(), out int option);


                if (IsInt)
                {

                    switch (option)
                    {
                        #region TP4A
                        case 1:
                            Console.Clear();

                            TP4A tp4a = new TP4A();
                            Console.Write("Please enter the size of the array: ");
                            int n = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\nPlease enter the variables:");
                            int[] arr1 = new int[n];
                            while (true)
                            {
                                try
                                {
                                    string[] variables = Console.ReadLine().Split(' ');
                                    if (variables.Length == n)
                                    {
                                        arr1 = Array.ConvertAll(variables, arrTemp => Convert.ToInt32(arrTemp));
                                        break;
                                    }
                                }
                                catch (FormatException e)
                                {
                                    Console.WriteLine("Invalid variables");
                                    Console.WriteLine("\nPlease enter the variables:");
                                }
                                Console.WriteLine("Invalid variables");
                                Console.WriteLine("\nPlease enter the variables:");
                            }

                            int[] result1 = tp4a.countingSort1(arr1);

                            Console.WriteLine("Frequency of each variable: ");
                            Console.WriteLine(string.Join(" ", result1));
                            Console.ReadLine();
                            break;
                        #endregion

                        #region TP4B
                        case 2:
                            Console.Clear();

                            TP4B tp4b = new TP4B();
                            Console.Write("Please enter the size of the array: ");
                            int x = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\nPlease enter the variables:");
                            int[] arr2 = new int[x];
                            while (true)
                            {
                                try
                                {
                                    string[] variables = Console.ReadLine().Split(' ');
                                    if (variables.Length == x)
                                    {
                                        arr2 = Array.ConvertAll(variables, arrTemp => Convert.ToInt32(arrTemp));
                                        break;
                                    }
                                }
                                catch (FormatException e)
                                {
                                    Console.WriteLine("Invalid variables");
                                    Console.WriteLine("\nPlease enter the variables:");
                                }
                                Console.WriteLine("Invalid variables");
                                Console.WriteLine("\nPlease enter the variables:");
                            }

                            int[] result2 = tp4b.countingSort2(arr2);

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
