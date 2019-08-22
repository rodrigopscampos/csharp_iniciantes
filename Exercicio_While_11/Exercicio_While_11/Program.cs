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

            while (n != 0) //Enquanto o número for diferente de zero, faça
            {
                Console.WriteLine(n); //imprima o número

                if (n > 0) //se o número for maior que zero, significa que é positivo, então, para chegar no zero, deve descer (subtrair)
                {
                    n--;
                }
                else //se não, significa que ÑÃO é maior que zero, ou seja, é negativo, neste caso precisa subir (somar)
                {
                    n++;
                }
            }

            Console.ReadLine(); //apenas para manter o console aberto
        }
    }
}
