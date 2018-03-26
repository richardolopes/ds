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
            float reais;
            float dolar;
            float conversao;

            Console.Write("DIGITE UM VALOR EM REAIS (R$): ");
            reais = float.Parse(Console.ReadLine());
            Console.Write("DIGITE A COTAÇÃO DO DOLAR: ");
            dolar = float.Parse(Console.ReadLine());

            conversao = reais / dolar;

            Console.Write("O VALOR DA CONVERSAO É (REAIS PARA DOLAR) : " + conversao);

            Console.ReadKey();
        }
    }
}
