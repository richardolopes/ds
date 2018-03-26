using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace animais
{
    class Animal
    {
        private float peso;
        private int membros;
        private int idade;

        public virtual void locomover()
        {
            Console.WriteLine("Animal se movendo-se.");
        }

        public virtual void alimentar()
        {
            Console.WriteLine("Animal se alimentando.");
        }

        public virtual void emitirSom()
        {
            Console.WriteLine("Animal emitindo som.");
        }
        // ----
        public float getPeso()
        {
            return peso;
        }

        public void setPeso(float peso)
        {
            this.peso = peso;
        }
        // ----
        public int getMembros()
        {
            return membros;
        }

        public void setMembros(int membros)
        {
            this.membros = membros;
        }

        public int getIdade()
        {
            return idade;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }

        public override string ToString()
        {
            return "Animal{" + "Peso= " + peso + ", membros = " + membros + ", idade= " + idade + "}";
        }
    }
}
