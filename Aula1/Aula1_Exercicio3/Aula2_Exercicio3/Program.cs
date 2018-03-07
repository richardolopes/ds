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
            float x;
            double y;

            Console.Write("DIGITE UM NUMERO: ");
            x = float.Parse(Console.ReadLine());

            y = Math.Pow(x, 2);

            Console.Write("O QUADRADO DO NUMERO QUE FOI DIGITADO É: " + y);

            Console.ReadKey();
        }
    }
}
