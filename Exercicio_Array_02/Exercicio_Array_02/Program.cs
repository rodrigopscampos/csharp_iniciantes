using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Array_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crie um array de tamanho informado 
            //pelo usuário, preencha e imprima o conteúdo do array

            Console.Write("Informe o tamanho do array: ");
            int tam = int.Parse(Console.ReadLine());

            string[] array = new string[tam];

            for (int i = 0; i < tam; i++)
            {
                Console.Write("Conteúdo " + (i + 1) + ": ");
                array[i] = Console.ReadLine();
            }

            Console.WriteLine("---------------------");
            //exercicio 2
            //for(int i = 0; i < tam; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            //exercicio 3
            for (int i = tam - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadLine();
        }
    }
}
