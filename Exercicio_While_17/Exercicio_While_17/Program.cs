using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_While_17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Infinitamente, some os valores digitados pelo usuário e 
            //imprima na tela o valor acumulado

            int acumulado = 0;

            while (true)
            {
                Console.Write("Número: ");
                int n = int.Parse(Console.ReadLine());

                acumulado += n;
                Console.WriteLine(acumulado);
            }
        }
    }
}
