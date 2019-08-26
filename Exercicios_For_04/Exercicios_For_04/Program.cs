using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_For_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Peça um início e um fim, e impria todos os números no intervalo

            Console.Write("Início: ");
            int inicio = int.Parse(Console.ReadLine());

            Console.Write("Fim: ");
            int fim = int.Parse(Console.ReadLine());

            for(int cursor = inicio; cursor <= fim; cursor++)
            {
                Console.WriteLine(cursor);
            }

            Console.ReadLine();
        }
    }
}
