using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaSerializacionPractica
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Centralita Telefonica = new Centralita("TELEFONICA");
            if (Telefonica.DeSerializarse())
            {
                Console.WriteLine("\nSe pudo deserealizar correctamente.");

            }
            else { Console.WriteLine("\nNo se pudo deserealizar."); }

                   
            Local llamadaLocalUno = new Local("4444-4444Orig", 0.30F, "1515151515Dest", 2.65F);
            Provincial llamadaProvincialUno = new Provincial("15618705Orig",Franja.Franja_1,0.21F,"12312Dest");
            Local llamadaLocalDos = new Local("4444-4444Orig", 0.30F, "1515151515Dest", 2.65F);
            Provincial llamadaProvincialDos = new Provincial(Franja.Franja_3, llamadaProvincialUno);
            Telefonica.RutaDeArchivo = @"F:\Facultad\Programacion II (C#) 2016\+++Solucion General+++\Graziano.Julian\CentralitaSerializacion\Centralita.xml";

            #region Esto es del ejercicio 42
            /*Esto es del ejercicio 42:
            //Telefonica.Llamadas.Add(llamadaLocalUno);
            //Telefonica.Llamadas.Add(llamadaProvincialUno);
            //Telefonica.Llamadas.Add(llamadaLocalDos);
            //Telefonica.Llamadas.Add(llamadaProvincialDos);
            */
#endregion

            //agregado ejercicio 53
            Telefonica = Telefonica + (Llamada)llamadaLocalUno;
            Console.WriteLine(llamadaLocalUno.ToString());
            Telefonica = Telefonica + llamadaLocalUno;
            Telefonica = Telefonica + llamadaProvincialUno;
            Console.WriteLine(llamadaProvincialUno.ToString());
            Telefonica = Telefonica + llamadaLocalDos;
            Console.WriteLine(llamadaLocalDos.ToString());
            Telefonica = Telefonica + llamadaProvincialDos;
            Console.WriteLine(llamadaProvincialDos.ToString());

            Console.ReadKey();
            Console.Clear();

            
            

            Console.ReadKey();
            Console.WriteLine("MUESTRO SIN ORDENAR: \n");
            Telefonica.Mostrar();
            Console.ReadKey();

            Telefonica.OrdenarLLamadas();

            Console.WriteLine("\nMUESTRO ORDENADO: \n");
            Telefonica.Mostrar();
            Console.ReadKey();

            Console.WriteLine("\nSERIALIZACIÓN: \n");
           
           
            if (Telefonica.Serializarse())
            {
                Console.WriteLine("\nSe pudo Serializar correctamente.");

            }
            else { Console.WriteLine("\nNo se pudo Serializar."); }

            if (Telefonica.DeSerializarse())
            {
                Console.WriteLine("\nSe pudo deserealizar correctamente.");

            }
            else { Console.WriteLine("\nNo se pudo deserealizar."); }


            Console.ReadKey();



        }
    }
}
