using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_While_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Peça uma quantidade e imprima um texto o tanto de vezes informado
            
            int n;
            string texto;

            do
            {
                Console.Write("Informe um texto (DIFERENTE DE VAZIO): ");
                texto = Console.ReadLine();
            }
            while (texto == "");

            do
            {
                Console.Write("Informe a quantidade de vezes (MAIOR QUE ZERO): ");
                n = int.Parse(Console.ReadLine());
            }
            while (n <= 0);

            while(n > 0)
            {
                Console.WriteLine(texto);
                n--;
            }

            Console.ReadLine();

        }
    }
}
