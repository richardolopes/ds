using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace atividade
{
    class Aeronave : Veiculo
    {
        private string corFuselagem;

        public void arremeter()
        {
            Console.WriteLine("Arremetendo.");
        }

        public string getCorFuselagem()
        {
            return corFuselagem;
        }
        public void setCorFuselagem(string corFuselagem)
        {
            this.corFuselagem = corFuselagem;
        }

        public override string ToString()
        {
            return "Aeronave{Marca: " + getMarca() + ", Ano: " + getAno() + ", Pneu: " + getPneu() + ", Cor: " + corFuselagem + "}";
        }
    }
}
