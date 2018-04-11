using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace atividade
{
    class Legacy450 : Aeronave
    {
        public void locomover()
        {
            Console.WriteLine("Turbina.");
        }
        public void abastecer()
        {
            Console.WriteLine("Querosene.");
        }

        public void decolar(string clima)
        {
            if (clima == "sol")
            {
                Console.WriteLine("Voo normal.");
            }
            if (clima == "chuva" || clima == "nublado")
            {
                Console.WriteLine("Voo por instrumento.");
            }
            if (clima == "neve")
            {
                Console.WriteLine("Sem voo.");
            }
        }

        public void decolar(int horario)
        {
            if (horario >= 1 && horario <= 12)
            {
                Console.WriteLine("Altitude mais alta.");
            }
            if (horario > 12 && horario <= 18)
            {
                Console.WriteLine("Altitude média.");
            }
            if (horario > 18 && horario < 1)
            {
                Console.WriteLine("Altitude mais baixa.");
            }
        }

        public void decolar(Boolean passageiros)
        {
            if (passageiros == true)
            {
                Console.WriteLine("Servir refeição.");
            }
            else
            {
                Console.WriteLine("Amarrar bem a carga.");
            }
        }

        public override string ToString()
        {
            return "Legacy 450{Marca: " + getMarca() + ", Ano: " + getAno() + ", Pneu: " + getPneu() + ", Cor: " + getCorFuselagem() + "}";
        }
    }
}