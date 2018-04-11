using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace atividade
{
    class Cb200 : Motocicleta
    {
        public void locomover()
        {
            Console.WriteLine("Tração roda traseira.");
        }

        public void abastecer()
        {
            Console.WriteLine("Álcool");
        }

        public override string ToString()
        {
            return "Cb 200{Marca: " + getMarca() + ", Ano: " + getAno() + ", Pneu: " + getPneu() + ", Cor: " + getCorMotocicleta() + "}";
        }
    }
}
