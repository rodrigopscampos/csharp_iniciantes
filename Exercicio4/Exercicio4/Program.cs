using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        //Leia três números, some e imprima o resultado
        static void Main(string[] args)
        {
            Console.Write("Número 1: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Número 2: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Número 3: ");
            int c = int.Parse(Console.ReadLine());

            int soma = a + b + c;
            Console.WriteLine("Soma = " + soma);

            Console.ReadLine();
        }
    }
}
