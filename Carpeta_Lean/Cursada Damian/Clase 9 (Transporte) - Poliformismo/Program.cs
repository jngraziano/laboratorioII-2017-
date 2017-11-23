using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_9__Transporte_
{
    class Program
    {
        static void Main(string[] args)
        {

            Bicicleta bici = new Bicicleta(28, eVelocidad.baja, "20 años");

            Caballo caballo = new Caballo(eVelocidad.media, "15 años", "marron", "carrera");

            Auto auto = new Auto(eVelocidad.super, "3 años", 4, "LXU 031");

            Cohete cohete = new Cohete(eVelocidad.hiper, "5 años", "Rocket", 5);

            List<Transporte> lista = new List<Transporte>();

            lista.Add(bici);
            lista.Add(caballo);
            lista.Add(auto);
            lista.Add(cohete);

            foreach (Transporte t in lista)
            {
                Console.WriteLine(t.ToString());
            }

            Console.ReadKey();


            bici.Frenar();

            Console.ReadKey();

        }
    }
}
