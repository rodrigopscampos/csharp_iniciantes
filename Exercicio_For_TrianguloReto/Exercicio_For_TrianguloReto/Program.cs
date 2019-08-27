using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_For_TrianguloReto
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura = 10;

            for (int v = 1; v <= altura; v++)
            {
                for (int h = 1; h <= v; h++)
                {
                    Console.Write("*");
                    System.Threading.Thread.Sleep(100);
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
