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
            Centralita Telefonica = new Centralita();
            
            Local llamadalocal1 = new Local("4545-4242", 0.30F, "0800-333-1111", 2.65F);
            Provincial llamadaprovincial1 = new Provincial("3333-3333", Franja.Franja_1, 0.21F, "5555-5555");
            Local llamadalocal2 = new Local("8888-8888", 0.45F, "15-15426698", 1.99F);
            Provincial llamadaprovincial2 = new Provincial(Franja.Franja_3, llamadaprovincial1);

            //agrego una llamada local y una provincial
            Telefonica.Llamadas.Add(llamadalocal1);
            Telefonica.Mostrar();
            Console.ReadKey();
            Telefonica.Llamadas.Add(llamadaprovincial1);
            Telefonica.Mostrar();
            Console.ReadKey();
            //Telefonica.Llamadas.Add(llamadalocal2);
            //Telefonica.Llamadas.Add(llamadaprovincial2);
            //Telefonica.OrdenarLLamadas();




            
            
    
        }
    }
}
