using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace atividade
{
    class Veiculo
    {
        private string marca;
        private int ano;
        private int pneu;

        public virtual void locomover()
        {
            Console.WriteLine("Veiculo se locomovendo.");
        }

        public virtual void abastecer()
        {
            Console.WriteLine("Veiculo abastecendo.");
        }
        //  ------
        public string getMarca()
        {
            return marca;
        }
        public void setMarca(string marca)
        {
            this.marca = marca;
        }
        //
        public int getAno()
        {
            return ano;
        }
        public void setAno(int ano)
        {
            this.ano = ano;
        }
        //
        public int getPneu()
        {
            return pneu;
        }
        public void setPneu(int pneu)
        {
            this.pneu = pneu;
        }
        //

        public override string ToString()
        {
            return "Veiculo{Marca: " + marca + ", Ano: " + ano + ", Pneu: " + pneu + "}";
        }
    }
}
