using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string cidade;

            Console.Write("DIGITE SEU NOME: ");
            nome = Console.ReadLine();

            Console.Write("DIGITE O NOME DA CIDADE QUE VOCÊ NASCEU: ");
            cidade = Console.ReadLine();

            Console.WriteLine("\n * INFORMAÇÕES DIGITADAS * \n");
            Console.WriteLine("SEU NOME: " + nome);
            Console.WriteLine("CIDADE DE NASCIMENTO: " + cidade);

            Console.ReadKey();
        }
    }
}
