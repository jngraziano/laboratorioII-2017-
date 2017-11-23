using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{
    class Program
    {
        static void Main(string[] args)
        {             
     //1.Realizar un metodo de clase que reciba  tres parametros de tipo double (A, B y C) y que retorne el mayor de ellos.
        }
    }

    public class uno
    {
        double a;
        double b;
        double c;

        public static double Retornar(double A,double B, double C)
        {
            if (A > B && A > C)
                return A;
            if (B > A && B > C)
                return B;
            else
                return C;
        }
    }
}
