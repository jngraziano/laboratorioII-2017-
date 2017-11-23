using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //CREO DISTINTOS ANIMALES
            Perro dog = new Perro("Patán", new Posicion(5, 3));
            Gato cat = new Gato("Félix", new Posicion(8, 0));
            Raton mouse = new Raton("Jerry", new Posicion(0, 0));

            //MUESTRO ESTADO Y POSICION DE LOS ANIMALES
            Console.WriteLine(mouse.ToString());
            Console.WriteLine(cat.ToString());
            Console.WriteLine(dog.ToString());

            Console.ReadLine();

            Console.WriteLine("El ratón se mueve...");
            
            mouse.Moverse(5, 5);
            
            Console.ReadLine();

            Console.WriteLine("El gato vió al ratón y va hacia él...");
            cat.Moverse(mouse.Posicion.PosX, mouse.Posicion.PosY);
            Console.ReadLine();

            cat.Cazar(mouse);
            mouse.Huir(cat);
            cat.Comer(mouse);

            Console.ReadLine();
            
            //ERROR, EL PERRO NO ES UNA PRESA
           // cat.Comer(dog);

            Console.WriteLine("Con tanto ruido, el perro ve al gato...");
            dog.Cazar(cat);

            Console.WriteLine("El perro se mueve hacia el gato...");
            dog.Moverse(cat.Posicion.PosX, cat.Posicion.PosY);
            dog.Comer(cat);


            Console.ReadLine();
        }
    }
}
