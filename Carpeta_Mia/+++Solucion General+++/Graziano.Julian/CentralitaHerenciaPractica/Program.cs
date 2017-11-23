using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerenciaPractica
{
    class Program
    {
        static void Main(string[] args)
        {
            //En el Main() se creará una Centralita (―Telefónica‖) y cuatro
            //llamadas. La primera llamada será de tipo Local, con una duración
            //de 30 seg. y un costo de 2.65. La segunda será Provincial (en la
            //franja 1 y con duración de 21 seg.) y las restantes: Local (45
            //seg. y 1.99) y Provincial (que recibe la segunda llamada y franja
            //3).
            //4) Las llamadas se irán registrando en la Centralita. Registrar una
            //llamada consiste en agregar a la lista genérica de tipo Llamada
            //una llamada Provincial o una llamada Local.
            //La centralita mostrará por pantalla todas las llamadas según las
            //vaya registrando (método Mostrar).
            //Luego, se ordenarán las llamadas (método OrdenarLlamadas) y se
            //volverá a mostrar por pantalla el contenido de la Centralita.

            Centralita Telefonica = new Centralita("TELEFONICA");
          
                   
            Local llamadaLocalUno = new Local("4444-4444Orig", 0.30F, "1515151515Dest", 2.65F);
            Provincial llamadaProvincialUno = new Provincial("15618705Orig",Franja.Franja_1,0.21F,"12312Dest");
            Local llamadaLocalDos = new Local("10111516Orig",0.45F, "53453Dest", 1.99F);
            Provincial llamadaProvincialDos = new Provincial(Franja.Franja_3, llamadaProvincialUno);

            Telefonica.Llamadas.Add(llamadaLocalUno);
            Telefonica.Llamadas.Add(llamadaProvincialUno);
            Telefonica.Llamadas.Add(llamadaLocalDos);
            Telefonica.Llamadas.Add(llamadaProvincialDos);

            Console.WriteLine("MUESTRO SIN ORDENAR: \n");
            Telefonica.Mostrar();
            Console.ReadKey();

            Telefonica.OrdenarLLamadas();

            Console.WriteLine("\nMUESTRO ORDENADO: \n");
            Telefonica.Mostrar();
            Console.ReadKey();

            





        }
    }
}
