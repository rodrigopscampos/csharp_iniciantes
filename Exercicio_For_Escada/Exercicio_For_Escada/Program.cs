using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_For_Escada
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura = 10;

            for (int v = 0; v < altura; v++)
            {
                int inicio = v * 3;
                int fim = inicio + 3;

                for (int h = 0; h < fim; h++)
                {
                    if (h >= inicio)
                    {
                        Console.Write("*");
                        System.Threading.Thread.Sleep(100);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
