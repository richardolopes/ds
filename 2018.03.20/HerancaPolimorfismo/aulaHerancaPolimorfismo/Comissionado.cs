using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aulaHerancaPolimorfismo
{
    class Comissionado : Empregado
    {
        private double totalVenda;
        private double taxaComissao;
        private double salario;

        public double getTotalVenda()
        {
            return totalVenda;
        }
        public void setTotalVenda(double totalVenda)
        {
            this.totalVenda = totalVenda;
        }


        public double getTaxaComissao()
        {
            return taxaComissao;
        }
        public void setTaxaComissao(double taxaComissao)
        {
            this.taxaComissao = taxaComissao;
        }


        public override double vencimento()
        {
            salario = totalVenda * taxaComissao;
            return salario;
        }

        public override string ToString()
        {
            return "Comissionado{" + getNome() + " " + getSobrenome() + " CPF: " + getCpf() + " Salario: " + vencimento() + "}\n";
        }
    }
}
