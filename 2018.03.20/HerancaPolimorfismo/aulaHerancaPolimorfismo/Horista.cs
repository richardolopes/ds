using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aulaHerancaPolimorfismo
{
    class Horista : Empregado
    {
        private double precoHora;
        private double horasTrabalhadas;
        private double salario;

        public double getPrecoHora()
        {
            return precoHora;
        }
        public void setPrecoHora(double precoHora)
        {
            this.precoHora = precoHora;
        }


        public double getHorasTrabalhadas()
        {
            return horasTrabalhadas;
        }
        public void setHorasTrabalhadas(double horasTrabalhadas)
        {
            this.horasTrabalhadas = horasTrabalhadas;
        }


        public override double vencimento()
        {
            salario = precoHora * horasTrabalhadas;
            return salario;
        }

        public override string ToString()
        {
            return "Horista{" + getNome() + " " + getSobrenome() + " CPF: " + getCpf() + " Salario: " + vencimento() + "}\n";
        }    }
}
