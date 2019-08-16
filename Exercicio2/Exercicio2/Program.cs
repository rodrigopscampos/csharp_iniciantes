using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número: ");
            int n = int.Parse(Console.ReadLine());

            int dobro = n * 2;
            int triplo = n * 3;

            Console.WriteLine("Número: " + n);
            Console.WriteLine("Dobro: " + dobro);
            Console.WriteLine("Triplo: " + triplo);


            Console.ReadLine();
        }
    }
}
