using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Array_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implemente um algoritmo que percorra 
            //uma string e imprima apenas os números

            Console.Write("Informe um texto: ");
            string t = Console.ReadLine();

            for(int i = 0; i < t.Length; i++)
            {
                char c = t[i];

                if(c >= '0' && c <= '9')
                {
                    Console.WriteLine(c);
                }
            }

            Console.WriteLine("Fim");
            Console.ReadLine();
        }
    }
}
