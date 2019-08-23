using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_While_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leia um número da tela e imprima a tabuada de 0 a 10	

            while(true)
            {
                Console.Write("Informe um número ou Enter para finalizar: ");
                string texto = Console.ReadLine();

                if(texto == "")
                {
                    break;
                }

                float tab = float.Parse(texto);
                Console.Clear();

                int numDeZeroADez = 0;

                while (numDeZeroADez <= 10)
                {
                    float resultado = tab * numDeZeroADez;
                    Console.WriteLine(tab + " X " + numDeZeroADez + " = " + resultado);

                    numDeZeroADez++;
                }
            }

            
        }
    }
}
