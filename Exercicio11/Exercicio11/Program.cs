using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o número que deseja a tabuada: ");
            int tabuada = int.Parse(Console.ReadLine());

            int n = 0;
            while(n <= 10)
            {
                int c = tabuada * n;
                Console.WriteLine(tabuada + " X " + n + " = " + c);
                n++;
            }

            Console.ReadLine();
        }
    }
}
