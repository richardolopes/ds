using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aulaHerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Empregado empregado1 = new Empregado();
            empregado1.setNome("Malakoi");
            empregado1.setSobrenome("do Hebraico");
            empregado1.setCpf("785.698.564-96");

            Assalariado assalariado1 = new Assalariado();
            assalariado1.setNome("Richard");
            assalariado1.setSobrenome("Oliveira");
            assalariado1.setCpf("214.236.258-02");
            assalariado1.setSalario(1000);

            Comissionado comissionado1 = new Comissionado();
            comissionado1.setNome("José");
            comissionado1.setSobrenome("Noah");
            comissionado1.setCpf("866.953.528-95");
            comissionado1.setTaxaComissao(0.05);
            comissionado1.setTotalVenda(10000);

            Horista horista1 = new Horista();
            horista1.setNome("Maria");
            horista1.setSobrenome("Lima");
            horista1.setCpf("449.669.557-02");
            horista1.setHorasTrabalhadas(15);
            horista1.setPrecoHora(1000);


            Console.WriteLine(empregado1.ToString());
            Console.WriteLine(assalariado1.ToString());
            Console.WriteLine(comissionado1.ToString());
            Console.WriteLine(horista1.ToString());
            Console.ReadKey();
        }
    }
}
