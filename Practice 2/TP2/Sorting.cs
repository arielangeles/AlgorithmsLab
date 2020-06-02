using System;
using System.Collections.Generic;
using System.Text;

namespace TP2
{
    public abstract class Sorting
    {
        protected int swapCount;
        public int SwapCount
        {
            get
            {
                return this.swapCount;
            }
        }

        public Sorting()
        {
            this.swapCount = 0;
        }

        public void PrintArray(int[] dataToBePrint)
        {
            Console.Write("[ ");
            for (int i = 0; i < dataToBePrint.Length; i++)
            {
                Console.Write($"{dataToBePrint[i]} ");
            }
            Console.Write("] : ");
            Console.WriteLine($"[ Cantidad de Intercambios: {this.SwapCount} ]");
        }
        public abstract int[] Sort(int[] dataToBeSort);
    }
}
