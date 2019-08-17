using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Program
    {
        //Leia um número e imprima se ele é 
        //positivo, negativo ou zero
        static void Main(string[] args)
        {
            Console.Write("Informe um número: ");
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                Console.WriteLine("Positivo");
            }
            else if (n == 0)
            {
                Console.WriteLine("Zero");
            }
            else
            {
                Console.WriteLine("Negativo");
            }
        }
    }
}
