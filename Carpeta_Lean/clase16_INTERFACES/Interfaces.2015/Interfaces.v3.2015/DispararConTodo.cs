﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces.v3._2015
{
    class DispararConTodo:IDisparableComportamiento
    {
        public void Disparar()
        {
            Console.WriteLine("Dispara con cualquier cosa, al mismo tiempo!!!");
        }
    }
}
