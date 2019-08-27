using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_For_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Peça para o usuário uma base e altura e imprima um retângulo de “#”

            Console.Write("Base: ");
            int largura = int.Parse(Console.ReadLine());

            Console.Write("Altura: ");
            int altura = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int cAltura = 0; cAltura < altura; cAltura++)
            {
                for (int cLargura = 0; cLargura < largura; cLargura++)
                {
                   
                }
                Console.WriteLine();
            }



            Console.ReadLine();


        }
    }
}
