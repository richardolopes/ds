using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aulaHerancaPolimorfismo
{
    class Assalariado : Empregado
    {
        private double salario;

        public double getSalario()
        {
            return salario;
        }
        public void setSalario(double salario) 
        {
            this.salario = salario;
        }


        public override double vencimento()
        {
            return salario;
        }

        public override string ToString()
        {
            return "Assalariado{" + getNome() + " " + getSobrenome() + " CPF: " + getCpf() + " Salario: " + vencimento() + "}\n";
        }
    }
}
