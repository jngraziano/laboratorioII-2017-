using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    class Raton : Animal, IPresa
    {
        //ATRIBUTOS PROPIOS

        public Raton(String nombre, Posicion posicion)
            : base(nombre, posicion)
        {
 
        }

        //MÉTODO DE LA CLASE BASE
        public override void Moverse(int x, int y)
        {
            base.Moverse(x, y);
            Console.WriteLine("El ratón se movió hacia ({0}, {1})",
                                base._posicion.PosX, base._posicion.PosY);
        }

        //MÉTODO DE LA INTERFACE IPRESA
        public void Huir(IDepredador depredador)
        {
            //OBTENGO LA POSICIÓN DEL GATO
            base._posicion.PosX += ((Gato)depredador).Posicion.PosX;

            //OBTENGO EL NOMBRE DE LA CLASE
            Console.WriteLine("El ratón se escapa del {0}", depredador.GetType().Name);
        }

    }
}
