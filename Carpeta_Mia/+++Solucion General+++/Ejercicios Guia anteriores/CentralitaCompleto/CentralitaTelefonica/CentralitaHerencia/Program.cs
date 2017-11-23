using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            /*En el Main() se creará una Centralita (―Telefónica‖) y cuatro
            llamadas. La primera llamada será de tipo Local, con una duración
            de 30 seg. y un costo de 2.65. La segunda será Provincial (en la
            franja 1 y con duración de 21 seg.) y las restantes: Local (45
            seg. y 1.99) y Provincial (que recibe la segunda llamada y franja
            3).
            4) Las llamadas se irán registrando en la Centralita. Registrar una
            llamada consiste en agregar a la lista genérica de tipo Llamada
            una llamada Provincial o una llamada Local.
            La centralita mostrará por pantalla todas las llamadas según las
            vaya registrando (método Mostrar).
            Luego, se ordenarán las llamadas (método OrdenarLlamadas) y se
            volverá a mostrar por pantalla el contenido de la Centralita.
             * */
            Centralita Telefonica = new Centralita("Telefonica");

            Local llamadaLocaluno = new Local("4445-3333", "123-123", 0.30F, 2.65F);
            Provincial llamadaProvincialuno = new Provincial("5555-5555", Franja.Franja_1, 0.21F, "0800-333-8100");

            Local llamadaLocaldos = new Local("1313-3131", "5677-2311", 0.45F, 1.99F);
            Provincial llamadaProvincialdos = new Provincial(Franja.Franja_3,llamadaProvincialuno);

            #region Agregar Llamadas y Mostrar sin Ordenar
            Telefonica.Llamadas.Add(llamadaLocaluno);
            Telefonica.Llamadas.Add(llamadaProvincialdos);
            Telefonica.Llamadas.Add(llamadaLocaldos);
            Telefonica.Llamadas.Add(llamadaProvincialdos);
            Console.WriteLine("MUESTRO SIN ORDENAR: ");
            Telefonica.Mostrar();
            Console.ReadKey();
            #endregion

            Telefonica.OrdenarLlamadas();
            Console.Clear();
            Console.WriteLine("\nAHORA ORDENADO: ");
            Telefonica.Mostrar();
            Console.ReadKey();


        }
    }
}
