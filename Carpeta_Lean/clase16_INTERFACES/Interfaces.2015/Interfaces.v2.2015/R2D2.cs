using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces.v3._2015
{
    class R2D2:Robot, ICaminable
    {
        public void Caminar()
        {
            Console.WriteLine("Camina sobre tres rodillos...");
        }
    }
}
