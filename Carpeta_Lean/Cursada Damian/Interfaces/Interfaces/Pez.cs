using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Pez:Animal,Mascota
    {
        protected string _nombre;

        public Pez(string nombre, int patas):base(patas)
        {
            this._nombre = nombre;
        }

        public override void Caminar()
        {
            base.Caminar();
        }

        public override void Comer()
        {
            Console.WriteLine("El Pez come alimento.. piedritas con olor raro");
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
