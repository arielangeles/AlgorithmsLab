using System;

namespace TP5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Una rana salta de 1, 2 o 3 pasos para llegar al tope. En cuantas manera diferentes puede llegar al tope.");
            while (true)
            {
                Console.WriteLine();
                Console.Write("El tope es: ");
                bool IsInt = int.TryParse(Console.ReadLine(), out int top);

                if(IsInt && top >= 0)
                {
                    Console.WriteLine($"La rana puede llegar de {NumCombinator.NumCombinations(top)} maneras difernetes");
                }
                else{
                    Console.WriteLine("Digite un entero positvo");
                }
            }
        }



    }
}
