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
            int idade;
            int maior;
            string verdade = "É MAIOR DE IDADE", falso = "NÃO É MAIOR DE IDADE";

            maior = 18;

            Console.Write("DIGITE SUA IDADE: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("{0} ANOS, ", idade);
            Console.WriteLine(idade >= maior ? verdade : falso);

            Console.ReadKey();
        }
    }
}
