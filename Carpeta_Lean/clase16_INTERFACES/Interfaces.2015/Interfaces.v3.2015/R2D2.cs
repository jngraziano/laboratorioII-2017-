﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces.v3._2015
{
    class R2D2:Robot
    {
        public R2D2()
        {
            base._caminador = new CaminarSobreRodillos();
            base._disparador = new NoDispara();
        }
    }
}
