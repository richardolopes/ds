using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace atividade
{
    class PicapeS10 : Carro
    {
        public void locomover()
        {
            Console.WriteLine("Tração 4 rodas.");
        }

        public void abastecer()
        {
            Console.WriteLine("Diesel");
        }

        public override string ToString()
        {
            return "Picape S10{Marca: " + getMarca() + ", Ano: " + getAno() + ", Pneu: " + getPneu() + ", Cor: " + getCorCarro() + "}";
        }
    }
}
