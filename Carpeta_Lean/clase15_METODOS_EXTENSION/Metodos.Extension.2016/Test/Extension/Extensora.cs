using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Extension
{
    static class Extensora
    {

        #region Para clases propias

        //public static string ObtenerInfo(this Persona p)
        //{
        //    return p.Nombre + " - " + p.Edad;
        //}
        #endregion

        #region Para clases de terceros

        //public static string ObtenerInfo(this Alumno a)
        //{
        //    return a.Nombre + " - " + a.Apellido + " - " + a.Legajo;
        //}
        #endregion

        #region Para object

        //public static bool EsNulo(this object o)
        //{
        //    return o == null;
        //}
        #endregion

        #region Para string

        //public static int CantidadDePalabras(this string str)
        //{
        //    return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        //}
        #endregion

    }
}
