using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces._2015
{
    class Robot
    {
        public virtual void Caminar()
        {
            Console.WriteLine("Implementar forma de caminar...");
        }

        public virtual void Disparar()
        {
            Console.WriteLine("Implementar forma de disparar...");
        }
    }
}
