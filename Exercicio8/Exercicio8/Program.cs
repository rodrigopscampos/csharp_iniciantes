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

            int maior = a;
            int menor = a;

            if (a > maior)
            {
                maior = a;
            }

            if (b > maior)
            {
                maior = b;
            }

            if (c > maior)
            {
                maior = c;
            }

            if(a < menor)
            {
                menor = a;
            }

            if(b < menor)
            {
                menor = b;
            }

            if (c < menor)
            {
                menor = c;
            }

            Console.WriteLine("Maior = " + maior);
            Console.WriteLine("Menor = " + menor);

            Console.ReadLine();
        }
    }
}
