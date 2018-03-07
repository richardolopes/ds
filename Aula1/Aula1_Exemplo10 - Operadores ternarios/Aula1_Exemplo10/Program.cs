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
            int a, b;
            string verdade = "SIM", falso = "NÃO";

            Console.Write("DIGITE UM NUMERO INTEIRO: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("DIGITE OUTRO NUMERO INTEIRO: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("{0} > {1}? RESPOSTA: ", a, b);
            Console.WriteLine(a > b ? verdade : falso);

            Console.ReadKey();
        }
    }
}
