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
            float a;
            float b;
            float c;
            double resultado;

            Console.Write("DIGITE O VALOR PARA A: ");
            a = float.Parse(Console.ReadLine());

            Console.Write("DIGITE O VALOR PARA B: ");
            b = float.Parse(Console.ReadLine());

            Console.Write("DIGITE O VALOR PARA C: ");
            c = float.Parse(Console.ReadLine());

            resultado = a * a * 5 - c / (b - a % 4);

            Console.Write("O RESULTADO DA EXPRESSAO MATEMATICA É: " + resultado);

            Console.ReadKey();
        }
    }
}
