using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace animais
{
    class Mamifero : Animal
    {
        private string corPelo;
        private string raca;

        public string getCorPelo()
        {
            return corPelo;
        }

        public void setCorPelo(string corPelo)
        {
            this.corPelo = corPelo;
        }

        public string getRaca()
        {
            return raca;
        }

        public void setRaca(string raca)
        {
            this.raca = raca;
        }

        public override string ToString()
        {
            return "Mamifero{" + "Cor do Pelo= " + corPelo + ", raça= " + raca +", peso= " + getPeso() + ", idade= " + getIdade() + "}";
        }
    }
}
