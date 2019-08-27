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
            int comprimentoDegrau = 3;

            for (int v = 1; v <= altura; v++)
            {
                int ultimaCasa = comprimentoDegrau * v;
                for (int h = 1; h <= ultimaCasa; h++)
                {
                    if (h >= ultimaCasa - comprimentoDegrau)
                    {
                        if(h == ultimaCasa)
                        {
                            Console.Write("|");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                        
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
