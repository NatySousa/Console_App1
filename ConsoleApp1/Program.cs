//Localização da classe dentro do projeto

using ConsoleApp1.Entities;
using ConsoleApp1.Repositories;

namespace ConsoleApp1
{ 
    //definição da classe
    public class Program
    {
        //método para executar o projeto
        public static void Main(string[] args)
        {
            Console.WriteLine("Aula 01 -Csharp WebDeveloper");
            Console.WriteLine("Exportar dados de cliente:");
            Console.WriteLine("\n");

            //criando um objeto da classe Cliente
            var cliente = new Cliente();

            try
            {
                //gerando o ID do cliente (chave guid)
                cliente.Id = Guid.NewGuid();

                Console.Write("Informe o nome do cliente........: ");
                cliente.Nome = Console.ReadLine();

                Console.Write("Informe o email do cliente.......: ");
                cliente.Email = Console.ReadLine();

                Console.Write("Informe a data de nascimento.: ");
                cliente.DataNascimento = DateTime.Parse(Console.ReadLine());

                //criando um objeto da classe ClienteRepository

                var clienteRepository = new ClienteRepository();

                // gravando os dados do cliente

                clienteRepository.Exportar(cliente);

                Console.WriteLine("\nDados Gravados Com Sucesso!");


            }
            catch (Exception e)
            {
                Console.WriteLine($"\nOcorreu um erro: ${e.Message}");

                Console.WriteLine("\nDeseja tentar novamente? (S,N): ");
                var opcao = Console.ReadLine();

                if(opcao.Equals("S",StringComparison.OrdinalIgnoreCase))
                {
                    Console.Clear();//limpar conteúdo da tela
                    Main(args); //recursividade
                }


    
            }

            

            //pausar a execução do prompt
            Console.ReadKey();
        }
    }
}
