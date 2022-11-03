using Dominio;
using FakeDB;
using Repositorio;
using Servico;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aplicacao
{
    public class Program
    {

        static void Main(string[] args)
        {
            BaseApp baseApp = new BaseApp();
            bool sair = false;
            int opcao;

            while (sair == false)
            {
                Console.WriteLine("--- Menu de opções ---");
                Console.WriteLine();
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Ver restaurantes");
                Console.WriteLine("2 - Fazer pedido");
                Console.WriteLine("3 - Cadastrar cliente");
                Console.WriteLine("4 - Excluir conta");
                Console.WriteLine("0 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Até logo");
                        sair = true;
                        break;
                    case 1:
                        baseApp.Mostrar();
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}





