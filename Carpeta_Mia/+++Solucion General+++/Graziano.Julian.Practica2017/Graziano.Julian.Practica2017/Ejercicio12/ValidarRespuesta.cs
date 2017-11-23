using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class ValidarRespuesta
    {
        /*En el método estático ValidaS_N() de la clase ValidarRespuesta,
                se validará el ingreso de opciones.
                El método NO recibe parámetros y devuelve un valor de tipo
                booleano, TRUE si se ingreso una 'S' y FALSE si se ingreso una
                'N'.
                El método deberá validar si otro caracter fue ingresado mostrando
                un mensaje de error y pidiendo el reingreso del mismo.*/
        
        public static bool ValidaS_N()
        {
            char rta;
            Console.WriteLine("\n\n―¿Continua? (S/N): ");
            rta = char.Parse(Console.ReadLine());
            if (rta == 's')
            { return true; }
            else if (rta == 'n')
            { return false; }
            else { Console.WriteLine("\nDebe ingresar s/n."); return ValidarRespuesta.ValidaS_N();  }

        }
    }
}
