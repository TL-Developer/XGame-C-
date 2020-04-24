using System;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Services;

namespace XGame.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando..."); 

            var service = new ServiceJogador();
            Console.WriteLine("Criei instancia do servico...");

            AutenticarJogadorRequest request = new AutenticarJogadorRequest();
            Console.WriteLine("Criei instancia do meu objeto request...");
            request.Email = "tiago.lima@teste.com.br";
            request.Senha = "12345678";

            var response = service.AutenticarJogador(request);

            //if (service.IsValid())
            //{
            //    return response;
            //}

            Console.ReadKey();
        }
    }
}
