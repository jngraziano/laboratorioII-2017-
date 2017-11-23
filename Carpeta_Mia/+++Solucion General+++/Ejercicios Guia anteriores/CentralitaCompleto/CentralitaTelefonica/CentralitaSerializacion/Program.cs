using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace CentralitaSerializacion
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Creacion de Central y Llamadas
            Centralita Telefonica = new Centralita("Telefonica");

            Local llamadaLocaluno = new Local("4445-3333", "123-123", 0.30F, 2.65F);
            Provincial llamadaProvincialuno = new Provincial("5555-5555", Franja.Franja_1, 0.21F, "0800-333-8100");

            Local llamadaLocaldos = new Local("1313-3131", "5677-2311", 0.45F, 1.99F);
            Provincial llamadaProvincialdos = new Provincial(Franja.Franja_3, llamadaProvincialuno);

            #endregion

            #region Agregar Llamadas y Metodos

            #region Metodos del ejercicio solo Herencia
            //Telefonica.Llamadas.Add(llamadaLocaluno);
            //Telefonica.Llamadas.Add(llamadaProvincialdos);
            //Telefonica.Llamadas.Add(llamadaLocaldos);
            //Telefonica.Llamadas.Add(llamadaProvincialdos);

            //Console.WriteLine("MUESTRO SIN ORDENAR: ");
            //Telefonica.Mostrar();
            //Console.ReadKey();
            //Telefonica.OrdenarLlamadas();
            //Console.Clear();
            //Console.WriteLine("\nAHORA ORDENADO: ");
            //Telefonica.Mostrar();
            //Console.ReadKey();
            #endregion

            #region Agregado con Serializacion 1

            Telefonica.RutaDeArchivo = @"F:\Facultad\Programacion II (C#) 2016\+++Solucion General+++\Ejercicios Guia anteriores\CentralitaCompleto\CentralitaTelefonica\Centralita.xml";
            Console.WriteLine("\nSe deserializo?: ");
            Console.WriteLine(Telefonica.DesSerizarse().ToString());

            #endregion
            #region  Metodos del ejercicio Polimorfismo y tambien usado por Serializacion
            Telefonica = Telefonica + llamadaLocaluno;
            Telefonica = Telefonica + llamadaProvincialuno;
            Telefonica = Telefonica + llamadaLocaldos;
            Telefonica = Telefonica + llamadaProvincialuno;

            
            Console.WriteLine("\nLLAMADAS SIN ORDENAR: ");
            Console.WriteLine(Telefonica.ToString());
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\nLLAMADAS ORDENADAS: ");
            Telefonica.OrdenarLlamadas();
            Console.WriteLine(Telefonica.ToString());
            Console.ReadKey();

            #endregion
            #region Agregado con Serializacion 2
            Console.Clear();
            Console.WriteLine("\nSe serializo?: ");
            Console.WriteLine(Telefonica.Serializarse().ToString());

            Console.WriteLine("\nSe guarda en el txt la llamada local uno?: ");
            Console.WriteLine(Telefonica.GuardarEnArchivo(llamadaLocaluno,true).ToString());

            #endregion


            #endregion


        }
    }
}
