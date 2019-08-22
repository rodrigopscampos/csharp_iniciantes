using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciio_13_While
{
    class Program
    {
        static void Main(string[] args)
        {
            //Peça um número menor que 100 e imprima todos até o 100

            int n;

            while(true)
            {
                Console.WriteLine("Informe um número MENOR que 100");
                n = int.Parse(Console.ReadLine());

                if(n < 100)
                {
                    break;
                }

                Console.WriteLine("Número inválido");
            }


            while(n < 101)
            {
                Console.WriteLine(n);
                n++;
            }

            Console.WriteLine("Fim");
            Console.Read();
        }
    }
}
