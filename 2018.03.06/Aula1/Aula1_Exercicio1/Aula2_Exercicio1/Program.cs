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
            int idade;

            Console.Write("DIGITE SEU NOME: ");
            nome = Console.ReadLine();

            Console.Write("DIGITE O NOME DA CIDADE QUE VOCÊ RESIDE: ");
            cidade = Console.ReadLine();

            Console.Write("DIGITE SUA IDADE: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("{0}, VOCE TEM {1} ANOS DE IDADE E A CIDADE EM QUE VOCE RESIDE É {2}", nome, idade, cidade);

            Console.ReadKey();
        }
    }
}
