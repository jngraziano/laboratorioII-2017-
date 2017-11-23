using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio38
{
    class Program
    {
        static void Main(string[] args)
        {
            Vuelo unVuelo = new Vuelo(DateTime.Today,"GREGORIO SA",15000,50);
            Pasajero unPasajero = new Pasajero(true, "Perez", "37654238", "Carlos");

            unVuelo.agregarPasajero(unPasajero);
            
            decimal montoTotalVuelo = unVuelo;
        }
    }
}
