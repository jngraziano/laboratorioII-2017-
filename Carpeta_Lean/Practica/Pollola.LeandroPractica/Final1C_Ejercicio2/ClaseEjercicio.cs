using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final1C_Ejercicio2
{
    class ClaseEjercicio
    {
        public static int atributo1;

        static ClaseEjercicio() 
        {
            Console.WriteLine("Constructor estatico");
            atributo1 = 1;
        }

        public ClaseEjercicio() 
        {
            Console.WriteLine("Constructor de instancia");
            atributo1 = 5;
        }

    }
}
