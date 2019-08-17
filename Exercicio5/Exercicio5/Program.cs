using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        //Leia três números e os imprima 
        //do último para o primeiro
        static void Main(string[] args)
        {
            Console.Write("Número 1: ");
            int a = int.Parse( Console.ReadLine() );

            Console.Write("Número 2: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Número 3: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(c);
            Console.WriteLine(b);
            Console.WriteLine(a);

            Console.ReadLine();
        }
    }
}
