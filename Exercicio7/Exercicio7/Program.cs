using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Program
    {
        //Leia um número e imprima se ele é ímpar, zero ou par
        static void Main(string[] args)
        {
            Console.Write("Informe um número: ");
            int n = int.Parse(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine("Zero");
            }
            else if (n % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }

            Console.ReadLine();
        }
    }
}
