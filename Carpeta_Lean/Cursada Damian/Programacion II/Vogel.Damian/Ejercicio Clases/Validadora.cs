using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clases
{
    class Validadora
    {
        public int numero;
        public int max;
        public int min;


        public static bool ValidarNumeros(int numero, int max, int min)
            {
            if (numero > min && numero < max)
                return true;

            return false;
            }
        
        
        }       
}