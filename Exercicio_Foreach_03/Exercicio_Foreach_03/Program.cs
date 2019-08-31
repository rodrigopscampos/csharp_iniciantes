using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Foreach_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implemente um algoritmo que imprima um array de maneira agradável

            int[] array = new[] { 1, 2, 4, 6, 2, 1, 3, 100 };

            Console.Write("[ ");
            foreach (int item in array)
            {
                Console.Write(item);
                Console.Write(" ");
            }
            Console.Write("]");
            Console.WriteLine();

            //Percorra um array e imprima todos os 
            //números pares e depois todos os números ímpares
            Console.Write("Pares: [ ");
            foreach(int item in array)
            {
                if(item % 2 == 0)
                {
                    Console.Write(item + " ");
                }
            }
            Console.Write("]");
            Console.WriteLine();

            Console.Write("Impares: [ ");
            foreach(int item in array)
            {
                if(item % 2 == 1)
                {
                    Console.Write(item + " ");
                }
            }
            Console.Write("]");

            Console.ReadLine();
        }
    }
}
