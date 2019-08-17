using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    class Program
    {
        //Leia três números e imprima o maior e o menor
        static void Main(string[] args)
        {
            Console.Write("Número 1: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Número 2: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Número 3: ");
            int c = int.Parse(Console.ReadLine());

            if (a >= b)
            {
                if (a >= c)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(c);
                }
            }
            else
            {
                if (b >= c)
                {
                    Console.WriteLine(b);
                }
                else
                {
                    Console.WriteLine(c);
                }
            }

            Console.ReadLine();
        }
    }
}
