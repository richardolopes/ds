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
            int num1 = 10, num2 = 2;

            Console.WriteLine("VALORES DE INICIALIZAÇÃO DAS VARIÁVEIS");
            Console.WriteLine("num1 = {0} e num2 = {1}", num1, num2);

            num1 += num2; // MESMO QUE NUM1 = NUM1 + NUM2

            Console.WriteLine();
            Console.WriteLine("VALORES APÓS A OPERAÇÃO num1 += num2");
            Console.WriteLine("num1 = {0} e num2 = {1}", num1, num2);

            Console.ReadKey();
        }
    }
}
