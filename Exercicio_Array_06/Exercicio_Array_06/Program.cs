using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Array_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = PedirPorNumero("Informe o primeiro número: ");
            int b = PedirPorNumero("Informe o segundo número: ");
            int c = PedirPorNumero("Informe o terceiro número: ");

            int soma = Somar(a, b, c);
            int p = Potencia(a, b);

            Console.WriteLine("Inform um texto para eu contar as vogais: ");
            string texto = Console.ReadLine();

            int qtd = ContaVogais(texto);
            Console.WriteLine("Quantidade de vogais: " + qtd);

            Console.ReadLine();
        }

        static int PedirPorNumero(string texto)
        {
            Console.Write(texto);
            return LerInt();
        }

        //Implemente um método ReadInt(), que lê uma linha do console e converte o valor para int
        static int LerInt()
        {
            int n = int.Parse(Console.ReadLine());
            return n;
        }

        //Implemente um método Somar, que soma três números inteiros
        static int Somar(int a, int b, int c)
        {
            return a + b + c;
        }

        //Implemente um método Potencia que recebe base e expoente e retorna a potência.
        static int Potencia(int b, int e)
        {
            int p = (int)Math.Pow(b, e);
            return p;
        }

        //Implemente um método ContaVogais que recebe uma string e retorna a quantidade de vogais
        static int ContaVogais(string texto)
        {
            int qtd = 0;
            foreach(char c in texto)
            {
                if(
                    c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                    c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U'
                    )
                {
                    qtd++;
                }
            }

            return qtd;
        }
    }
}
