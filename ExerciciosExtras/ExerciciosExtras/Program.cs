using System;
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
            Console.Write("Informe a idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Informe o sexo (M/F): ");
            string sexo = Console.ReadLine();

            if(sexo == "m" || sexo == "M" || sexo == "f" || sexo == "F")
            {
                if (sexo == "m" || sexo == "M" || sexo == "masculino" && idade < 65)
                {
                    if(idade >= 65)
                    {
                        Console.WriteLine("Você já tem direito");
                    }
                    else
                    {
                        int anosParaSeAposentar = 65 - idade;
                        Console.WriteLine(
                 "Faltam " + anosParaSeAposentar + " anos para você se aposentar");
                    }
                }
                else
                {
                    if(idade >= 60)
                    {
                        Console.WriteLine("Você já tem direito");
                    }
                    else
                    {
                        int anosParaSeAposentar = 60 - idade;
                        Console.WriteLine(
                 "Faltam " + anosParaSeAposentar + " anos para você se aposentar");
                    }
                }
            }
            else
            {
                Console.WriteLine("Opção de sexo inválida\nOs valores aceitos são: M para Masculino e F para feminino");
            }

            Console.ReadLine();
        }
    }
}
