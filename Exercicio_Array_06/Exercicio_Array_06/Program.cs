using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Array_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] { 300, 4, 2, 1,100, -500, 99, 55 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            while (true)
            {
                bool mudou = false;

                for (int e = 0; e < array.Length - 1; e++)
                {
                    int d = e + 1;

                    if (array[e] > array[d])
                    {
                        int aux = array[e];
                        array[e] = array[d];
                        array[d] = aux;

                        mudou = true;
                    }
                }

                if(!mudou)
                {
                    break;
                }


                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
