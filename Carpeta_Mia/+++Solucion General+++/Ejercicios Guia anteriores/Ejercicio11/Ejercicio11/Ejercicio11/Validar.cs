using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Validacion
    {
        public static bool Validar(int a, int b, int c)
        {
            bool val;
            int max = 0;
            int min = 0;
            float prom = 0;


            if(a<-100 || a>100)
            {
                val = false;
                Console.Write("Error en digito a");
                return val;

            }
            else
            {
                val = true;
                return val;
            
            }
            if(b<-100 || b>100)
            {
                val = false;
                Console.Write("Error en digito b");
                return val;

            }
            else
            {
                val = true;
                return val;

            }

            if (c < -100 || c > 100)
            {
                val = false;
                Console.Write("Error en digito c");
                return val;

            }
            else
            {
                val = true;
                return val;
            }
        }
    }
}
