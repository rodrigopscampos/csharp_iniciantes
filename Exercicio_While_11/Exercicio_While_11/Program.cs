using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_While_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Peça um número e imprima todos até zero
            Console.WriteLine("Informe um número:");
            int n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                Console.WriteLine(n);

                if (n > 0)
                {
                    n--;
                }
                else
                {
                    n++;
                }
            }

            Console.ReadLine();
        }
    }
}
