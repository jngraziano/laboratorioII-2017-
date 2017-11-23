using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces.v3._2015
{
    class T800 : Robot
    {
        public T800()
        {
            base._caminador = new CaminarNormal();
            base._disparador = new DispararNormal();
        }
    }
}
