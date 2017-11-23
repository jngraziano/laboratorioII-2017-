using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio43
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Enunciado ejercicio 43
                //Crear la clase Colectivo que posea: patente, marca, cantidad de
                //asientos. Un método estático ValidarAsientos, un método virtual
                //SetearKm y un método abstracto indicarVelocidad.
                //Además crear tres clases (CortaDistancia, MediaDistancia y
                //LargaDistancia) que hereden de la primera y que contengan
                //atributos y métodos propios.
                //Se pide que por medio de un menú el ingreso de pasajeros para los
                //micros, ingresar destinos, ingresar precio de pasajes, calcular
            //mejor recaudación, mostrar datos de los micros.
            #endregion

            Colectivo colectivo1 = new Colectivo("AAA123","mercedes",40);

        }
    }
}
