using System;
using System.Collections.Generic;
using System.Text;

namespace TP3
{
    public class TP3B
    {

        public static LinkedListNode<int> MergeLinkedList(LinkedListNode<int> linkedList1, LinkedListNode<int> linkedList2)
        {
            LinkedList<int> result = new LinkedList<int>();

            while (linkedList1 != null && linkedList2 != null)
            {
                if (linkedList1.Value < linkedList2.Value)
                {
                    result.AddLast(linkedList1.Value);
                    linkedList1 = linkedList1.Next;
                }
                else
                {
                    result.AddLast(linkedList2.Value);
                    linkedList2 = linkedList2.Next;
                }
            }

            while (linkedList1 != null)
            {
                result.AddLast(linkedList1.Value);
                linkedList1 = linkedList1.Next;
            }

            while (linkedList2 != null)
            {
                result.AddLast(linkedList2.Value);
                linkedList2 = linkedList2.Next;
            }

            return result.First;
        }
    }
}
