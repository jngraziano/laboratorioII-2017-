using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class CalculoDeArea
    {

            //posea 3 métodos de
            //clase (estáticos), double CalcularCuadrado(double), double
            //CalcularTriangulo(double, double) y double
            //CalcularCirculo(double), que realicen el cálculo del área que
            //corresponda.

        public static double CalcularCuadrado(double a)
        { return a * a; }
        public static double CalcularTriangulo(double b, double c)
        { return (b * c) / 2; }
        public static double CalcularCirculo(double d)
        { return 3.14 * d; }
    }
}
