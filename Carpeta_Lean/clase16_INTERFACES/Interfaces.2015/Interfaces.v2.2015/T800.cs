using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces.v3._2015
{
    class T800 : Robot, IDisparable, ICaminable
    {
        public void Caminar()
        {
            Console.WriteLine("Camina usando piernas robóticas...");
        }

        public void Disparar()
        {
            Console.WriteLine("Dispara con escopeta hasta exterminar objetivo...");
        }
    }
}
