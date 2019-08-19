using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    class Program
    {
        //Leia um número, se < 10, criança, se < 18 adolescente, se não, adulto
        static void Main(string[] args)
        {
            Console.Write("Informe uma idade: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 10)
            {
                Console.WriteLine("Criança");
            }
            else if (n < 18)
            {
                Console.WriteLine("Adolescente");
            }
            else if (n < 60)
            {
                Console.WriteLine("Adulo");
            }
            else
            {
                Console.WriteLine("Idoso");
            }

            Console.WriteLine("Fim");
            Console.ReadLine();
        }
    }
}
