using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_For_Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Largura: ");
            int largura = int.Parse(Console.ReadLine());

            Console.Write("Altura: ");
            int altura = int.Parse(Console.ReadLine());

            for (int v = 0; v < altura; v++)
            {
                for (int h = 0; h < largura; h++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
