using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace atividade
{
    class Embarcacao : Veiculo
    {
        private string corCasco;

        public void ancorar()
        {
            Console.WriteLine("Ancorando.");
        }

        public string getCorCasco()
        {
            return corCasco;
        }
        public void setCorCasco(string corCasco)
        {
            this.corCasco = corCasco;
        }

        public override string ToString()
        {
            return "Embarcacao{Marca: " + getMarca() + ", Ano: " + getAno() + ", Pneu: " + getPneu() + ", Cor: " + corCasco + "}";
        }
    }
}
