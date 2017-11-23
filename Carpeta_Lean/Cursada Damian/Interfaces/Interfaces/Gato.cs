using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Gato:Animal,Mascota
    {
        protected string _nombre;

        public Gato(string nombre, int patas):base(patas)
        {
            this._nombre = nombre;
        }

        public override void Caminar()
        {
            base.Caminar();
        }

        public override void Comer()
        {
            Console.WriteLine("El gato come Cat Chow");
            
        }

        public void Nombre(string nombre)
        {

        }

        public void Nombre()
        {

        }

        public void Jugar()
        {
               

        }
        
    
    
    }
}
