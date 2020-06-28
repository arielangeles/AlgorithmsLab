using System;

namespace TP5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finished = false;
            Console.WriteLine("Una rana salta de 1, 2 o 3 pasos para llegar al tope. En cuantas manera diferentes puede llegar al tope.");
            while (!finished)
            {
                bool isOkay = true;
                Console.WriteLine();
                Console.Write("El tope es: ");
                bool IsInt = int.TryParse(Console.ReadLine(), out int top);

                if(IsInt && top >= 0)
                {
                    Console.WriteLine($"La rana puede llegar de {NumCombinator.NumCombinations(top)} maneras diferentes");
                }
                else
                {
                    Console.WriteLine("Digite un entero positvo");
                    isOkay = false;
                }
                Console.ReadKey();

                bool respValida = false;
                while(!respValida && isOkay)
                {
                    respValida = true;
                    Console.Write("\nDesea probar de nuevo? (y/n): ");
                    string response = Console.ReadLine().ToLower();
                    if (response.ToLower() == "no" || response.ToLower() == "n") finished = true;
                    else if (response.ToLower() == "yes" || response.ToLower() == "y") finished = false;         
                    else
                    {
                        Console.WriteLine("Ingrese una respuesta valida");
                        Console.ReadKey();
                        respValida = false;
                    }
                }
            }
        }

       



    }
}
