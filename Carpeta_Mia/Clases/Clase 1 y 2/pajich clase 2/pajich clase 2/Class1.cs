using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase02
{
    class Validadora
    {
        

        public static bool ValidarNumeros(int valor, int _limInf, int _limSup)
        {
            if (valor >= _limInf && valor <= _limSup)
            {
                return true;

            }
            else
            {
                return false;
            }

        }

    }
}
