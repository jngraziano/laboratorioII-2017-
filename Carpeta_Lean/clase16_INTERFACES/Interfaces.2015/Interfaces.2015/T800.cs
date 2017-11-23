using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces._2015
{
    class T800:Robot
    {
        public override void Caminar()
        {
            Console.WriteLine("Camina usando piernas robóticas...");
        }

        public override void Disparar()
        {
            Console.WriteLine("Dispara con escopetas hasta exterminar objetivo...");
        }
    }
}
