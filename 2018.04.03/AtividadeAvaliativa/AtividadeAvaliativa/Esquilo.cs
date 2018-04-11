using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace atividade
{
    class Esquilo : Aeronave
    {
        public void locomover()
        {
            Console.WriteLine("Hélice.");
        }
        public void abastecer()
        {
            Console.WriteLine("Diesel.");
        }

        public override string ToString()
        {
            return "Carro{Marca: " + getMarca() + ", Ano: " + getAno() + ", Pneu: " + getPneu() + "}"; ;
        }
    }
}
