using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leia 4 notas de um aluno, calcule e imprima 
            //a média e imprima APROVADO para média superior ou igual a 7,0 
            //ou REPROVADO para  inferior a 7,0.

            Console.Write("Nota 1: ");
            decimal n1 = decimal.Parse( Console.ReadLine() );

            Console.Write("Nota 2: ");
            decimal n2 = decimal.Parse(Console.ReadLine());

            Console.Write("Nota 3: ");
            decimal n3 = decimal.Parse(Console.ReadLine());

            decimal media = (n1 + n2 + n3) / 3;

            Console.WriteLine("Média: " + media);

            if (media >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }

            Console.ReadLine();
        }
    }
}
