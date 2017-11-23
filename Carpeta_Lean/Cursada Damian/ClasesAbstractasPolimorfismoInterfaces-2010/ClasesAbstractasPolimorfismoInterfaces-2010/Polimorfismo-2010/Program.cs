using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesAbstractas;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //INSTANCIO DISTINTOS TRANSPORTES
            Auto autito = new Auto(2, Velocidades.Alta, 4);
            Caballo ico = new Caballo("Poni", 1, Velocidades.Minima, Colores.Marrón);
            Cohete chalenger = new Cohete(16, Velocidades.Hiper, 5, "98 Full");

            //CREO UNA LISTA GENÉRICA DE TIPO TRANSPORTE
            List<Transporte> ListaDeTransporte = new List<Transporte>();

            //AGREGO LOS DISTINTOS TIPOS DE TRANSPORTE
            ListaDeTransporte.Add(autito);
            ListaDeTransporte.Add(ico);
            ListaDeTransporte.Add(chalenger);

            //RECORRO LA LISTA CON UN FOREACH
            foreach (Transporte transporteAux in ListaDeTransporte)
            {
                //LA IMPLEMENTACIÓN SE RESUELVE EN TIEMPO DE EJECUCIÓN
                Console.WriteLine(transporteAux);

                //OTRA FORMA ES INVOCANDO EXPLÍCITAMENTE AL TOSTRING()
                //transporteAux.ToString();

                //UTILIZO LA PROPIEDAD ABSTRACTA
                Console.WriteLine(transporteAux.TiempoDeUso);

                Console.WriteLine("---------------------------------------");
            }

            Console.ReadLine();

        }
    }
}
