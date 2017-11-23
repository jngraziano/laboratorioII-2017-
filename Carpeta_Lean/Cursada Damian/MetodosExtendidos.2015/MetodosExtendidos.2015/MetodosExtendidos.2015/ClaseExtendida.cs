using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetodosExtendidos._2015
{
    public static class ClaseExtendida
    {
        public static string MetodoExtendido(this string cadena) 
        {
            return cadena + " - " + cadena;
        }

        public static int MetodoExtendido2(this string cadena) 
        {
            return 1;
        }

        public static string MetodoExtendido3(this Persona p)
        {
            return p.ToString();
        }


    }
}
