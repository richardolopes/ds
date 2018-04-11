using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Fusca fuscadoze = new Fusca();
            PicapeS10 picapedoze = new PicapeS10();
            Cb200 cb200doze = new Cb200();
            Caiaque caiaquedoze = new Caiaque();
            Esquilo esquilodoze = new Esquilo();
            Legacy450 legacydoze = new Legacy450();

            fuscadoze.setAno(1966);
            fuscadoze.setCorCarro("Azul");
            fuscadoze.setMarca("Volkswagen");
            fuscadoze.setPneu(4);

            picapedoze.setAno(2010);
            picapedoze.setCorCarro("Preto");
            picapedoze.setMarca("Chevrolet");
            picapedoze.setPneu(4);

            cb200doze.setAno(2008);
            cb200doze.setCor("Vermelho");
            cb200doze.setMarca("Honda");
            cb200doze.setPneu(2);

            caiaquedoze.setAno(2015);
            caiaquedoze.setCorCasco("Amarelo");
            caiaquedoze.setMarca("Explorer K2");
            caiaquedoze.setPneu(0);

            esquilodoze.setAno(2006);
            esquilodoze.setCorFuselagem("Preto");
            esquilodoze.setMarca("RAH");
            esquilodoze.setPneu(0);

            legacydoze.setAno(2010);
            legacydoze.setCorFuselagem("Azul");
            legacydoze.setMarca("AAI");
            legacydoze.setPneu(0);


            Console.WriteLine(fuscadoze.ToString());
            fuscadoze.locomover();
            fuscadoze.abastecer();
            Console.WriteLine("");

            Console.WriteLine(picapedoze.ToString());
            picapedoze.locomover();
            picapedoze.abastecer();
            Console.WriteLine("");

            Console.WriteLine(cb200doze.ToString());
            cb200doze.locomover();
            cb200doze.abastecer();
            Console.WriteLine("");

            Console.WriteLine(caiaquedoze.ToString());
            caiaquedoze.locomover();
            caiaquedoze.abastecer();
            caiaquedoze.ancorar();
            Console.WriteLine("");

            Console.WriteLine(esquilodoze.ToString());
            esquilodoze.locomover();
            esquilodoze.abastecer();
            esquilodoze.arremeter();
            Console.WriteLine("");

            Console.WriteLine(legacydoze.ToString());
            legacydoze.locomover();
            legacydoze.abastecer();
            legacydoze.arremeter();
            legacydoze.decolar(12);
            legacydoze.decolar(true);
            legacydoze.decolar("sol");

            Console.ReadKey();
        }
    }
}
