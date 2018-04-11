using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace atividade
{
    class Caiaque : Embarcacao
    {
        public void locomover()
        {
            Console.WriteLine("A remo.");
        }

        public void abastecer()
        {
            Console.WriteLine("Depende da força do remador.");
        }

        public override string ToString()
        {
            return "Caiaque{Marca: " + getMarca() + ", Ano: " + getAno() + ", Pneu: " + getPneu() + ", Cor: " + getCorCasco() + "}";
        }
    }
}
