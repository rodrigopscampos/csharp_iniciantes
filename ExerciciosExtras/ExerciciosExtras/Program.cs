﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosExtras
{
    class Program
    {
        //Entrada: 
        //Idade e sexo de uma pessoa

        //Saída: 
        //Quantos anos faltam para se aposentar.
        //Mulheres se aposentam aos 60 e Homens aos 65
        static void Main(string[] args)
        {
            //Peça um número e imprima todos até zero
            Console.WriteLine("Informe um número:");
            int n = int.Parse(Console.ReadLine());

            while(n != 0)
            {
                Console.WriteLine(n);

                if(n > 0)
                {
                    n--;
                }
                else
                {
                    n++;
                }
            }

            Console.ReadLine();
        }
    }
}
