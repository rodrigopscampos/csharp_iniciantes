using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_For_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leia um número da tela e imprima a tabuada de 0 a 10
            //A * B = C

            Console.Write("Informe um número: ");
            int a = int.Parse(Console.ReadLine());

            for (int b = 0; b <= 10; b++)
            {
                Console.WriteLine(a + " x " + b + " = " + a * b);
            }

            Console.ReadLine();
        }
    }
}
