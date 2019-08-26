using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_For_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Peça uma quantidade e imprima um texto o tanto de vezes informado

            Console.Write("Informe a quantidade de vezes: ");
            int n = int.Parse(Console.ReadLine());

            for(int contador = 1; contador <= n; contador++)
            {
                Console.WriteLine(contador + " - Eu prometo estudar C#");
            }

            Console.ReadLine();
        }
    }
}
