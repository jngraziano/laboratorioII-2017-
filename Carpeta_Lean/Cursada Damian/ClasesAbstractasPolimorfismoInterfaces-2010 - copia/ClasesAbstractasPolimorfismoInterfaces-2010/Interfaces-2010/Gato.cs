using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    class Gato : Animal, IDepredador, IPresa
    {
        //ATRIBUTOS PROPIOS

        public Gato(String nombre, Posicion posicion)
            : base(nombre, posicion)
        {
 
        }

        //MÉTODO DE LA CLASE BASE
        public override void Moverse(int x, int y)
        {
            base.Moverse(x, y);
            Console.WriteLine("El gato se movió hacia ({0}, {1})",
                                base._posicion.PosX, base._posicion.PosY);
        }

        //MÉTODO DE LA INTERFACE IPRESA
        public void Huir(IDepredador depredador)
        {
            //OBTENGO LA POSICIÓN DEL PERRO
            base._posicion.PosX += ((Perro)depredador).Posicion.PosX;

            //OBTENGO EL NOMBRE DE LA CLASE
            Console.WriteLine("El gato se escapa del {0}", depredador.GetType().Name);
        }

        //MÉTODO DE LA INTERFACE IDEPREDADOR
        public void Cazar(IPresa presa)
        {
            Console.WriteLine("El gato va a cazar un {0}",presa.GetType().Name);
        }

        //MÉTODO DE LA INTERFACE IDEPREDADOR
        public void Comer(IPresa presa)
        {
            //SI LA PERSA ESTÁ EN LA MISMA POSICIÓN EL PREDADOR COME....
            if (base._posicion.PosX == ((Raton)presa).Posicion.PosX &&
                base._posicion.PosY == ((Raton)presa).Posicion.PosY)
                Console.WriteLine("El gato se come a un {0}", presa.GetType().Name);
            else
                Console.WriteLine("El {0} se escapó...", presa.GetType().Name);
        }

    }
}
