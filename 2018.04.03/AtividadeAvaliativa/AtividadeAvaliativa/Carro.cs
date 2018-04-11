using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace atividade
{
    class Carro : Veiculo
    {
        private string corCarro;

        public string getCorCarro()
        {
            return corCarro;
        }
        public void setCorCarro(string corCarro)
        {
            this.corCarro = corCarro;
        }

        public override string ToString()
        {
            return "Carro{Marca: " + getMarca() + ", Ano: " + getAno() + ", Pneu: " + getPneu() + ", Cor: " + corCarro + "}";
        }
    }
}
