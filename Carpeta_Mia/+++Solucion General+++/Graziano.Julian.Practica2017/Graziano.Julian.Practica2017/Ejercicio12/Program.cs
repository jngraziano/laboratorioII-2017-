using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
                /*Realizar un programa que sume números enteros hasta que el
                usuario lo determine, por medio de un mensaje ―¿Continua? (S/N)‖.
                En el método estático ValidaS_N() de la clase ValidarRespuesta,
                se validará el ingreso de opciones.
                El método NO recibe parámetros y devuelve un valor de tipo
                booleano, TRUE si se ingreso una 'S' y FALSE si se ingreso una
                'N'.
                El método deberá validar si otro caracter fue ingresado mostrando
                un mensaje de error y pidiendo el reingreso del mismo.*/
            Console.Title = "Ejercicio 12";
            #region Variables
            char rta = 's';
            bool rta2;
            int aux=0,num=0;
            #endregion

            do
            {
                Console.WriteLine("\nIngrese un numero: ");
                aux = int.Parse(Console.ReadLine());
                rta2=ValidarRespuesta.ValidaS_N();
               
                if (rta2 == false)
                {
                    if (num == 0)
                    { num = aux; }
                    else { num += aux; }
                    rta = 'n';
                    break;
                }
                else
                {
                    if (num == 0)
                    { num = aux; }
                    else { num += aux; }
                }

            } while (rta != 'n');
            Console.WriteLine("\n\nResultado: {0}", num);
            Console.ReadKey();
        }
    }
}
