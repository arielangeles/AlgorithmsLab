using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TP3;

namespace UnitTestPractice3
{
    [TestClass]
    public class TP3BTests
    {
        [TestMethod]
        public void reverseLL_BaseCase()
        {
            int[] vals = { 1, 2, 3, 4, 5 };
            int[] valsReversed = { 5, 4, 3, 2, 1 };

            LinkedList<int> ls = new LinkedList<int>(vals);

            LinkedListNode<int> nodeReversed = TP3A.ReverseLinkedList(ls.First);

            int i = 0;
            bool isReversed = true;
            while (nodeReversed.Next != null)
            {
                if (nodeReversed.Value != valsReversed[i])
                {
                    isReversed = false;
                }
                i++;
                nodeReversed = nodeReversed.Next;
            }

            Assert.IsTrue(isReversed);
        }

        [TestMethod]
        public void reverseLL_AllElementsEqualsExceptLastOne()
        {
            int[] vals = { 1, 1, 1, 1, 2 };
            int[] valsReversed = { 2, 1, 1, 1, 1 };

            LinkedList<int> ls = new LinkedList<int>(vals);

            LinkedListNode<int> nodeReversed = TP3A.ReverseLinkedList(ls.First);

            int i = 0;
            bool isReversed = true;
            while (nodeReversed.Next != null)
            {
                if (nodeReversed.Value != valsReversed[i])
                {
                    isReversed = false;
                }
                i++;
                nodeReversed = nodeReversed.Next;
            }

            Assert.IsTrue(isReversed);
        }


        [TestMethod]
        public void reverseLL_AllElementsEqualsExceptFirstOne()
        {
            int[] vals = { 2, 1, 1, 1, 1 };
            int[] valsReversed = { 1, 1, 1, 1, 2 };

            LinkedList<int> ls = new LinkedList<int>(vals);

            LinkedListNode<int> nodeReversed = TP3A.ReverseLinkedList(ls.First);

            int i = 0;
            bool isReversed = true;
            while (nodeReversed.Next != null)
            {
                if (nodeReversed.Value != valsReversed[i])
                {
                    isReversed = false;
                }
                i++;
                nodeReversed = nodeReversed.Next;
            }

            Assert.IsTrue(isReversed);
        }

        [TestMethod]
        public void reverseLL_AlternateElements()
        {
            int[] vals = { 1, 2, 1, 2, 1, 2 };
            int[] valsReversed = { 2, 1, 2, 1, 2, 1 };

            LinkedList<int> ls = new LinkedList<int>(vals);

            LinkedListNode<int> nodeReversed = TP3A.ReverseLinkedList(ls.First);

            int i = 0;
            bool isReversed = true;
            while (nodeReversed.Next != null)
            {
                if (nodeReversed.Value != valsReversed[i])
                {
                    isReversed = false;
                }
                i++;
                nodeReversed = nodeReversed.Next;
            }

            Assert.IsTrue(isReversed);
        }

        [TestMethod]
        //[ExpectedException(typeof(NullReferenceException))]
        public void reverseLL_EmptyList()
        {
            int[] vals = { };

            LinkedList<int> ls = new LinkedList<int>(vals);
            LinkedListNode<int> nodeReversed = TP3A.ReverseLinkedList(ls.First);
            Assert.IsTrue(nodeReversed == null);
        }

        [TestMethod]
        public void MergeLLs_BaseCase()
        {
            int[] vals1 = { 1, 2, 3, 4, 5 };
            int[] vals2 = { 6, 7, 8, 9, 10 };
            int[] valsExpected = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            LinkedList<int> ls1 = new LinkedList<int>(vals1);
            LinkedList<int> ls2 = new LinkedList<int>(vals2);

            LinkedListNode<int> firstNodeMergedLL = TP3B.MergeLinkedList(ls1.First, ls2.First);

            int i = 0;
            bool isMerged = true;
            while (firstNodeMergedLL.Next != null)
            {
                if (firstNodeMergedLL.Value != valsExpected[i])
                {
                    isMerged = false;
                }
                i++;
                firstNodeMergedLL = firstNodeMergedLL.Next;
            }

            Assert.IsTrue(isMerged);
        }

        [TestMethod]
        public void MergeLLs_FirstLLEmpty()
        {
            int[] vals1 = { 1, 2, 3, 4, 5 };
            int[] vals2 = { };
            int[] valsExpected = { 1, 2, 3, 4, 5 };

            LinkedList<int> ls1 = new LinkedList<int>(vals1);
            LinkedList<int> ls2 = new LinkedList<int>(vals2);

            LinkedListNode<int> firstNodeMergedLL = TP3B.MergeLinkedList(ls1.First, ls2.First);

            int i = 0;
            bool isMerged = true;
            while (firstNodeMergedLL.Next != null)
            {
                if (firstNodeMergedLL.Value != valsExpected[i])
                {
                    isMerged = false;
                }
                i++;
                firstNodeMergedLL = firstNodeMergedLL.Next;
            }

            Assert.IsTrue(isMerged);
        }
        [TestMethod]
        public void MergeLLs_SecondLLEmpty()
        {
            int[] vals1 = { };
            int[] vals2 = { 6, 7, 8, 9, 10 };
            int[] valsExpected = { 6, 7, 8, 9, 10 };

            LinkedList<int> ls1 = new LinkedList<int>(vals1);
            LinkedList<int> ls2 = new LinkedList<int>(vals2);

            LinkedListNode<int> firstNodeMergedLL = TP3B.MergeLinkedList(ls1.First, ls2.First);

            int i = 0;
            bool isMerged = true;
            while (firstNodeMergedLL.Next != null)
            {
                if (firstNodeMergedLL.Value != valsExpected[i])
                {
                    isMerged = false;
                }
                i++;
                firstNodeMergedLL = firstNodeMergedLL.Next;
            }

            Assert.IsTrue(isMerged);
        }

        [TestMethod]
        public void MergeLinkedListTest()
        {
            var random = new Random();

            int length1 = random.Next(5);
            int length2 = random.Next(5);

            int[] list1 = new int[length1];
            int[] list2 = new int[length2];

            int y = int.MinValue;
            for (int i = 0; i < length1; i++)
            {
                int val = random.Next(0, 10);
                if (val >= y)
                {
                    list1[i] = val;
                    y = val;
                }
                else i--;
            }

            y = int.MinValue;
            for (int i = 0; i < length2; i++)
            {
                int val = random.Next(0, 10);
                if (val >= y)
                {
                    list2[i] = val;
                    y = val;
                }
                else i--;
            }

            LinkedList<int> ls1 = new LinkedList<int>(list1);
            LinkedList<int> ls2 = new LinkedList<int>(list2);

            
            bool areEqual = true;

            int[] resultArr = Merge(list1, list2);
            LinkedListNode<int> mergedList = TP3B.MergeLinkedList(ls1.First, ls2.First);

            int j = 0;
            while(mergedList != null)
            {
                if (resultArr[j] != mergedList.Value) areEqual = false;
                j++;
                mergedList = mergedList.Next;
            }
          
            Assert.IsTrue(areEqual);

        }

        public int[] Merge(int[] arr1, int[] arr2)
        {
            int totalLength = arr1.Length + arr2.Length;
            int[] result = new int[totalLength];


            int j = 0, i = 0;
            for (int x = 0; x < totalLength; x++)
            {
                if (i < arr1.Length && j < arr2.Length)
                {
                    if (arr1[i] < arr2[j])
                    {
                        result[x] += arr1[i];
                        i++;
                    }
                    else
                    {
                        result[x] += arr2[j];
                        j++;
                    }

                }
                else if (i < arr1.Length)
                {
                    result[x] += arr1[i];
                    i++;
                }
                else if (j < arr2.Length)
                {
                    result[x] += arr2[j];
                    j++;
                }
            }

            return result;
        }

    }

}
