using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número: ");
            int n = int.Parse(Console.ReadLine());

            int anterior = n - 1;
            int proximo = n + 1;

            Console.WriteLine("Número: " + n);
            Console.WriteLine("Anterior: " + anterior);
            Console.WriteLine("Próximo: " + proximo);

            Console.ReadLine();
        }
    }
}
