﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces.v3._2015
{
    class CaminarSobreRodillos:ICaminableComportamiento
    {
        public void Caminar()
        {
            Console.WriteLine("Camina con rodillos");
        }
    }
}
