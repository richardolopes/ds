using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorfismo
{
    class Ave : Animal
    {
        private string corPena;

        public void fazerNinho()
        {
            // ?
        }

        public string getCorPena()
        {
            return corPena;
        }

        public void setCorPena(string corPena)
        {
            this.corPena = corPena;
        }

        public override string ToString()
        {
            return "Ave{" + "Cor da Pena= " + corPena + ", idade= " + getIdade() + ", peso= " + getPeso() + "}";
        }
    }
}
