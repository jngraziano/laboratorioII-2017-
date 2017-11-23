using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploDeEnumerados
{
  


   public class Bicicleta
    {
       

        public Color Micolor;
        public string Dueño;

        public Bicicleta(string Dueño)
        {
            this.Dueño = Dueño;
      
        }

        public Bicicleta(string Dueño, Color ColorDeLaBici)
        {
            this.Dueño = Dueño;
            this.Micolor = ColorDeLaBici;
        }
    }

   
}
