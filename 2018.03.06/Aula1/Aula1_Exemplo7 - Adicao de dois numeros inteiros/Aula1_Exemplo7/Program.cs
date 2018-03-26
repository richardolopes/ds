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
            int a, b, c;

            Console.Write("DIGITE UM NUMERO: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("DIGITE OUTRO NUMERO: ");
            b = Convert.ToInt32(Console.ReadLine());

            c = a + b;

            Console.Write(a + " + " + b + " = " + c);

            Console.ReadKey();
        }
    }
}
