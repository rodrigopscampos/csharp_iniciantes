using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SUPER CALCULADORA");
            Console.WriteLine("------------------------");
            
            int indice = 0; //cria uma variável indice, para representar o indice do próximo número a ser guardado
            int[] numeros = new int[100000]; //cria um array de 100.000 (cem mil) posições

            while (true) //infinitamente
            {
                Console.Write("Informe um número ou pressione Enter para continuar: ");
                string texto = Console.ReadLine();

                if (texto == "") //se ó usuário pressionar Enter, sem ter digitado um número, entra e sai do laço
                {
                    break;
                }

                //se chegou aqui, significa que o usuário digitou um número
                int n = int.Parse(texto);
                numeros[indice] = n; //coloca o número n na posição indice
                indice++; //incrementa o indice, para dizer o número da próxima casa do array
            }

            // se chegou aqui, siginifica que o usuário pressionou Enter sem informar um número
            int acc = 0;
            for (int i = 0; i < indice; i++)
            {
                //percorre todos os itens do array que foram preenchidos pelo usuário e acumula no variável acc
                acc = acc + numeros[i];
            }

            Console.WriteLine("Total: " + acc);
            Console.ReadLine();
        }
    }
}
