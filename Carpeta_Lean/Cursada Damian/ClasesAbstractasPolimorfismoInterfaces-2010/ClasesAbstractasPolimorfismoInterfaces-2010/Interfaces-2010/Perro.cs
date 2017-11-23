using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    class Perro : Animal, IDepredador
    {
        //ATRIBUTOS PROPIOS

        public Perro(String nombre, Posicion posicion)
            : base(nombre, posicion)
        {
 
        }

        //MÉTODO DE LA CLASE BASE
        public override void Moverse(int x, int y)
        {
            base.Moverse(x, y);
            Console.WriteLine("El perro se movió hacia ({0}, {1})",
                                base._posicion.PosX, base._posicion.PosY);
        }

        //MÉTODO DE LA INTERFACE IDEPREDADOR
        public void Cazar(IPresa presa)
        {
            Console.WriteLine("El perro va a cazar un {0}",presa.GetType().Name);
        }

        //MÉTODO DE LA INTERFACE IDEPREDADOR
        public void Comer(IPresa presa)
        {
            //SI LA PERSA ESTÁ EN LA MISMA POSICIÓN EL PREDADOR COME....
            if (base._posicion.PosX == ((Gato)presa).Posicion.PosX &&
                base._posicion.PosY == ((Gato)presa).Posicion.PosY)
                Console.WriteLine("El perro se come a un {0}", presa.GetType().Name);
            else
                Console.WriteLine("El {0} se escapó...", presa.GetType().Name);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
