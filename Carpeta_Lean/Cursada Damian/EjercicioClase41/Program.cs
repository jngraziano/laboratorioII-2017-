using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase41
{
    class Program
    {
        static void Main(string[] args)
        {

            Empleado a = new Empleado("Femenino");

            a.Trabajar();

            a.Comer("milanga");

            a._sueldo = 1000.00f;

            Gerente b = new Gerente("Masculino");

            PruebaProtected prueba = new PruebaProtected("Masculino");

            prueba.Comer("Pizza");
            
        
        }
    }
}
