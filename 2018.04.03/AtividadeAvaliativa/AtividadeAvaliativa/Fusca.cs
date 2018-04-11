using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace atividade
{
    class Fusca : Carro
    {
        public void locomover()
        {
            Console.WriteLine("Tração 2 rodas.");
        }

        public void abastecer()
        {
            Console.WriteLine("Gasolina");
        }

        public override string ToString()
        {
            return "Fusca{Marca: " + getMarca() + ", Ano: " + getAno() + ", Pneu: " + getPneu() + ", Cor: " + getCorCarro() + "}";
        }
    }
}
