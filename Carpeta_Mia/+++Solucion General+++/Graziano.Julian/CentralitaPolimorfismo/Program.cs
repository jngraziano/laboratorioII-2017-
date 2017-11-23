    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismoPractica
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Centralita Telefonica = new Centralita("TELEFONICA");
          
                   
            Local llamadaLocalUno = new Local("4444-4444Orig", 0.30F, "1515151515Dest", 2.65F);
            Provincial llamadaProvincialUno = new Provincial("15618705Orig",Franja.Franja_1,0.21F,"12312Dest");
            Local llamadaLocalDos = new Local("4444-4444Orig", 0.30F, "1515151515Dest", 2.65F);
            Provincial llamadaProvincialDos = new Provincial(Franja.Franja_3, llamadaProvincialUno);

#region Esto es del ejercicio 42
            /*Esto es del ejercicio 42:
            //Telefonica.Llamadas.Add(llamadaLocalUno);
            //Telefonica.Llamadas.Add(llamadaProvincialUno);
            //Telefonica.Llamadas.Add(llamadaLocalDos);
            //Telefonica.Llamadas.Add(llamadaProvincialDos);
            */
#endregion

            //agregado ejercicio 43
            Telefonica=Telefonica+llamadaLocalUno;
            Telefonica=Telefonica+llamadaProvincialUno;
            Telefonica=Telefonica+llamadaLocalDos;
            Telefonica=Telefonica+llamadaProvincialDos;


            Console.WriteLine("MUESTRO SIN ORDENAR: \n");
            Console.WriteLine(Telefonica.ToString());
            Console.ReadKey();

            Telefonica.OrdenarLLamadas();

            Console.WriteLine("\nMUESTRO ORDENADO: \n");
            Console.WriteLine(Telefonica.ToString());
            Console.ReadKey();

            
           
            



        }
    }
}
