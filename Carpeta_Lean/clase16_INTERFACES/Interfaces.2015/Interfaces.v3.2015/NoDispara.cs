using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces.v3._2015
{
    class NoDispara:IDisparableComportamiento
    {
        public void Disparar()
        {
            Console.WriteLine("No Dispara");
        }
    }
}
