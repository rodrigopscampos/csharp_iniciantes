using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Foreach_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Some o valor de todos os ítens de um array de int utilizando foreach

            int[] numeros = new[] { 3, 2, 4, 1, 3, 45, 6, 3, 23, 34, 6 };

            int soma = 0;

            foreach (int item in numeros)
            {
                soma = soma + item;
            }

            Console.WriteLine("Soma = " + soma);
            Console.ReadLine();
        }
    }
}
