using System;
using System.Collections.Generic;

namespace TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finished = true;

            while (finished)
            {
                Console.Clear();
                Console.WriteLine("Trabajo Práctico 3 [TP3]");
                Console.WriteLine("\nElige el ejercicio a ejecutar: ");
                Console.WriteLine("1. [TP3A] Reverse the order of a Linked List");
                Console.WriteLine("2. [TP3B] Merge two Linked List into one");
                Console.WriteLine("3. Exit");
                Console.Write("\nAnswer: ");
                bool IsInt = int.TryParse(Console.ReadLine(), out int option);


                if (IsInt)
                {
                    switch (option)
                    {
                        #region TP3A
                        case 1:
                            Console.Clear();
                            LinkedListNode<int> listNode = AddLinkedList(1, 1);

                            Console.WriteLine("\nLinkedList: ");
                            PrintLinkedList(listNode);

                            LinkedListNode<int> reversedLinkedList = TP3A.ReverseLinkedList(listNode);

                            Console.WriteLine("\n\nReversed Linked List:");
                            PrintLinkedList(reversedLinkedList);
                            Console.ReadLine();
                            break;
                        #endregion

                        #region TP3B
                        case 2:
                            Console.Clear();
                            LinkedListNode<int> listNode1 = AddLinkedList(1,2);
                            Console.WriteLine("---------------------------------------------");
                            LinkedListNode<int> listNode2 = AddLinkedList(2, 2);
                            Console.WriteLine("---------------------------------------------");

                            Console.WriteLine("\nLinkedList1: ");
                            PrintLinkedList(listNode1);

                            Console.WriteLine("\nLinkedList2: ");
                            PrintLinkedList(listNode2);

                            LinkedListNode<int> mergedList = TP3B.MergeLinkedList(listNode1, listNode2);

                            Console.WriteLine("\n\nMerged Linked List:");
                            PrintLinkedList(mergedList);
                            Console.WriteLine();
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

        public static void PrintLinkedList(LinkedListNode<int> ls)
        {
            while(ls != null)
            {
                while (ls.Next != null)
                {
                    Console.Write(ls.Value + " -> ");
                    ls = ls.Next;
                }
                Console.Write(ls.Value);           
                ls = ls.Next;             
            }            
        }

        public static LinkedListNode<int> AddLinkedList(int nLinkedList, int nProblem)
        {
            LinkedList<int> ls = new LinkedList<int>();
            bool finished = false;
            while (!finished)
            {
                Console.WriteLine($"\nLinkedList {nLinkedList}:");
                Console.Write("\nInsert the length of the linked list: ");
                bool isInt = int.TryParse(Console.ReadLine(), out int n);

                int y = 0;
                if (isInt)
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write($"Insert element {i+1}: ");
                        bool isVal = int.TryParse(Console.ReadLine(), out int val);

                        if (isVal)
                        {
                            if(nProblem == 1 || nProblem == 2 && val >= y)
                            {
                                ls.AddLast(val);
                                y = val;
                            }
                            else
                            {
                                Console.WriteLine($"Enter a number higher or equal than {y}");
                                i--;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Insert a valid number");
                            i--;
                        }
                    }

                    finished = true;
                }
                else
                {
                    Console.WriteLine("Insert a valid character");
                    Console.ReadLine();
                    Console.Clear();
                }

                            
            }

            return ls.First;

        }
    }
}
