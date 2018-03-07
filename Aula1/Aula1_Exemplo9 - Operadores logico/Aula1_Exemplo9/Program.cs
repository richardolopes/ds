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
            bool i, j;

            Console.WriteLine("Exemplo - Operadores Lógicos");
            Console.WriteLine("** ** ** ** ** ** ** ** ** **");
            Console.WriteLine("DIGITE true(VERDADEIRO) ou false(FALSO) \n");

            Console.Write("VALOR LÓGICO 1: ");  i = Boolean.Parse(Console.ReadLine());
            Console.Write("VALOR LÓGICO 2: ");  j = Boolean.Parse(Console.ReadLine());

            Console.WriteLine("\n RESULTADOS TESTANDO OS OPERADORES LÓGICOS \n");
            Console.WriteLine("{0} AND {1}     RESULTA {2}", i, j, i && j);
            Console.WriteLine("{0} OR {1}      RESULTA {2}", i, j, i || j);
            Console.WriteLine("VALOR 1: NOT {0}  RESULTA {1}", i, !i);
            Console.WriteLine("VALOR 2: NOT {0} RESULTA {1}", j, !j);

            Console.ReadKey();
        }
    }
}
