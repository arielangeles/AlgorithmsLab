using System;
using System.Collections.Generic;
using System.Text;

namespace Tp1
{
    public class TP12
    {
       
        // Metodo similar al Quicksort
        public void MatchPairs(char[] tuercas, char[] tornillo, int low, int high)
        {
            if (low < high)
            {
                // Elige el ultimo caracter del array de tornillos para la particion de tuercas
                int pivote = partition(tuercas, low, high, tornillo[high]);

                // Usando la particion de tuercas elige la particion de tornillos
                partition(tornillo, low, high, tuercas[pivote]);

                // Funcion recursiva para [low...pivote-1] y [pivot+1...high] para los arrays de
                // tuercas y tornillos
                MatchPairs(tuercas, tornillo, low, pivote - 1);
                MatchPairs(tuercas, tornillo, pivote + 1, high);
            }


        }

        private int partition(char[] arr, int low, int high, char pivote)
        {
            int i = low;
            char temp1, temp2;
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivote)
                {
                    temp1 = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp1;
                    i++;
                }
                else if (arr[j] == pivote)
                {
                    temp1 = arr[j];
                    arr[j] = arr[high];
                    arr[high] = temp1;
                    j--;
                }
            }

            temp2 = arr[i];
            arr[i] = arr[high];
            arr[high] = temp2;

            // Retorna el indice de particion de un arreglo basado
            // en el elemento pivote de otro arreglo
            return i;
        }


    }
}
