using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces.v3._2015
{
    class T1000:Robot
    {
        public T1000()
        {
            base._caminador = new CaminarNormal();
            base._disparador = new DispararConTodo();
        }
    }   
}
