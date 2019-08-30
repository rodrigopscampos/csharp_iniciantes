using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Array_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crie um array de inteiros de comprimento 10000 
            //e preencha com os números de 1 a 10000

            int[] array = new int[10000];

            for (int i = 0; i < 10000; i++)
            {
                array[i] = i + 1;
            }
        }
    }
}
