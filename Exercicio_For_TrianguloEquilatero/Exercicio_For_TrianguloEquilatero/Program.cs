using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_For_TrianguloEquilatero
{
    class Program
    {
        static void Main(string[] args)
        {
            int centro = 5;

            for (int v = 0; v <= centro; v++)
            {
                int inicio = centro - v;
                int fim = centro + v;

                for (int h = 0; h <= centro * 2; h++)
                {
                    if (h >= inicio && h <= fim)
                    {
                        Console.Write("*");
                        System.Threading.Thread.Sleep(50);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            //parte de baixo
            for (int v = 0; v <= centro - 1; v++)
            {
                int inicio = v + 1;
                int fim = (centro * 2) - 1 - v;

                for (int h = 0; h <= (centro * 2) - 1; h++)
                {
                    if (h >= inicio && h <= fim)
                    {
                        Console.Write("*");
                        System.Threading.Thread.Sleep(50);
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
