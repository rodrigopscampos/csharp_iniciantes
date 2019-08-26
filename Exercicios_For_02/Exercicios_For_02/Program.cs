using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_For_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Peça um número maior que zero e imprima todos até zero
            int n;
            do
            {
                Console.Write("Informe um número MAIOR que zero: ");
                n = int.Parse(Console.ReadLine());
            }
            while (n <= 0);

            for (; n >= 0; n--)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }
    }
}
