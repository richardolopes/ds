using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorfismo
{
    class Cachorro : Mamifero
    {
        private void enterrarOsso()
        {
            Console.WriteLine("Animal enterrando o osso.");
        }
        private void abanarRabo()
        {
            Console.WriteLine("Animal abanando o rabo.");
        }
        // -----
        public void reagir(string atitude)
        {
            if (atitude == "brincar" || atitude == "acariciar")
            {
                Console.WriteLine("Abanando o rabo.");
            } 
            else 
            {
                Console.WriteLine("Rosnando");
            }
        }

        public void reagir(int hora)
        {
            if (hora < 12)
            {
                Console.WriteLine("Abanando o rabo e latindo.");
            }
            else
            {
                if (hora >= 18)
                {
                    Console.WriteLine("Ignorando o dono.");
                }
                else
                {
                    Console.WriteLine("Abanando o rabo.");
                }
            }
        }

        public void reagir(Boolean dono)
        {
            if (dono == true)
            {
                Console.WriteLine("Abanando o rabo e brincando.");
            }
            else
            {
                Console.WriteLine("Avançando e rosnando.");
            }
        }

    }
}
