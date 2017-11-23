using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces.v3._2015
{
    class Industrial:Robot
    {
        public Industrial() 
        {
            base._caminador = new NoCamina();
            base._disparador = new NoDispara();
        }
    }
}
