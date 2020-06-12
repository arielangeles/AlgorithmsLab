using System;
using System.Collections.Generic;

namespace TP3
{
    class Program
    {
        static void Main(string[] args)
        {

            #region TP3B
            LinkedListNode<int> listNode1 = AddLinkedList(1);
            Console.WriteLine("---------------------------------------------");
            LinkedListNode<int> listNode2 = AddLinkedList(2);

            Console.WriteLine("LinkedList1: ");
            PrintLinkedList(listNode1);

            Console.WriteLine("\nLinkedList2: ");
            PrintLinkedList(listNode2);

            LinkedListNode<int> mergedList = TP3B.MergeLinkedList(listNode1, listNode2);

            Console.WriteLine("\nMergedLinkedList:");
            PrintLinkedList(mergedList);
            
            #endregion

        }

        public static void PrintLinkedList(LinkedListNode<int> ls)
        {
            while(ls != null)
            {
                if(ls.Next != null) 
                { 
                    Console.Write(ls.Value + " -> ");
                    ls = ls.Next;
                }
                else if(ls.Next == null)
                {
                    Console.Write(ls.Value);
                    ls = ls.Next;
                }
            }            
        }

        public static LinkedListNode<int> AddLinkedList(int nLinkedList)
        {
            LinkedList<int> ls = new LinkedList<int>();
            bool finished = false;
            while (!finished)
            {
                Console.WriteLine($"\nLinkedList {nLinkedList}");
                Console.Write("\nInsert the length of the linked list: ");
                bool isInt = int.TryParse(Console.ReadLine(), out int n);

                if (isInt)
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write($"Insert element {i+1}: ");
                        bool isVal = int.TryParse(Console.ReadLine(), out int val);

                        if (isVal)
                        {
                            ls.AddLast(val);
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
                    Console.WriteLine("Insert a valid number");
                }

                            
            }

            return ls.First;

        }
    }
}
