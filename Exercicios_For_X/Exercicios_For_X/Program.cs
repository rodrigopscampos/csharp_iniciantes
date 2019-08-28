using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_For_X
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura = 18;
            
            for(int v = 0; v <= altura; v++)
            {
                int inicio = v;
                int fim = altura - v;

                for(int h = 0; h <= altura; h++)
                {
                    if(h == inicio || h == fim)
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
