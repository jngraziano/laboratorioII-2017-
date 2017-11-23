using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Araña:Animal, Mascota
    {
        public Araña(int patas)
            : base(patas)
        { 
        
        }

        public override void Caminar()
        {
            base.Caminar();
        }

        public override void Comer()
        {
            Console.WriteLine("La araña come insectos");
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
