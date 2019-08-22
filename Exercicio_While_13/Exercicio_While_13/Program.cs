using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_While_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Peça um número menor que 100 e imprima todos até o 100

            //declara a variável fora do laço, para ela existir depois do laço.
            int n;

            do
            {
                //utiliza um do while, para executar o corpo no mínimo uma vez.

                Console.WriteLine("Informe um número MENOR que 100");
                n = int.Parse(Console.ReadLine());
            }
            while (n >= 100); //sai do laço quando o número for menor que 100.

            //se chegou aqui, o número com certeza é menor que cem.
            while (n <= 100)
            {
                //enquanto for menor ou igual a cem, imprime e incrementa.
                Console.WriteLine(n);
                n++;
            }

            //apenar para esperar o usuário pressionar Enter
            Console.ReadLine();
        }
    }
}
