using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Array_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implemente um algoritmo que encontra o maior 
            //e o menor número de um array

            //dado um array aleatório
            int[] numeros = new[] { 1, 5, 3, 6, 9, -1, 100 };

            //assume que o o maior e menor número do array é o primeiro
            int maior = numeros[0];
            int menor = numeros[0];

            //percorre do segundo até o último item do array
            for (int i = 1; i < numeros.Length; i++)
            {
                int item = numeros[i];

                if(item > maior) // se o item se mostrar maior que o meu atual maior, altera
                {
                    maior = item;
                }

                if(item < menor) //se o item se mostrar menor que o atual menor, altera
                {
                    menor = item;
                }
            }

            //quando acaba o arrray, as variáveis maior e menor guardarão o valor procurado
            Console.WriteLine("Maior = " + maior);
            Console.WriteLine("Menor = " + menor);
            Console.ReadLine();
        }
    }
}
