using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces._2015
{
    class R2D2:Robot
    {
        public override void Caminar()
        {
            Console.WriteLine("Camina sobre rodillos...");
        }

        public override void Disparar()
        {
            Console.WriteLine("No dispara.");
        }
    }
}
