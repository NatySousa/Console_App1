using ConsoleApp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Repositories
{
    public class ClienteRepository
    {
       //método(função) para receber os dados de um cliente e gravar em arquivo
       public void Exportar(Cliente cliente )
        {
            var streamWriter = new StreamWriter("c:\\arquivos_C#\\clientes.txt" , true); //o true é usado para que o conteudo gravado no arquivo não seja sobrescrito e sim adicionado (qndo não usa o true por conta da sobrecarga ele grava em cima do arquivo anterior).

            //escrever os dados do cliente no arquivo

            //streamWriter.WriteLine("ID.......: " + cliente.Id); Pode ser escrito dessa forma
            streamWriter.WriteLine($"ID......................: {cliente.Id}");
            streamWriter.WriteLine($"Nome do Cliente.........: {cliente.Nome}");
            streamWriter.WriteLine($"Email...................: {cliente.Email}");
            streamWriter.WriteLine($"Data de nascimento......: {cliente.DataNascimento}");
            streamWriter.WriteLine("\n");

            //fechando o arquivo
            streamWriter.Close();


        }

    }
}
