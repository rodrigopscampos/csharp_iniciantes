using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_While_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Peça um número e imprima todos até zero pulando de dois em dois

            Console.Write("Informe um número: ");
            int n = int.Parse(Console.ReadLine());

            while (n != 0) //enquanto n for diferente de zero
            {
                Console.WriteLine(n); //imprime n

                if (n > 0) //se for maior que zero, é positivo
                {
                    n = n - 2; //decrementa 2

                    if (n < 0) //pode acontecer de n ser 1 e virar -1, neste caso mudamos o valor para 0
                    {
                        n = 0;
                    }
                }
                else
                { //se caiu aqui, n NÃO é maior que zero e também NÃO é igual a zero, então, só pode ser negativo
                    n = n + 2; //incrementa 2

                    if (n > 0) //pode acontecer dele ser -1 e virar 1, neste caso mudamos para zero
                    {
                        n = 0;
                    }
                }
            }

            //vai sair do laço, quando n valer zero, então dentro do laço, não vai imprimir o valor zero
            Console.WriteLine(0);

            //só p esperar o usuário apertar Enter para fechar
            Console.ReadLine();
        }
    }
}
