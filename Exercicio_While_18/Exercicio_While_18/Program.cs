using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_While_18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Infinitamente, some os valores digitados e 
            //imprima o valor, a quantidade de amostras e a média

            //variável para guarda o acumulado (soma de tudo que foi digitado)
            float acumulado = 0;

            //variável para guardar a quantidade de amostras (quantidade de números passados pelo usuário)
            int qtdAmostras = 0;

            while (true) //infinitamente
            {
                //se a quantidade de amostar é zero, significa que é a primeira vez
                if (qtdAmostras == 0)
                {
                    //imprime sem quebrar de linha
                    Console.Write("Número: ");
                }
                else
                {
                    //se cair aqui, siginifica que não é a primeira vez
                    //nesta caso, imprime uma quebra de linha antes do texto "Número: "
                    Console.Write("\nNúmero: ");
                }

                //lê a amostra do usuário, como um float
                float n = float.Parse(Console.ReadLine());

                //a quantidade de amostras incrementa (soma 1)
                qtdAmostras++;

                //a variável acumulado, acumula a amostra
                acumulado += n;

                //calcula a média
                float media = acumulado / qtdAmostras;

                //imprime o acumulado, qtd amostras e média
                Console.WriteLine(
                    "Acumulado: " + acumulado
                    + " Qtd. Amostras: " + qtdAmostras
                    + " Média: " + media
                    );
            }
        }
    }
}
