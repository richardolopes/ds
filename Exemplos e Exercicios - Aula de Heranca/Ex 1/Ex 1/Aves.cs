using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace animais
{
    class Aves : Animal
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
            return "Aves{" + "Cor da Pena= " + corPena + ", idade= " + getIdade() + ", peso= " + getPeso() + "}";
        }
    }
}
