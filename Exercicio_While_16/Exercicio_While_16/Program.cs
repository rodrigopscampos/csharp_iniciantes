using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_While_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicite usuário e senha até que a o 
            //usuário seja “aspnetmvc” e senha “aspnetmvc”

            while(true) //infinitamente
            {
                //pede usuário
                Console.Write("Usuário: ");
                string usuario = Console.ReadLine();

                //pede senha
                Console.Write("Senha: ");
                string senha = Console.ReadLine();

                //se o usuário for "aspnetmvc" E TAMBÉM a senha for aspnetmvc, entra no if
                //que chama o break e quebra o laço
                if(usuario == "aspnetmvc" && senha == "aspnetmvc")
                {
                    break;
                }

                //se não entrar no if, escreve a mensagem abaixo
                Console.WriteLine("Usuário ou senha inválido, tente novamente");
            }

            //se entra no if, chama o break que quebra o laço e escreve a mensagem abaixo
            Console.WriteLine("Acesso liberado");

            //só p aguardar o usuário pressionar enter
            Console.ReadLine();
        }
    }
}
