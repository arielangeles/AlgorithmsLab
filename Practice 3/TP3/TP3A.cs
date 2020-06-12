using System;
using System.Collections.Generic;
using System.Text;

namespace TP3
{
    class TP3A
    {
        public static LinkedListNode<int> reverseTheOrder(LinkedListNode<int> linkedList)
        {
            LinkedList<int> reversedLinkedList = new LinkedList<int>();
            Stack<int> stack = new Stack<int>();

            while(linkedList != null)
            {
                stack.Push(linkedList.Value);
                linkedList = linkedList.Next;
            }

            while(stack.Count != 0)
            {
                reversedLinkedList.AddLast(stack.Pop());
            }

            return reversedLinkedList.First;
        } 

    }
}
