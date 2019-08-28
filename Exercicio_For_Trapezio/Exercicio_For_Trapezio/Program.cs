using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_For_Trapezio
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseMenor = 6;

            for(int v = 0; v <= baseMenor * 2; v++)
            {
                int inicio;
                int fim;

                if(v <= baseMenor)
                {
                    inicio = baseMenor + 1 - v;
                    fim = (baseMenor * 2) + v;
                }
                else
                {
                    inicio = 1;
                    fim = baseMenor * 3;
                }

                for(int h = 0; h <= baseMenor * 3; h++)
                {
                    if(h >= inicio && h <= fim)
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
