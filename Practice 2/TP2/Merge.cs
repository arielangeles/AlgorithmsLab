
using System;
using System.Collections.Generic;
using System.Text;

namespace TP2
{
    public class Merge : Sorting
    {
        private int[] temporaryData;
        public override int[] Sort(int[] dataToBeSort)
        {
            temporaryData = new int[dataToBeSort.Length];
            this.Sort(dataToBeSort, 0, dataToBeSort.Length - 1);
            return dataToBeSort;
        }
        private void Sort(int[] dataToBeSort, int lowerBound, int upperBound)
        {
            if (upperBound <= lowerBound)
            {
                return;
            }
            int middleBound = lowerBound + ((upperBound - lowerBound) / 2);
            this.Sort(dataToBeSort, lowerBound, middleBound);
            this.Sort(dataToBeSort, middleBound + 1, upperBound);
            this.Merger(dataToBeSort, lowerBound, middleBound, upperBound);
        }
        private void Merger(int[] dataToBeMerge, int lowerBound, int middleBound, int upperBound)
        {
            int firstHalfIndex = lowerBound, secondHalfIndex = middleBound + 1;
            for (int i = lowerBound; i <= upperBound; i++)
            {
                temporaryData[i] = dataToBeMerge[i];
            }
            for (int i = lowerBound; i <= upperBound; i++)
            {
                if (firstHalfIndex > middleBound)
                {
                    dataToBeMerge[i] = temporaryData[secondHalfIndex++];
                }
                else if (secondHalfIndex > upperBound)
                {
                    dataToBeMerge[i] = temporaryData[firstHalfIndex++];
                } else if (SortingUtilities.Less(temporaryData[secondHalfIndex], temporaryData[firstHalfIndex])) {
                    dataToBeMerge[i] = temporaryData[secondHalfIndex++];
                }
                else
                {
                    dataToBeMerge[i] = temporaryData[firstHalfIndex++];
                }
            }
        }
    }
}
