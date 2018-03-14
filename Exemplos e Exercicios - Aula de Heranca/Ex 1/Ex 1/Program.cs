using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace animais
{
    class Program
    {
        static void Main(String[] args)
        {
            Mamifero animal1 = new Mamifero();
            Reptil animal2 = new Reptil();
            Aves animal3 = new Aves();
            Animal animal4 = new Animal();

            animal1.setCorPelo("Azul");
            animal1.setRaca("Qq um");
            animal1.setPeso(150);
            animal1.setIdade(36);

            animal2.setCorEscama("Vermelha");
            animal2.setIdade(15);
            animal2.setPeso(232);

            animal3.setCorPena("Laranja");
            animal2.setIdade(52);
            animal2.setPeso(751);

            animal4.setIdade(257);
            animal4.setMembros(4);
            animal4.setPeso(1712);
                        
            animal1.emitirSom();
            animal1.alimentar();
            animal1.locomover();

            Console.WriteLine(animal1.ToString());
            Console.WriteLine(animal2.ToString());
            Console.WriteLine(animal3.ToString());
            Console.WriteLine(animal4.ToString());

            Console.ReadKey();
        }
    }
}
