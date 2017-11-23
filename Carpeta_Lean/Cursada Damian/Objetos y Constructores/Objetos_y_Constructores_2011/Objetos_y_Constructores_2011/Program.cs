using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos_y_Constructores_2011
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Constructor de Clase

            //new Auto();

            #endregion

            Auto fitito = new Auto();
            Auto.cantVecesInstanciada++;

            Auto chevy = new Auto();
            Auto.cantVecesInstanciada++;
            
            Auto falcon = new Auto();
            Auto.cantVecesInstanciada++;

            //INSTANCIO LA CLASE AUTO...
            fitito.marca = "FIAT";
            fitito.cantidadPuertas = 2;
            fitito.cantidadRuedas = 4;
            fitito.color = "BLANCO";           

            chevy.marca = "CHEVROLET";
            chevy.cantidadPuertas = 2;
            chevy.cantidadRuedas = 4;
            chevy.color = "ROJO";

            falcon.marca = "FORD";
            falcon.cantidadPuertas = 4;
            falcon.cantidadRuedas = 4;
            falcon.color = "VERDE";

            //MUESTRO LOS DETALLES DE CADA OBJETO
            Console.WriteLine(fitito.Mostrar());
            Console.WriteLine();

            Console.WriteLine("{0}", chevy.Mostrar());
            Console.WriteLine();

            string datos = falcon.Mostrar();
            Console.WriteLine(datos);
            Console.ReadLine();

            #region Constructores

            //Auto nuevoAuto = new Auto();

            //Auto autoConConstructor = new Auto("FERRARI", "AMARILLO", 2);

            //Console.WriteLine(nuevoAuto.Mostrar());

            //Console.WriteLine(autoConConstructor.Mostrar());

            #endregion

            #region Atributos de Clase

            //Console.WriteLine("Cantidad de objetos: {0}", Auto.cantVecesInstanciada);
            //Console.WriteLine("Fecha de utilización: {0}", Auto.fechaUtilizacion.ToLongDateString());

            //Console.WriteLine(Auto.Mostrar(autoConConstructor));
            //Console.WriteLine();

            //Console.ReadLine();
            
            #endregion

        }
    }
}
