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
            int idade;
            double peso;

            Console.Write("DIGITE SEU NOME: ");
            nome = Console.ReadLine();

            Console.Write(nome + ", DIGITE SUA IDADE: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write(nome + ", DIGITE SEU PESO: ");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("\n * INFORMAÇÕES DIGITADAS * \n");
            Console.WriteLine("{0} tem {1} anos de idade e pesa {2:N3}kg", nome, idade, peso);

            Console.ReadKey();
        }
    }
}
