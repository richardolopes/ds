using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace atividade
{
    class Motocicleta : Veiculo
    {
        private string corMotocicleta;

        public string getCorMotocicleta()
        {
            return corMotocicleta;
        }
        public void setCor(string corMotocicleta)
        {
            this.corMotocicleta = corMotocicleta;
        }

        public override string ToString()
        {
            return "Motocicleta{Marca: " + getMarca() + ", Ano: " + getAno() + ", Pneu: " + getPneu() + ", Cor: " + corMotocicleta + "}";
        }
    }
}
