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
            const double pi = 3.1415926535897932846264338327950;

            double raio = 10;
            double area;

            Console.WriteLine("Calculo da área de um circulo \n");
            Console.WriteLine("Fórmula: área = pi * raio * raio \n");

            area = pi * Math.Pow(raio, 2);

            Console.WriteLine("Área = {0}", area);
            Console.WriteLine("Área = {0:N}", area);
            Console.WriteLine("Área = {0:N5}", area);

            Console.ReadKey();
        }
    }
}
